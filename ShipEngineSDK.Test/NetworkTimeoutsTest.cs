using Moq.Protected;
using ShipEngineSDK;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class NetworkRetriesTest
    {
        readonly string VoidLabelResponse;
        readonly string rateLimitResponse;
        HttpResponseMessage RateLimitResponseMessage;

        public NetworkRetriesTest()
        {
            rateLimitResponse = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/RateLimited429Response.json"));
            VoidLabelResponse = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            RateLimitResponseMessage = new HttpResponseMessage((HttpStatusCode)429);
            RateLimitResponseMessage.Content = new StringContent(rateLimitResponse);
            RateLimitResponseMessage.Headers.Add("RetryAfter", "1");
        }

        [Fact]
        public async Task RetryOnceByDefault()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(2));
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(RateLimitResponseMessage));

            var stopwatch = Stopwatch.StartNew();

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            // Default retry is 1.
            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 2);

            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.RateLimitExceeded, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }

        [Fact]
        public async Task CustomRetriesSetting()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(2), retries: 2);
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent(VoidLabelResponse)
                    }
                ));

            await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234");

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 3);
        }

        [Fact]
        public async Task RetriesDisabled()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(2), retries: 0);
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent(VoidLabelResponse)
                    }
                ));

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 1);

            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.RateLimitExceeded, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }

        // Retry after is set to 2 seconds. Total elapsed time should be greater
        [Fact]
        public async Task RetriesWaitTheCorrectAmountOfTime()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(2));
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(RateLimitResponseMessage));

            var stopwatch = Stopwatch.StartNew();

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            stopwatch.Stop();

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 2);

            var duration = stopwatch.Elapsed;

            Assert.Equal(1, TimeSpan.Compare(stopwatch.Elapsed, TimeSpan.FromSeconds(0.9)));
        }

        [Fact]
        public async Task RetryAfterIsGreaterThanTimeoutSetting()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(RateLimitResponseMessage));

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 1);

            Assert.Equal("The request took longer than the 500 milliseconds allowed", ex.Message);
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.Timeout, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }

        // Regression: TimeSpan.Seconds returns only the seconds component (0-59),
        // so a timeout of 60+ seconds would incorrectly compare as 0 and always
        // throw a timeout exception instead of retrying.
        [Fact]
        public async Task RetryWorksWithTimeoutGreaterThanOrEqualTo60Seconds()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(60), retries: 1);
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(RateLimitResponseMessage))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent(VoidLabelResponse)
                    }
                ));

            // Should retry successfully, not throw a timeout exception
            await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234");

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 2);
        }

        [Fact]
        public async Task TimeoutMessageShowsCorrectMillisecondsForLargeTimeouts()
        {
            // RetryAfter header is 1 second; set timeout to 0.5s so it triggers the timeout path
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromMilliseconds(1500), retries: 1);
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            var rateLimitWithHighRetryAfter = new HttpResponseMessage((HttpStatusCode)429);
            rateLimitWithHighRetryAfter.Content = new StringContent(rateLimitResponse);
            rateLimitWithHighRetryAfter.Headers.Add("RetryAfter", "2");

            mockShipEngineFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Put &&
                        m.RequestUri.AbsolutePath == "/v1/labels/se-1234/void"),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(rateLimitWithHighRetryAfter));

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            Assert.Equal("The request took longer than the 1500 milliseconds allowed", ex.Message);
            Assert.Equal(ErrorCode.Timeout, ex.ErrorCode);
        }
    }
}
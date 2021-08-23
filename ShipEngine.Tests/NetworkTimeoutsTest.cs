using Moq.Protected;
using ShipEngineSDK;
using ShipEngineSDK.CreateLabelFromShipmentDetails.Params;
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
        public async void RetryOnceByDefault()
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

            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.RateLimitExceeded, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }

        [Fact]
        public async void CustomRetriesSetting()
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
        public async void RetriesDisabled()
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

            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.RateLimitExceeded, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }

        // Retry after is set to 2 seconds. Total elapsed time should be greater
        [Fact]
        public async void RetriesWaitTheCorrectAmountOfTime()
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
        public async void RetryAfterIsGreaterThanTimeoutSetting()
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
            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.System, ex.ErrorType);
            Assert.Equal(ErrorCode.Timeout, ex.ErrorCode);
            Assert.Equal("204c855f-dcc0-4270-ba12-c585fc5ef4bf", ex.RequestId);
        }
    }
}
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
        string VoidLabelResponse;
        string rateLimitResponse;
        HttpResponseMessage RateLimitResponseMessage;

        public NetworkRetriesTest()
        {
            rateLimitResponse = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/RateLimited429Response.json"));
            VoidLabelResponse = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            RateLimitResponseMessage = new HttpResponseMessage((HttpStatusCode)429);
            RateLimitResponseMessage.Content = new StringContent(rateLimitResponse);
            RateLimitResponseMessage.Headers.Add("RetryAfter", "2");
        }

        [Fact]
        public async void DefaultRetryOn429()
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
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent(VoidLabelResponse)
                    }
                ));

            var stopwatch = Stopwatch.StartNew();

            await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234");

            stopwatch.Stop();

            // Default retry is 1.
            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 2);

            var duration = stopwatch.Elapsed;
            Assert.Equal(1, TimeSpan.Compare(stopwatch.Elapsed, TimeSpan.FromSeconds(2)));
        }


        //ToDo: Retry custom number of retry
        [Fact]
        public async void CustomConfigRetries()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(0.5), retries: 2);
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

        //TODO: No Retry when retry is disabled (i.e. set to 0)
        [Fact]
        public async void NoRetries()
        {
            var config = new Config(apiKey: "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", timeout: TimeSpan.FromSeconds(0.5), retries: 0);
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

            await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, "/v1/labels/se-1234/void", numberOfCalls: 1);
        }
    }
}
namespace ShipEngineTest
{
    using Moq;
    using Moq.Protected;
    using ShipEngineSDK;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading;
    using System.Threading.Tasks;

    public class MockShipEngineFixture
    {
        public MockShipEngineFixture(Config config)
        {
            MockHandler = new Mock<HttpClientHandler>
            {
                CallBase = true,
            };
            HttpClient = new HttpClient(MockHandler.Object);

            var client = ShipEngineClient.ConfigureHttpClient(config, HttpClient);
            ShipEngine = new ShipEngine(config, client);

            JsonSerializerOptions = new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            };
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public HttpClient HttpClient { get; }

        public ShipEngine ShipEngine { get; }

        public JsonSerializerOptions JsonSerializerOptions { get; set; }

        /// <summary>
        /// Resets the mock's state.
        /// </summary>
        public void Reset()
        {
            MockHandler.Reset();
        }

        /// <summary>
        /// Asserts that a single HTTP request was made with the specified method and path.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        public void AssertRequest(HttpMethod method, string path, int numberOfCalls = 1)
        {
            MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Exactly(numberOfCalls),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == method &&
                        m.RequestUri.AbsolutePath == path),
                    ItExpr.IsAny<CancellationToken>());
        }


        /// <summary>
        /// Stubs an HTTP request with the specified method and path to return the specified status
        /// code and response body.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        /// <param name="status">The status code to return.</param>
        /// <param name="response">The response body to return.</param>
        public string StubRequest(HttpMethod method, string path, HttpStatusCode status, string response)
        {
            var requestId = Guid.NewGuid().ToString();
            var responseMessage = new HttpResponseMessage(status);
            responseMessage.Content = new StringContent(response);
            responseMessage.Headers.Add("x-shipengine-requestid", requestId);
            responseMessage.Headers.Add("request-id", requestId);

            MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == method &&
                        m.RequestUri.AbsolutePath == path),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
            return requestId;
        }
    }
}
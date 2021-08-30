namespace ShipEngineTest
{
    using Moq;
    using Moq.Protected;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using ShipEngineSDK;
    using System.Net;
    using System.Net.Http;
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

            ShipEngine = new ShipEngine(config)
            {
                _client = ShipEngineClient.ConfigureHttpClient(config, HttpClient)
            };

            JsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public HttpClient HttpClient { get; }

        public ShipEngine ShipEngine { get; }

        public JsonSerializerSettings JsonSerializerSettings { get; set; }

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
        public void StubRequest(HttpMethod method, string path, HttpStatusCode status, string response)
        {
            var responseMessage = new HttpResponseMessage(status);
            responseMessage.Content = new StringContent(response);

            MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == method &&
                        m.RequestUri.AbsolutePath == path),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
        }
    }
}
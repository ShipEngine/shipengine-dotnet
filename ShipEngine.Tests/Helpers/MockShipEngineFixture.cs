namespace ShipEngineTest
{
    using Moq;
    using Moq.Protected;
    using ShipEngineSDK;
    using System;
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

            ShipEngine = new ShipEngine(config);

            ShipEngine._client = ShipEngineClient.ConfigureHttpClient(config, HttpClient);
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public HttpClient HttpClient { get; }

        public ShipEngine ShipEngine { get; }

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
        public void AssertRequest(HttpMethod method, string path)
        {
            MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
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
        public void StubRequest(HttpMethod method, string path, HttpStatusCode status, string response, int timeout = 6)
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
                .Returns(() =>
                {
                    Thread.Sleep(timeout);
                    return Task.FromResult(responseMessage);
                });
        }
    }
}
namespace ShipEngineTest
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;

    public class MockHttpClientFixture
    {
        public MockHttpClientFixture()
        {
            this.MockHandler = new Mock<HttpClientHandler>
            {
                CallBase = true,
            };
            this.HttpClient = new HttpClient(this.MockHandler.Object);

            this.HttpClient.DefaultRequestHeaders.Add("User-Agent", "User-Agent-goes-here");
            this.HttpClient.DefaultRequestHeaders.Add("Api-Key", "test_1234");
            this.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            this.HttpClient.BaseAddress = new Uri("https://api.shipengine.com");
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public HttpClient HttpClient { get; }

        /// <summary>
        /// Resets the mock's state.
        /// </summary>
        public void Reset()
        {
            this.MockHandler.Reset();
        }

        /// <summary>
        /// Asserts that a single HTTP request was made with the specified method and path.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        public void AssertRequest(HttpMethod method, string path)
        {
            this.MockHandler.Protected()
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
        public void StubRequest(HttpMethod method, string path, HttpStatusCode status, string response)
        {
            var responseMessage = new HttpResponseMessage(status);
            responseMessage.Content = new StringContent(response);

            this.MockHandler.Protected()
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

namespace ShipEngineTest
{
    using ShipEngineSDK;
    using ShipEngineSDK.VoidLabelWithLabelId;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xunit;

    public class ShipEngineClientTests
    {
        [Fact]
        public void ConfigureSetsDefaultBaseAddressOnHttpClient()
        {
            var httpClient = new HttpClient();
            var returnedClient = ShipEngineClient.ConfigureHttpClient(httpClient, "my-api-key", null);

            Assert.Same(httpClient, returnedClient);
            Assert.Equal("https://api.shipengine.com/", httpClient.BaseAddress.ToString());
        }

        [Fact]
        public void ConfigureAllowsSettingBaseAddressOnHttpClient()
        {
            var httpClient = new HttpClient();
            var returnedClient = ShipEngineClient.ConfigureHttpClient(httpClient, "my-api-key", new Uri("http://localhost:5454/"));

            Assert.Same(httpClient, returnedClient);
            Assert.Equal("http://localhost:5454/", httpClient.BaseAddress.ToString());
        }

        [Fact]
        public void ConfigureAllowsSettingTimeoutOnHttpClient()
        {
            var httpClient = new HttpClient();
            var returnedClient = ShipEngineClient.ConfigureHttpClient(httpClient, "my-api-key", null, TimeSpan.FromMinutes(7));

            Assert.Same(httpClient, returnedClient);
            Assert.Equal(7, httpClient.Timeout.TotalMinutes);
        }

        [Fact]
        public void ConfigureSetsTheApiKeyHeader()
        {
            var httpClient = new HttpClient();
            var returnedClient = ShipEngineClient.ConfigureHttpClient(httpClient, "my-api-key", null);

            Assert.Same(httpClient, returnedClient);
            Assert.Equal("my-api-key", httpClient.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "Api-Key").Value.SingleOrDefault());
        }

        [Fact]
        public void ConfigureSetsTheSdkUserAgentHeader()
        {
            var httpClient = new HttpClient();
            var returnedClient = ShipEngineClient.ConfigureHttpClient(httpClient, "my-api-key", null);

            Assert.Same(httpClient, returnedClient);
            var userAgents = httpClient.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "User-Agent").Value;
            Assert.NotNull(userAgents);
            var sdkHeader = userAgents.FirstOrDefault(x => x.StartsWith("shipengine-dotnet/"));
            Assert.NotNull(sdkHeader);
        }

        [Fact]
        public async Task FailureStatusWithShipengineContentThrowsPopulatedShipEngineException()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;


            string requestId = "12345";
            string message = "Request body cannot be empty.";
            var responseBody = string.Format(
                @"
                  {{
                      ""request_id"": ""{0}"",
                      ""errors"": [
                        {{
                          ""error_source"": ""shipengine"",
                          ""error_type"": ""validation"",
                          ""error_code"": ""request_body_required"",
                          ""message"": ""{1}""
                        }}
                      ]
                  }}", requestId, message);


            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/something", System.Net.HttpStatusCode.BadRequest,
                responseBody);
            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Post, "/v1/something", "",
                    mockShipEngineFixture.HttpClient, config)
            );

            Assert.Equal(requestId, ex.RequestId);
            Assert.Equal(message, ex.Message);
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.RequestBodyRequired, ex.ErrorCode);
            Assert.NotNull(ex.ResponseMessage);
            Assert.Equal(400, (int)ex.ResponseMessage.StatusCode);
        }

        [Fact]
        public async Task FailureStatusWithoutShipEngineDetailsThrowsShipEngineExceptionWithOriginalResponse()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;

            var responseBody = @"{""description"": ""valid JSON, but not what you expect""}";
            var requestId = mockShipEngineFixture.StubRequest(HttpMethod.Get, "/v1/something", System.Net.HttpStatusCode.NotFound,
                responseBody);
            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Get, "/v1/something", null,
                    mockShipEngineFixture.HttpClient, config)
            );

            Assert.NotNull(ex.ResponseMessage);
            Assert.Equal(404, (int) ex.ResponseMessage.StatusCode);
            Assert.Equal(requestId, ex.RequestId);
        }

        [Fact]
        public async Task FailureStatusWithoutJsonContentThrowsShipEngineExceptionWithOriginalResponse()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;

            var responseBody = @"<h1>Bad Gateway</h1>";
            var requestId = mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/something", System.Net.HttpStatusCode.BadGateway,
                responseBody);
            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Post, "/v1/something", "",
                    mockShipEngineFixture.HttpClient, config)
            );

            Assert.NotNull(ex.ResponseMessage);
            Assert.Equal(502, (int) ex.ResponseMessage.StatusCode);
            Assert.Equal(requestId, ex.RequestId);
        }

        [Fact]
        public async Task SuccessResponseThatCannotBeParsedThrowsExceptionWithUnparsedResponse()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;

            var responseBody = @"Unexpected response - not JSON";
            var requestId = mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/something", System.Net.HttpStatusCode.OK,
                responseBody);
            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Post, "/v1/something", "",
                    mockShipEngineFixture.HttpClient, config)
            );
            mockShipEngineFixture.AssertRequest(HttpMethod.Post, "/v1/something");

            Assert.NotNull(ex.ResponseMessage);
            Assert.Equal(200, (int)ex.ResponseMessage.StatusCode);
            Assert.Equal(responseBody, await ex.ResponseMessage.Content.ReadAsStringAsync());
            Assert.Equal(requestId, ex.RequestId);
        }

        [Fact]
        public async Task SuccessResponseWithNullContentThrowsShipEngineExceptionWithUnparsedResponse()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;

            // this scenario is similar to unparseable JSON - except that it is valid JSON
            var responseBody = @"null";
            var requestId = mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/something", System.Net.HttpStatusCode.OK,
                responseBody);
            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Post, "/v1/something", "",
                    mockShipEngineFixture.HttpClient, config)
            );
            mockShipEngineFixture.AssertRequest(HttpMethod.Post, "/v1/something");

            Assert.NotNull(ex.ResponseMessage);
            Assert.Equal("Unexpected null response", ex.Message);
            Assert.Equal(200, (int)ex.ResponseMessage.StatusCode);
            Assert.Equal(responseBody, await ex.ResponseMessage.Content.ReadAsStringAsync());
            Assert.Equal(requestId, ex.RequestId);
        }
    }
}
namespace ShipEngineTest
{
    using ShipEngineSDK;
    using ShipEngineSDK.VoidLabelWithLabelId;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xunit;

    public class ShipEngineClientTests
    {
        [Fact]
        public async Task FailureWithShipengineResponseThrowsPopulatedShipEngineException()
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
        }

        [Fact]
        public async Task FailureWithoutShipengineResponseThrowsHttpException()
        {
            var config = new Config(apiKey: "test", timeout: TimeSpan.FromSeconds(0.5));
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            var shipengine = mockShipEngineFixture.ShipEngine;

            var responseBody = @"<h1>Bad Gateway</h1>";
            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/something", System.Net.HttpStatusCode.BadGateway,
                responseBody);
            var ex = await Assert.ThrowsAsync<HttpRequestException>(
                async () => await shipengine.SendHttpRequestAsync<Result>(HttpMethod.Post, "/v1/something", "",
                    mockShipEngineFixture.HttpClient, config)
            );

            Assert.Contains("502", ex.Message);
        }
    }
}
using Moq;
using ShipEngineSDK;
using ShipEngineSDK.VoidLabelWithLabelId;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class VoidLabelWithLabelIdTest
    {

        public TestUtils TestUtils;

        public VoidLabelWithLabelIdTest()
        {
            TestUtils = new TestUtils();
        }

        [Fact]
        public async Task ValidVoidLabelWithLabelIdTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Put, "/v1/labels/se-1234/void", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234");

            Assert.True(result.Approved);
            Assert.Equal("Request for refund submitted.  This label has been voided.", result.Message);
        }

        [Fact]
        public async Task LabelIdIsEscapedInRequestPath()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));
            var escapedPath = "/v1/labels/..%2F..%2Fv1%2Fshipments%2Fx%2Fcancel%3F/void";

            mockShipEngineFixture.StubRequest(HttpMethod.Put, escapedPath, System.Net.HttpStatusCode.OK, json);

            await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("../../v1/shipments/x/cancel?");

            mockShipEngineFixture.AssertRequest(HttpMethod.Put, escapedPath);

            var mockHandler = new Mock<ShipEngine>(config);
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<Result>(HttpMethod.Put, escapedPath.TrimStart('/'), null, It.IsAny<HttpClient>(), It.IsAny<Config>()))
                .Returns(Task.FromResult(JsonSerializer.Deserialize<Result>(json, TestUtils.JsonSerializerOptions)));

            await mockHandler.Object.VoidLabelWithLabelId("../../v1/shipments/x/cancel?", methodConfig: new Config(apiKey: "12345"));

            mockHandler.VerifyAll();
        }

        [Theory]
        [InlineData(".")]
        [InlineData("..")]
        public async Task DotSegmentLabelIdIsRejected(string labelId)
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockHandler = new Mock<ShipEngine>(config);

            var ex = await Assert.ThrowsAsync<ShipEngineException>(() => mockHandler.Object.VoidLabelWithLabelId(labelId, methodConfig: new Config(apiKey: "12345")));
            Assert.Equal(ErrorType.Validation, ex.ErrorType);

            mockHandler.Verify(x => x.SendHttpRequestAsync<Result>(It.IsAny<HttpMethod>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<HttpClient>(), It.IsAny<Config>()), Times.Never);
        }

        [Fact]
        public async Task ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            var voidLabelResult = JsonSerializer.Deserialize<Result>(json, TestUtils.JsonSerializerOptions);
            var request = new HttpRequestMessage(HttpMethod.Put, "v1/labels/se-1234/void");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<Result>
                (
                    It.IsAny<HttpMethod>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.Is<HttpClient>(client =>
                        client.Timeout == TimeSpan.FromSeconds(1) &&
                        client.DefaultRequestHeaders.ToString().Contains("12345")),
                    It.IsAny<Config>()
                ))
                .Returns(Task.FromResult(voidLabelResult));

            var customConfig = new Config(apiKey: "12345", timeout: TimeSpan.FromSeconds(1));

            await shipEngine.VoidLabelWithLabelId("se-1234", methodConfig: customConfig);

            mockHandler.VerifyAll();
        }

        [Fact]
        public async Task InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipEngine.VoidLabelWithLabelId("se-1234", methodConfig: new Config(apiKey: "12345", retries: -1))
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
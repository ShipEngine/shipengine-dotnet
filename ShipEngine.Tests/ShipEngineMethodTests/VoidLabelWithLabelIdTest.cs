using Moq;
using ShipEngineSDK;
using ShipEngineSDK.VoidLabelWithLabelId.Result;
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

        [Fact]
        public async void ValidVoidLabelWithLabelIdTest()
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
        public async void ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            var voidLabelResult = JsonSerializer.Deserialize<VoidLabelIdResult>(json);
            var request = new HttpRequestMessage(HttpMethod.Put, "v1/labels/se-1234/void");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<VoidLabelIdResult>
                (
                    It.IsAny<HttpRequestMessage>(),
                    It.Is<HttpClient>(client =>
                        client.Timeout == TimeSpan.FromSeconds(1) &&
                        client.DefaultRequestHeaders.ToString().Contains("12345"))
                ))
                .Returns(Task.FromResult(voidLabelResult));

            var customConfig = new Config(apiKey: "12345", timeout: TimeSpan.FromSeconds(1));

            await shipEngine.VoidLabelWithLabelId("se-1234", config: customConfig);

            mockHandler.VerifyAll();
        }
    }
}
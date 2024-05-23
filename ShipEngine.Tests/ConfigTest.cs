using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.VoidLabelWithLabelId;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class ConfigTest
    {
        public TestUtils TestUtils;

        public ConfigTest()
        {
            TestUtils = new TestUtils();
        }

        [Fact]
        public async Task ValidateDefaultTimeoutTest()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";
            var config = new Config(apiKeyString);

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            var voidLabelResult = JsonConvert.DeserializeObject<Result>(json, TestUtils.JsonSerializerSettings);
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/se-1234/void");


            // Verify that the client has a default timeout of 60 seconds when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<Result>
                (
                    It.IsAny<HttpMethod>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.Is<HttpClient>(client =>
                        client.Timeout == TimeSpan.FromSeconds(60) &&
                        client.DefaultRequestHeaders.ToString().Contains(apiKeyString)),
                    It.IsAny<Config>()

                ))
                .Returns(Task.FromResult(voidLabelResult));

            await shipEngine.VoidLabelWithLabelId("se-1234");

            mockHandler.VerifyAll();
        }

        [Fact]
        public async Task ValidateCustomTimeout()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            var voidLabelResult = JsonConvert.DeserializeObject<Result>(json, TestUtils.JsonSerializerSettings);
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/se-1234/void");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<Result>
                (
                    It.IsAny<HttpMethod>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.Is<HttpClient>(client =>
                        client.Timeout == TimeSpan.FromSeconds(1) &&
                        client.DefaultRequestHeaders.ToString().Contains(apiKeyString)),
                    It.IsAny<Config>()

                ))
                .Returns(Task.FromResult(voidLabelResult));

            await shipEngine.VoidLabelWithLabelId("se-1234");

            mockHandler.VerifyAll();
        }
    }
}
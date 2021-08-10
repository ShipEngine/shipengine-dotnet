using Xunit;
using ShipEngineSDK;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;

namespace ShipEngineTest
{
    public class ConfigTest
    {

        [Fact]
        public async void ValidateDefaultTimeoutTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");


            // var ShipEngine = new ShipEngine(config);
            // var result = await ShipEngine.ListCarriers();
            // Console.WriteLine(result);
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Put, "/v1/labels/se-1234/void", System.Net.HttpStatusCode.OK, json, 6000);

            var ex = await Assert.ThrowsAsync<TaskCanceledException>(async () => await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234"));

            Assert.Equal("The request was canceled due to the configured HttpClient.Timeout of 5 seconds elapsing.", ex.Message);
        }
    }
}

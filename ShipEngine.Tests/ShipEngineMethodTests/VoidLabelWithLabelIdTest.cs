using ShipEngineSDK;
using System.IO;
using System.Net.Http;
using Xunit;

namespace ShipEngineTest
{
    public class VoidLabelWithLabelIdTest
    {

        [Fact]
        public async void ValidVoidLabelWithLabelIdTest()
        {
            var config = new ShipEngineConfig("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Put, "/v1/labels/se-1234/void", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.VoidLabelWithLabelId("se-1234");

            Assert.Equal(true, result.Approved);
            Assert.Equal("Request for refund submitted.  This label has been voided.", result.Message);
        }
    }
}
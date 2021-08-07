using Xunit;
using ShipEngineSDK;
using System.Net.Http;
using System.IO;

namespace ShipEngineTest
{
    public class VoidLabelWithLabelIdTest
    {

        [Fact]
        public async void ValidVoidLabelWithLabelIdTest()
        {
            var mockHttpClientFixture = new MockHttpClientFixture();

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/VoidLabelWithLabelId200Response.json"));

            mockHttpClientFixture.StubRequest(HttpMethod.Put, "/v1/labels/se-1234/void", System.Net.HttpStatusCode.OK, json);

            var client = new ShipEngine("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", mockHttpClientFixture.HttpClient);

            var result = await client.VoidLabelWithLabelId("se-1234");

            Assert.Equal(true, result.Approved);
            Assert.Equal("Request for refund submitted.  This label has been voided.", result.Message);
        }
    }
}

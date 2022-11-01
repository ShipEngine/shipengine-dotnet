namespace ShipEngineTest
{
    using ShipEngineSDK;
    using ShipEngineTest;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design.Serialization;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    public class ManifestsTest
    {
        public TestUtils TestUtils;

        public ManifestsTest()
        {
            TestUtils = new TestUtils();
        }

        [Fact]
        public async Task TestDeserialization()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateManifest200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/manifests", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.CreateImplicitManifest(new ShipEngineSDK.Manifests.Params { CarrierId = "se-1234567", WarehouseId = "se-7654312", ShipDate = DateTime.Today });
        }
    }
}

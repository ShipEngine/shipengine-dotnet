using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.CreateWarehouse;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class CreateWarehouseTest
    {

        public TestUtils TestUtils;

        public Params Params;

        public CreateWarehouseTest()
        {

            Params = new Params()
            {
                IsDefault = true,
                Name = "Warehouse 1",
                OriginAddress = new ShipEngineSDK.Common.Address()
                {
                    Name = "John Doe",
                    AddressLine1 = "4009 Marathon Blvd",
                    CityLocality = "Austin",
                    StateProvince = "TX",
                    PostalCode = "78756",
                    CountryCode = Country.US,
                    Phone = "512-555-5555"
                },
                ReturnAddress = new ShipEngineSDK.Common.Address()
                {
                    Name = "John Doe",
                    AddressLine1 = "4009 Marathon Blvd",
                    CityLocality = "Austin",
                    StateProvince = "TX",
                    PostalCode = "78756",
                    CountryCode = Country.US,
                    Phone = "512-555-5555"
                },
            };

            TestUtils = new TestUtils();
        }

        [Fact]
        public async void ValidCreateWarehouse()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateWarehouse200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/warehouses", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.CreateWarehouse(Params, config);

            Assert.Equal("se-277331", result.WarehouseId);
            Assert.Equal("Example Corp. East Warehouse", result.Name);
            Assert.Equal("2021-08-27T16:29:56.8779097Z", result.CreatedAt);
        }

        [Fact]
        public async void InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await shipEngine.CreateLabelFromRate(Params, methodConfig: new Config(apiKey: "12345", retries: -1)));
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
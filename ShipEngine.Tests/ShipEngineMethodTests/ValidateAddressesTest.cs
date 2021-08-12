using ShipEngineSDK;
using ShipEngineSDK.ValidateAddresses.Params;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Xunit;

namespace ShipEngineTest
{
    public class ValidateAddressesTest
    {
        [Fact]
        public async void ValidAddressesTest()
        {

            var config = new ShipEngineConfig("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateAddresses200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.OK, json);

            var addressList = new List<Address>(){
            new Address() {
                AddressLine1 = "2 Toronto St",
                CityLocality = "Toronto",
                StateProvince = "ON",
                PostalCode = "M5C 2B5",
                CountryCode = "CA",
            }
        };

            var result = await mockShipEngineFixture.ShipEngine.ValidateAddresses(addressList);

            Assert.Equal("verified", result[0].Status);

            Assert.Null(result[0].MatchedAddress.Name);
            Assert.Null(result[0].MatchedAddress.Phone);
            Assert.Equal("", result[0].MatchedAddress.CompanyName);
            Assert.Equal("100-2 Toronto St", result[0].MatchedAddress.AddressLine1);
            Assert.Equal("", result[0].MatchedAddress.AddressLine2);
            Assert.Equal("", result[0].MatchedAddress.AddressLine3);
            Assert.Equal("ON", result[0].MatchedAddress.StateProvince);
            Assert.Equal("M5C 2B5", result[0].MatchedAddress.PostalCode);
            Assert.Equal("CA", result[0].MatchedAddress.CountryCode);
            Assert.Equal("unknown", result[0].MatchedAddress.AddressResidentialIndicator);

            Assert.Null(result[0].OriginalAddress.Name);
            Assert.Null(result[0].OriginalAddress.Phone);
            Assert.Null(result[0].OriginalAddress.CompanyName);
            Assert.Equal("2 Toronto St", result[0].OriginalAddress.AddressLine1);
            Assert.Null(result[0].OriginalAddress.AddressLine2);
            Assert.Null(result[0].OriginalAddress.AddressLine3);
            Assert.Equal("ON", result[0].OriginalAddress.StateProvince);
            Assert.Equal("M5C 2B5", result[0].OriginalAddress.PostalCode);
            Assert.Equal("CA", result[0].OriginalAddress.CountryCode);
            Assert.Equal("unknown", result[0].OriginalAddress.AddressResidentialIndicator);

            Assert.Equal("a1007", result[0].Messages[0].Code);
            Assert.Equal("verified_to_suite_level", result[0].Messages[0].DetailCode);
            Assert.Equal("This address has been verified down to the suite/PO box level (highest possible accuracy with the provided data)", result[0].Messages[0].Message);
            Assert.Equal("info", result[0].Messages[0].Type);
        }

        [Fact]
        public async void InValidAddressTest()
        {
            var config = new ShipEngineConfig("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/BadRequest400Response.json"));
            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.BadRequest, json);

            var addressList = new List<Address>(){
                new Address() {
                    AddressLine1 = "2 Toronto St",
                    CityLocality = "Toronto",
                    StateProvince = "ON",
                    PostalCode = "M5C 2B5",
                    CountryCode = "CA",
                }
            };

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.ValidateAddresses(addressList));

            Assert.Equal("22467317-a130-4927-95a6-76124b716e58", ex.RequestId);
            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.RequestBodyRequired, ex.ErrorCode);
            Assert.Equal("Request body cannot be empty.", ex.Message);
        }
    }
}
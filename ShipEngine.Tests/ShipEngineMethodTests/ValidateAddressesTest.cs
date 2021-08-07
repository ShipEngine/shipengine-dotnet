using Xunit;
using ShipEngineSDK;
using System.Collections.Generic;
using ShipEngineSDK.ValidateAddresses.Params;
using System.Net.Http;
using System.IO;

namespace ShipEngineTest
{
    public class ValidateAddressesTest
    {

        [Fact]
        public async void ValidAddressesTest()
        {
            var mockHttpClientFixture = new MockHttpClientFixture();

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateAddresses200Response.json"));

            mockHttpClientFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.OK, json);

            var addressList = new List<Address>(){
                new Address() {
                    AddressLine1 = "2 Toronto St",
                    CityLocality = "Toronto",
                    StateProvince = "ON",
                    PostalCode = "M5C 2B5",
                    CountryCode = "CA",
                }
            };

            var client = new ShipEngine("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", mockHttpClientFixture.HttpClient);

            var result = await client.ValidateAddresses(addressList);

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
            var mockHttpClientFixture = new MockHttpClientFixture();

            var json = "{  \"request_id\": \"22467317-a130-4927-95a6-76124b716e58\",  \"errors\": [    {      \"error_source\": \"shipengine\",      \"error_type\": \"validation\",      \"error_code\": \"request_body_required\",      \"message\": \"Request body cannot be empty.\"    }  ]}";
            mockHttpClientFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.BadRequest, json);

            var addressList = new List<Address>(){
                new Address() {
                    AddressLine1 = "2 Toronto St",
                    CityLocality = "Toronto",
                    StateProvince = "ON",
                    PostalCode = "M5C 2B5",
                    CountryCode = "CA",
                }
            };

            var client = new ShipEngine("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk", mockHttpClientFixture.HttpClient);


            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await client.ValidateAddresses(addressList));

            Assert.Equal("22467317-a130-4927-95a6-76124b716e58", ex.RequestId);
            Assert.Equal("shipengine", ex.Errors[0].ErrorSource);
            Assert.Equal("validation", ex.Errors[0].ErrorType);
            Assert.Equal("request_body_required", ex.Errors[0].ErrorCode);
            Assert.Equal("validation", ex.Errors[0].ErrorType);
        }
    }
}

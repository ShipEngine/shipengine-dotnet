using System;
using Xunit;
using ShipEngineSDK;
using System.Collections.Generic;
using ShipEngineSDK.ValidateAddresses.Params;
using System.Net.Http;

namespace ShipEngineTest
{
    public class AddressValidation
    {

        [Fact]
        public async void ValidAddressTest()
        {
            var mockHttpClientFixture = new MockHttpClientFixture();

            var json = "[\r\n  {\r\n    \"status\": \"verified\",\r\n    \"original_address\": {\r\n      \"name\": null,\r\n      \"phone\": null,\r\n      \"company_name\": null,\r\n      \"address_line1\": \"2 Toronto St\",\r\n      \"address_line2\": null,\r\n      \"address_line3\": null,\r\n      \"city_locality\": \"Toronto\",\r\n      \"state_province\": \"ON\",\r\n      \"postal_code\": \"M5C 2B5\",\r\n      \"country_code\": \"CA\",\r\n      \"address_residential_indicator\": \"unknown\"\r\n    },\r\n    \"matched_address\": {\r\n      \"name\": null,\r\n      \"phone\": null,\r\n      \"company_name\": \"\",\r\n      \"address_line1\": \"100-2 Toronto St\",\r\n      \"address_line2\": \"\",\r\n      \"address_line3\": \"\",\r\n      \"city_locality\": \"Toronto\",\r\n      \"state_province\": \"ON\",\r\n      \"postal_code\": \"M5C 2B5\",\r\n      \"country_code\": \"CA\",\r\n      \"address_residential_indicator\": \"unknown\"\r\n    },\r\n    \"messages\": [\r\n      {\r\n        \"code\": \"a1007\",\r\n        \"message\": \"This address has been verified down to the suite/PO box level (highest possible accuracy with the provided data)\",\r\n        \"type\": \"info\",\r\n        \"detail_code\": \"verified_to_suite_level\"\r\n      }\r\n    ]\r\n  }\r\n]";
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
            Console.Write(result);

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
    }
}

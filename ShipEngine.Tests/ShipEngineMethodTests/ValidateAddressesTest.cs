using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.ValidateAddresses.Params;
using ShipEngineSDK.ValidateAddresses.Result;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{

    public class ValidateAddressesTest
    {
        List<Address> AddressList;
        public TestUtils TestUtils;

        public ValidateAddressesTest()
        {
            AddressList = new List<Address>(){
                new Address() {
                    AddressLine1 = "2 Toronto St",
                    CityLocality = "Toronto",
                    StateProvince = "ON",
                    PostalCode = "M5C 2B5",
                    CountryCode = "CA",
                }
            };

            TestUtils = new TestUtils();
        }

        [Fact]
        public async void ValidAddressesTest()
        {

            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateAddresses200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.ValidateAddresses(AddressList);

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
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/BadRequest400Response.json"));
            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.BadRequest, json);

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.ValidateAddresses(AddressList));

            Assert.Equal("22467317-a130-4927-95a6-76124b716e58", ex.RequestId);
            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.RequestBodyRequired, ex.ErrorCode);
            Assert.Equal("Request body cannot be empty.", ex.Message);
        }

        [Fact]
        // Check that both API Key and timeout can be set at the method level
        public async void ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateAddresses200Response.json"));

            var listCarriersResult = JsonConvert.DeserializeObject<List<ValidateAddressResult>>(json, TestUtils.JsonSerializerSettings);
            var request = new HttpRequestMessage(HttpMethod.Post, "/v1/addresses/validate");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<List<ValidateAddressResult>>
                (
                    It.IsAny<HttpMethod>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.Is<HttpClient>(client =>
                        client.Timeout == TimeSpan.FromSeconds(1) &&
                        client.DefaultRequestHeaders.ToString().Contains("12345")),
                    It.IsAny<Config>()
                ))
                .Returns(Task.FromResult(listCarriersResult));

            var customConfig = new Config(apiKey: "12345", timeout: TimeSpan.FromSeconds(1));

            await shipEngine.ValidateAddresses(AddressList, methodConfig: customConfig);

            mockHandler.VerifyAll();
        }

        [Fact]
        public async void InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipEngine.ValidateAddresses(AddressList, methodConfig: new Config(apiKey: "12345", retries: -1))
            );
            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
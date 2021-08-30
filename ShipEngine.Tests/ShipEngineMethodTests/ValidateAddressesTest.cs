using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.ValidateAddresses;
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
        List<Address> ResidentialAddressList;
        public TestUtils TestUtils;

        public ValidateAddressesTest()
        {
            ResidentialAddressList = new List<Address>(){
                new Address() {
                    AddressLine1 = "3910 Bailey Lane",
                    CityLocality = "Austin",
                    StateProvince = "TX",
                    PostalCode = "78756",
                    CountryCode = Country.US,
                }
            };

            TestUtils = new TestUtils();
        }

        [Fact]
        public async void ValidResidentialAddressTest()
        {

            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateResidentialAddresses200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.ValidateAddresses(ResidentialAddressList);

            Assert.Equal(AddressValidationResult.Verified, result[0].Status);

            Assert.Equal("JOHN SMITH", result[0].NormalizedAddress.Name);
            Assert.Null(result[0].NormalizedAddress.Phone);
            Assert.Null(result[0].NormalizedAddress.CompanyName);
            Assert.Equal("3910 BAILEY LN", result[0].NormalizedAddress.AddressLine1);
            Assert.Null(result[0].NormalizedAddress.AddressLine2);
            Assert.Null(result[0].NormalizedAddress.AddressLine3);
            Assert.Equal("AUSTIN", result[0].NormalizedAddress.CityLocality);

            Assert.Equal("TX", result[0].NormalizedAddress.StateProvince);
            Assert.Equal("78756-3924", result[0].NormalizedAddress.PostalCode);
            Assert.Equal(Country.US, result[0].NormalizedAddress.CountryCode);
            Assert.Equal(AddressResidentialIndicator.Yes, result[0].NormalizedAddress.AddressResidentialIndicator);

            Assert.Equal("John Smith", result[0].OriginalAddress.Name);
            Assert.Null(result[0].OriginalAddress.Phone);
            Assert.Null(result[0].OriginalAddress.CompanyName);
            Assert.Equal("3910 Bailey Lane", result[0].OriginalAddress.AddressLine1);
            Assert.Null(result[0].OriginalAddress.AddressLine2);
            Assert.Null(result[0].OriginalAddress.AddressLine3);
            Assert.Equal("Austin", result[0].OriginalAddress.CityLocality);

            Assert.Equal("TX", result[0].OriginalAddress.StateProvince);
            Assert.Equal("78756", result[0].OriginalAddress.PostalCode);
            Assert.Equal(Country.US, result[0].OriginalAddress.CountryCode);
            Assert.Equal(AddressResidentialIndicator.Yes, result[0].OriginalAddress.AddressResidentialIndicator);

            Assert.Equal("a1007", result[0].Messages[0].Code);
            Assert.Equal(ValidationMessageDetailCode.VerifiedToSuiteLevel, result[0].Messages[0].DetailCode);
            Assert.Equal("This address has been verified down to the suite/PO box level (highest possible accuracy with the provided data)", result[0].Messages[0].Message);
            Assert.Equal(ValidationMessageType.Info, result[0].Messages[0].Type);
        }

        [Fact]
        public async void ValidateCommericalAddressTest()
        {

            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateCommercialAddresses200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.ValidateAddresses(ResidentialAddressList);

            Assert.Equal(AddressValidationResult.Verified, result[0].Status);

            Assert.Equal("JOHN SMITH", result[0].NormalizedAddress.Name);
            Assert.Null(result[0].NormalizedAddress.Phone);
            Assert.Equal("SHIPSTATION", result[0].NormalizedAddress.CompanyName);
            Assert.Equal("3800 N LAMAR BLVD STE 220", result[0].NormalizedAddress.AddressLine1);
            Assert.Null(result[0].NormalizedAddress.AddressLine2);
            Assert.Null(result[0].NormalizedAddress.AddressLine3);
            Assert.Equal("AUSTIN", result[0].NormalizedAddress.CityLocality);
            Assert.Equal("TX", result[0].NormalizedAddress.StateProvince);

            Assert.Equal("TX", result[0].NormalizedAddress.StateProvince);
            Assert.Equal("78756-0003", result[0].NormalizedAddress.PostalCode);
            Assert.Equal(Country.US, result[0].NormalizedAddress.CountryCode);
            Assert.Equal(AddressResidentialIndicator.No, result[0].NormalizedAddress.AddressResidentialIndicator);

            Assert.Equal("John Smith", result[0].OriginalAddress.Name);
            Assert.Null(result[0].OriginalAddress.Phone);
            Assert.Equal("ShipStation", result[0].OriginalAddress.CompanyName);
            Assert.Equal("3800 N Lamar Blvd", result[0].OriginalAddress.AddressLine1);
            Assert.Equal("#220", result[0].OriginalAddress.AddressLine2);
            Assert.Null(result[0].OriginalAddress.AddressLine3);
            Assert.Equal("Austin", result[0].OriginalAddress.CityLocality);

            Assert.Equal("TX", result[0].OriginalAddress.StateProvince);
            Assert.Equal("78756", result[0].OriginalAddress.PostalCode);
            Assert.Equal(Country.US, result[0].OriginalAddress.CountryCode);
            Assert.Equal(AddressResidentialIndicator.No, result[0].OriginalAddress.AddressResidentialIndicator);

            Assert.Empty(result[0].Messages);
        }

        [Fact]
        public async void InValidAddressTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/BadRequest400Response.json"));
            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/addresses/validate", System.Net.HttpStatusCode.BadRequest, json);

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await mockShipEngineFixture.ShipEngine.ValidateAddresses(ResidentialAddressList));

            Assert.Equal("22467317-a130-4927-95a6-76124b716e58", ex.RequestId);
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
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
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ValidateResidentialAddresses200Response.json"));

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

            await shipEngine.ValidateAddresses(ResidentialAddressList, methodConfig: customConfig);

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
                async () => await shipEngine.ValidateAddresses(ResidentialAddressList, methodConfig: new Config(apiKey: "12345", retries: -1))
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
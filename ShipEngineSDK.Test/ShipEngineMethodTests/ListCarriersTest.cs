using Moq;
using ShipEngineSDK;
using ShipEngineSDK.Enums;
using ShipEngineSDK.ListCarriers;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class ListCarriers
    {
        public TestUtils TestUtils;

        public ListCarriers()
        {
            TestUtils = new TestUtils();
        }

        [Fact]
        public async Task ValidListCarriersTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ListCarriers200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Get, "/v1/carriers", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.ListCarriers();

            Assert.Empty(result.Errors);
            Assert.Equal("38b4eb4c-474f-4c50-b500-4f765114965e", result.RequestId);

            Assert.NotEmpty(result.Carriers);
            var Carrier = result.Carriers[0];

            Assert.Equal("se-656171", Carrier.CarrierId);
            Assert.Equal("stamps_com", Carrier.CarrierCode);
            Assert.Equal("test_account_656171", Carrier.AccountNumber);
            Assert.True(Carrier.RequiresFundedAmount);
            Assert.Equal(7707.9000, Carrier.Balance);
            Assert.Equal("ShipEngine Test Account - Stamps.com", Carrier.Nickname);
            Assert.Equal("Stamps.com", Carrier.FriendlyName);
            Assert.False(Carrier.Primary);
            Assert.False(Carrier.HasMultiPackageSupportingServices);
            Assert.True(Carrier.SupportsLabelMessages);

            Assert.Equal("se-656171", Carrier.Services[0].CarrierId);
            Assert.Equal("stamps_com", Carrier.Services[0].CarrierCode);
            Assert.Equal("usps_first_class_mail", Carrier.Services[0].ServiceCode);
            Assert.Equal("USPS First Class Mail", Carrier.Services[0].Name);
            Assert.True(Carrier.Services[0].Domestic);
            Assert.False(Carrier.Services[0].International);
            Assert.False(Carrier.Services[0].IsMultiPackageSupported);

            Assert.Equal("se-656171", Carrier.Services[1].CarrierId);
            Assert.Equal("stamps_com", Carrier.Services[1].CarrierCode);
            Assert.Equal("usps_media_mail", Carrier.Services[1].ServiceCode);
            Assert.Equal("USPS Media Mail", Carrier.Services[1].Name);
            Assert.True(Carrier.Services[1].Domestic);
            Assert.False(Carrier.Services[1].International);
            Assert.False(Carrier.Services[1].IsMultiPackageSupported);

            Assert.Null(Carrier.Packages[0].PackageId);
            Assert.Equal("cubic", Carrier.Packages[0].PackageCode);
            Assert.Equal("Cubic", Carrier.Packages[0].Name);
            Assert.Equal("Cubic", Carrier.Packages[0].Description);

            Assert.Null(Carrier.Packages[1].PackageId);
            Assert.Equal("flat_rate_envelope", Carrier.Packages[1].PackageCode);
            Assert.Equal("Flat Rate Envelope", Carrier.Packages[1].Name);
            Assert.Equal("USPS flat rate envelope. A special cardboard envelope provided by the USPS that clearly indicates \"Flat Rate\".", Carrier.Packages[1].Description);

            Assert.Equal("non_machinable", Carrier.Options[0].Name);
            Assert.Equal("false", Carrier.Options[0].DefaultValue);
            Assert.Equal("", Carrier.Options[0].Description);

            Assert.Equal("bill_to_account", Carrier.Options[1].Name);
            Assert.Null(Carrier.Options[1].DefaultValue);
            Assert.Equal("Bill To Account", Carrier.Options[1].Description);
        }

        [Fact]
        // Check that both API Key and timeout can be set at the method level
        public async Task ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ListCarriers200Response.json"));

            var listCarriersResult = JsonSerializer.Deserialize<Result>(json, TestUtils.JsonSerializerOptions);
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<Result>
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

            await shipEngine.ListCarriers(methodConfig: customConfig);

            mockHandler.VerifyAll();
        }

        [Fact]
        public async Task InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(
                async () => await shipEngine.ListCarriers(methodConfig: new Config(apiKey: "12345", retries: -1))
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
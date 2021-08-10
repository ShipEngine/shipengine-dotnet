using ShipEngineSDK;
using System.IO;
using System.Net.Http;
using Xunit;

namespace ShipEngineTest
{
    public class ListCarriers
    {

        [Fact]
        public async void ValidListCarriersTest()
        {
            var config = new ShipEngineConfig("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
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
            Assert.Equal(true, Carrier.RequiresFundedAmount);
            Assert.Equal(7707.9000, Carrier.Balance);
            Assert.Equal("ShipEngine Test Account - Stamps.com", Carrier.Nickname);
            Assert.Equal("Stamps.com", Carrier.FriendlyName);
            Assert.Equal(false, Carrier.Primary);
            Assert.Equal(false, Carrier.HasMultiPackageSupportingServices);
            Assert.Equal(true, Carrier.SupportsLabelMessages);

            Assert.Equal("se-656171", Carrier.Services[0].CarrierId);
            Assert.Equal("stamps_com", Carrier.Services[0].CarrierCode);
            Assert.Equal("usps_first_class_mail", Carrier.Services[0].ServiceCode);
            Assert.Equal("USPS First Class Mail", Carrier.Services[0].Name);
            Assert.Equal(true, Carrier.Services[0].Domestic);
            Assert.Equal(false, Carrier.Services[0].International);
            Assert.Equal(false, Carrier.Services[0].IsMultiPackageSupported);

            Assert.Equal("se-656171", Carrier.Services[1].CarrierId);
            Assert.Equal("stamps_com", Carrier.Services[1].CarrierCode);
            Assert.Equal("usps_media_mail", Carrier.Services[1].ServiceCode);
            Assert.Equal("USPS Media Mail", Carrier.Services[1].Name);
            Assert.Equal(true, Carrier.Services[1].Domestic);
            Assert.Equal(false, Carrier.Services[1].International);
            Assert.Equal(false, Carrier.Services[1].IsMultiPackageSupported);

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
    }
}
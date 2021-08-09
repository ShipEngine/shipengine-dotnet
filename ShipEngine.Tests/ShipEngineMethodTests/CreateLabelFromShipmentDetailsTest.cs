using Xunit;
using ShipEngineSDK;
using System.Net.Http;
using System.IO;
using ShipEngineSDK.CreateLabelFromShipmentDetails.Params;
using System.Collections.Generic;

namespace ShipEngineTest
{
    public class CreateLabelFromShipmentDetailsTest
    {

        [Fact]
        public async void ValidCreateLabelFromShipmentDetailsTest()
        {
            var config = new ShipEngineConfig("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromShipmentDetails200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/labels", System.Net.HttpStatusCode.OK, json);

            var LabelParams = new LabelParams()
            {
                Shipment = new Shipment()
                {
                    ServiceCode = "usps_priority_mail",
                    ShipFrom = new Address()
                    {
                        Name = "John Doe",
                        AddressLine1 = "4009 Marathon Blvd",
                        CityLocality = "Austin",
                        StateProvince = "TX",
                        PostalCode = "78756",
                        CountryCode = "US",
                        Phone = "512-555-5555"
                    },
                    ShipTo = new Address()
                    {
                        Name = "Amanda Miller",
                        AddressLine1 = "525 S Winchester Blvd",
                        CityLocality = "San Jose",
                        StateProvince = "CA",
                        PostalCode = "95128",
                        CountryCode = "US",
                        Phone = "512-555-5555"
                    },
                    Packages = new List<Package>() {
                        new Package() {
                            Weight = new Weight() {
                                Value = 17,
                                Unit = "pound"
                            },
                            Dimensions = new Dimensions() {
                                Length = 36,
                                Width = 12,
                                Height = 24,
                                Unit = "inch",
                            }
                        }
                    }
                }
            };

            var result = await mockShipEngineFixture.ShipEngine.CreateLabelFromShipmentDetails(LabelParams);

            Assert.Equal("se-76278969", result.LabelId);
            Assert.Equal("completed", result.Status);
            Assert.Equal("se-146030558", result.ShipmentId);
            Assert.Equal("2021-08-09T00:00:00Z", result.ShipDate);
            Assert.Equal("2021-08-09T14:55:37.5393659Z", result.CreatedAt);
            Assert.Equal("2021-08-09T14:55:37.5393659Z", result.CreatedAt);

            Assert.Equal("usd", result.ShipmentCost.Currency);
            Assert.Equal(115.51, result.ShipmentCost.Amount);

            Assert.Equal(0.0, result.InsuranceCost.Amount);
            Assert.Equal("usd", result.InsuranceCost.Currency);

            Assert.Equal("9405511899560337048294", result.TrackingNumber);
            Assert.Equal(false, result.IsReturnLabel);
            Assert.Null(result.RmaNumber);
            Assert.Equal(false, result.IsInternational);

            Assert.Equal("", result.BatchId);
            Assert.Equal("se-656171", result.CarrierId);
            Assert.Equal("usps_priority_mail", result.ServiceCode);
            Assert.Equal("package", result.PackageCode);
            Assert.Equal(false, result.Voided);
            Assert.Null(result.VoidedAt);
            Assert.Equal("pdf", result.LabelFormat);
            Assert.Equal("label", result.DisplayScheme);
            Assert.Equal("4x6", result.LabelLayout);
            Assert.Equal(true, result.Trackable);
            Assert.Null(result.LabelImageId);
            Assert.Equal("stamps_com", result.CarrierCode);
            Assert.Equal("in_transit", result.TrackingStatus);

            Assert.Equal("https://api.shipengine.com/v1/downloads/10/9-VbKDnISUGt_z3zrjvPTw/label-76278969.pdf", result.LabelDownload.Pdf);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/9-VbKDnISUGt_z3zrjvPTw/label-76278969.png", result.LabelDownload.Png);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/9-VbKDnISUGt_z3zrjvPTw/label-76278969.zpl", result.LabelDownload.Zpl);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/9-VbKDnISUGt_z3zrjvPTw/label-76278969.pdf", result.LabelDownload.Href);

            Assert.Null(result.FormDownload);
            Assert.Null(result.InsuranceClaim);

            var package = result.Packages[0];
            Assert.Equal(80938203, package.PackageId);

            Assert.Equal("package", package.PackageCode);
            Assert.Equal(17.0, package.Weight.Value);
            Assert.Equal("pound", package.Weight.Unit);

            Assert.Equal("inch", package.Dimensions.Unit);
            Assert.Equal(36.0, package.Dimensions.Length);
            Assert.Equal(12.0, package.Dimensions.Width);
            Assert.Equal(24.0, package.Dimensions.Height);

            Assert.Equal("usd", package.InsuredValue.Currency);
            Assert.Equal(0.0, package.InsuredValue.Amount);

            Assert.Equal("9405511899560337048294", package.TrackingNumber);

            Assert.Null(package.LabelMessages.Reference1);
            Assert.Null(package.LabelMessages.Reference2);
            Assert.Null(package.LabelMessages.Reference3);

            Assert.Null(package.ExternalPackageId);
            Assert.Equal(1, package.Sequence);

            Assert.Equal("carrier_default", result.ChargeEvent);
        }
    }
}

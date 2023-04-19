using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.UpdateShipmentByID;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class UpdateShipmentByIDTest
    {
        public Params ShipmentParameters;
        public TestUtils TestUtils;

        public UpdateShipmentByIDTest()
        {
            TestUtils = new TestUtils();
            ShipmentParameters = new Params()
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
                        CountryCode = Country.US,
                        Phone = "512-555-5555"
                    },
                    ShipTo = new Address()
                    {
                        Name = "Amanda Miller",
                        AddressLine1 = "525 S Winchester Blvd",
                        CityLocality = "San Jose",
                        StateProvince = "CA",
                        PostalCode = "95128",
                        CountryCode = Country.US,
                        Phone = "512-555-5555"
                    },
                    Customs = new Customs()
                    {
                        NonDelivery = NonDelivery.ReturnToSender,
                        Contents = PackageContents.Merchandise,
                        CustomsItems = new List<CustomsItem>()
                        {
                            new CustomsItem()
                            {
                                Description = "Merchandise",
                                 CountryOfOrigin = Country.US,
                                 Quantity = 1,
                                 UnitOfMeasure = "each",
                                 Value = new MonetaryValue()
                                 {
                                     Amount = 100D,
                                     Currency = Currency.USD
                                 }
                            }
                        }
                    },
                    Packages = new List<ShipmentPackage>() {
                        new ShipmentPackage() {
                            Weight = new Weight() {
                                Value = 17,
                                Unit = WeightUnit.Pound
                            },
                            Dimensions = new Dimensions() {
                                Length = 36,
                                Width = 12,
                                Height = 24,
                                Unit = DimensionUnit.Inch,
                            }
                        }
                    },
                    ValidateAddress = ValidateAddress.ValidateAndClean
                },
            };
        }

        [Fact]
        public async void ValidUpdateShipmentByIDTest()
        {

            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/UpdateShipmentByID200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Put, "/v1/shipments/se-153814671", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.UpdateShipmentFromShipmentDetails(ShipmentParameters, "se-153814671");

            Assert.Equal("se-153814671", result.ShipmentId);
            Assert.Equal("se-423888", result.CarrierId);
            Assert.Equal("ups_ground", result.ServiceCode);
            Assert.Null(result.ExternalShipmentId);
            Assert.Equal("2021-08-27T00:00:00Z", result.ShipDate);
            Assert.Equal("2021-08-27T16:29:25.257Z", result.CreatedAt);
            Assert.Equal("2021-08-27T16:29:25.24Z", result.ModifiedAt);
            Assert.Equal(ShipmentStatus.Pending, result.ShipmentStatus);

            Assert.Equal("Amanda Miller", result.ShipTo.Name);
            Assert.Null(result.ShipTo.Phone);
            Assert.Null(result.ShipTo.CompanyName);
            Assert.Equal("525 S Winchester Blvd", result.ShipTo.AddressLine1);
            Assert.Null(result.ShipTo.AddressLine2);
            Assert.Null(result.ShipTo.AddressLine3);
            Assert.Equal("San Jose", result.ShipTo.CityLocality);
            Assert.Equal("CA", result.ShipTo.StateProvince);
            Assert.Equal("95128", result.ShipTo.PostalCode);
            Assert.Equal(Country.US, result.ShipTo.CountryCode);
            Assert.Equal(AddressResidentialIndicator.Unknown, result.ShipTo.AddressResidentialIndicator);

            Assert.Equal("John Doe", result.ShipFrom.Name);
            Assert.Equal("512-555-5555", result.ShipFrom.Phone);
            Assert.Empty(result.ShipFrom.CompanyName);
            Assert.Equal("4009 Marathon Blvd", result.ShipFrom.AddressLine1);
            Assert.Null(result.ShipFrom.AddressLine2);
            Assert.Null(result.ShipFrom.AddressLine3);
            Assert.Equal("Austin", result.ShipFrom.CityLocality);
            Assert.Equal("TX", result.ShipFrom.StateProvince);
            Assert.Equal(AddressResidentialIndicator.Unknown, result.ShipFrom.AddressResidentialIndicator);

            Assert.Null(result.WarehouseId);

            Assert.Equal("John Doe", result.ReturnTo.Name);
            Assert.Equal("512-555-5555", result.ReturnTo.Phone);
            Assert.Empty(result.ReturnTo.CompanyName);
            Assert.Equal("4009 Marathon Blvd", result.ReturnTo.AddressLine1);
            Assert.Null(result.ReturnTo.AddressLine2);
            Assert.Null(result.ReturnTo.AddressLine3);
            Assert.Equal("Austin", result.ReturnTo.CityLocality);
            Assert.Equal("TX", result.ReturnTo.StateProvince);
            Assert.Equal(AddressResidentialIndicator.Unknown, result.ReturnTo.AddressResidentialIndicator);

            Assert.Equal(DeliveryConfirmation.None, result.Confirmation);

            Assert.Equal(PackageContents.Merchandise, result.Customs.Contents);
            Assert.NotEmpty(result.Customs.CustomsItems);
            Assert.Equal(100D, result.Customs.CustomsItems.First().Value.Amount);
            Assert.Equal(NonDelivery.ReturnToSender, result.Customs.NonDelivery);

            Assert.Null(result.ExternalOrderId);
            Assert.Null(result.OrderSourceCode);

            Assert.Null(result.AdvancedOptions.BillToAccount);
            Assert.Null(result.AdvancedOptions.BillToCountryCode);
            Assert.Null(result.AdvancedOptions.BillToParty);
            Assert.Null(result.AdvancedOptions.BillToPostalCode);
            Assert.False(result.AdvancedOptions.ContainsAlcohol);
            Assert.False(result.AdvancedOptions.DeliveredDutyPaid);
            Assert.False(result.AdvancedOptions.NonMachinable);
            Assert.False(result.AdvancedOptions.SaturdayDelivery);
            Assert.False(result.AdvancedOptions.DryIce);
            Assert.Null(result.AdvancedOptions.DryIceWeight);
            Assert.Null(result.AdvancedOptions.FedexFreight);
            Assert.Null(result.AdvancedOptions.FreightClass);
            Assert.Null(result.AdvancedOptions.CustomField1);
            Assert.Null(result.AdvancedOptions.CustomField2);
            Assert.Null(result.AdvancedOptions.CustomField3);
            Assert.Null(result.AdvancedOptions.CollectOnDelivery);

            Assert.Equal(InsuranceProvider.None, result.InsuranceProvider);
            Assert.Empty(result.Tags);

            Assert.Equal("package", result.Packages[0].PackageCode);
            Assert.Equal(17.0, result.Packages[0].Weight.Value);
            Assert.Equal(WeightUnit.Pound, result.Packages[0].Weight.Unit);
            Assert.Equal(DimensionUnit.Inch, result.Packages[0].Dimensions.Unit);
            Assert.Equal(12, result.Packages[0].Dimensions.Width);
            Assert.Equal(36, result.Packages[0].Dimensions.Length);
            Assert.Equal(24, result.Packages[0].Dimensions.Height);

            Assert.Equal(Currency.USD, result.Packages[0].InsuredValue.Currency);
            Assert.Equal(0, result.Packages[0].InsuredValue.Amount);

            Assert.Null(result.Packages[0].LabelMessages.Reference1);
            Assert.Null(result.Packages[0].LabelMessages.Reference2);
            Assert.Null(result.Packages[0].LabelMessages.Reference3);

            Assert.Null(result.Packages[0].ExternalPackageId);

            Assert.Equal(17.0, result.TotalWeight.Value);
            Assert.Equal(WeightUnit.Pound, result.TotalWeight.Unit);
            Assert.Empty(result.Items);

        }
    }
}
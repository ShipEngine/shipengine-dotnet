using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using ShipEngineSDK;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.CreateLabelFromShipmentDetails;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class CreateLabelFromShipmentDetailsTest
    {

        Params LabelParams;

        public TestUtils TestUtils;

        public CreateLabelFromShipmentDetailsTest()
        {
            TestUtils = new TestUtils();

            LabelParams = new Params()
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
                    Confirmation = DeliveryConfirmation.DeliveryMailed,
                    Packages = new List<Package>() {
                        new Package() {
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
                    }
                },
                ValidateAddress = ValidateAddress.ValidateAndClean
            };
        }

        [Fact]
        public async void ValidCreateLabelFromShipmentDetailsTest()
        {
            var config = new Config("TEST_ycvJAgX6tLB1Awm9WGJmD8mpZ8wXiQ20WhqFowCk32s");

            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromShipmentDetails200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/labels", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.CreateLabelFromShipmentDetails(LabelParams);

            Assert.Equal("se-76278969", result.LabelId);
            Assert.Equal(LabelStatus.Completed, result.Status);
            Assert.Equal("se-146030558", result.ShipmentId);
            Assert.Equal("2021-08-09T00:00:00Z", result.ShipDate);
            Assert.Equal("2021-08-09T14:55:37.5393659Z", result.CreatedAt);

            Assert.Equal(Currency.USD, result.ShipmentCost.Currency);
            Assert.Equal(115.51, result.ShipmentCost.Amount);

            Assert.Equal(0.0, result.InsuranceCost.Amount);
            Assert.Equal(Currency.USD, result.InsuranceCost.Currency);

            Assert.Equal("9405511899560337048294", result.TrackingNumber);
            Assert.False(result.IsReturnLabel);
            Assert.Null(result.RmaNumber);
            Assert.False(result.IsInternational);

            Assert.Equal("", result.BatchId);
            Assert.Equal("se-656171", result.CarrierId);
            Assert.Equal("usps_priority_mail", result.ServiceCode);
            Assert.Equal("package", result.PackageCode);
            Assert.False(result.Voided);
            Assert.Null(result.VoidedAt);
            Assert.Equal(LabelFormat.PDF, result.LabelFormat);
            Assert.Equal(DisplayScheme.Label, result.DisplayScheme);
            Assert.Equal(LabelLayout.FourBySix, result.LabelLayout);
            Assert.True(result.Trackable);
            Assert.Null(result.LabelImageId);
            Assert.Equal("stamps_com", result.CarrierCode);
            Assert.Equal(TrackingStatus.InTransit, result.TrackingStatus);

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
            Assert.Equal(WeightUnit.Pound, package.Weight.Unit);

            Assert.Equal(DimensionUnit.Inch, package.Dimensions.Unit);
            Assert.Equal(36.0, package.Dimensions.Length);
            Assert.Equal(12.0, package.Dimensions.Width);
            Assert.Equal(24.0, package.Dimensions.Height);

            Assert.Equal(Currency.USD, package.InsuredValue.Currency);
            Assert.Equal(0.0, package.InsuredValue.Amount);

            Assert.Equal("9405511899560337048294", package.TrackingNumber);

            Assert.Null(package.LabelMessages.Reference1);
            Assert.Null(package.LabelMessages.Reference2);
            Assert.Null(package.LabelMessages.Reference3);

            Assert.Null(package.ExternalPackageId);
            Assert.Equal(1, package.Sequence);

            Assert.Equal(ChargeEvent.CarrierDefault, result.ChargeEvent);
        }

        [Fact]
        public void TestParamsSerialization()
        {
            string labelParamsString = JsonConvert.SerializeObject(LabelParams, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            });

            JObject parsedJson = JObject.Parse(labelParamsString);

            Assert.Equal("John Doe", parsedJson["shipment"]["ship_from"]["name"]);
            Assert.Equal("delivery_mailed", parsedJson["shipment"]["confirmation"]);
            Assert.Null(parsedJson["label_layout"]);
            Assert.Null(parsedJson["label_format"]);
        }


        [Fact]
        public async void ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromShipmentDetails200Response.json"));

            var voidLabelResult = JsonConvert.DeserializeObject<Result>(json);
            var request = new HttpRequestMessage(HttpMethod.Post, "v1/labels");

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
                .Returns(Task.FromResult(voidLabelResult));

            var customConfig = new Config(apiKey: "12345", timeout: TimeSpan.FromSeconds(1));

            await shipEngine.CreateLabelFromShipmentDetails(LabelParams, methodConfig: customConfig);

            mockHandler.VerifyAll();
        }

        [Fact]
        public async void InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await shipEngine.CreateLabelFromShipmentDetails(LabelParams, methodConfig: new Config(apiKey: "12345", retries: -1)));
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
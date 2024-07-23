using Moq;
using ShipEngineSDK;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.CreateLabelFromRate;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    using ShipEngineSDK.Model;

    public class CreateLabelFromRateTest
    {

        public TestUtils TestUtils;

        public Params Params;

        public CreateLabelFromRateTest()
        {

            Params = new Params()
            {
                RateId = "se-1234",
                ValidateAddress = ShipEngineSDK.Common.Enums.ValidateAddress.NoValidation,
                LabelLayout = ShipEngineSDK.Common.Enums.LabelLayout.Letter,
                LabelFormat = ShipEngineSDK.Common.Enums.LabelFormat.PDF,
                LabelDownloadType = ShipEngineSDK.CreateLabelFromRate.LabelDownloadType.Url
            };

            TestUtils = new TestUtils();
        }

        [Fact]
        public async Task ValidCreateLabelFromRateTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromRate200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Post, "/v1/labels/rates/se-1234", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.CreateLabelFromRate(Params);

            Assert.Equal("se-80255646", result.LabelId);
            Assert.Equal(ShipEngineSDK.CreateLabelFromRate.LabelStatus.Completed, result.Status);
            Assert.Equal("se-153814671", result.ShipmentId);
            Assert.Equal("2021-08-27T00:00:00Z", result.ShipDate);
            Assert.Equal("2021-08-27T16:29:56.8779097Z", result.CreatedAt);

            Assert.Equal(Currency.USD, result.ShipmentCost.Currency);
            Assert.Equal(93.21, result.ShipmentCost.Amount);

            Assert.Equal(0.0, result.InsuranceCost.Amount);
            Assert.Equal(Currency.USD, result.InsuranceCost.Currency);

            Assert.Equal("1Z63R0960332529481", result.TrackingNumber);
            Assert.False(result.IsReturnLabel);
            Assert.Null(result.RmaNumber);
            Assert.False(result.IsInternational);

            Assert.Equal("", result.BatchId);
            Assert.Equal("se-423888", result.CarrierId);
            Assert.Equal("ups_ground", result.ServiceCode);
            Assert.Equal("package", result.PackageCode);
            Assert.False(result.Voided);
            Assert.Null(result.VoidedAt);
            Assert.Equal(ShipEngineSDK.Common.Enums.LabelFormat.PDF, result.LabelFormat);
            Assert.Equal(ShipEngineSDK.Common.Enums.DisplayScheme.Label, result.DisplayScheme);
            Assert.Equal(ShipEngineSDK.Common.Enums.LabelLayout.FourBySix, result.LabelLayout);
            Assert.True(result.Trackable);
            Assert.Null(result.LabelImageId);
            Assert.Equal("ups", result.CarrierCode);
            Assert.Equal(ShipEngineSDK.CreateLabelFromRate.TrackingStatus.InTransit, result.TrackingStatus);

            Assert.Equal("https://api.shipengine.com/v1/downloads/10/xJi-OIh8UU-_RBVmfA6dDw/label-80255646.pdf", result.LabelDownload.Pdf);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/xJi-OIh8UU-_RBVmfA6dDw/label-80255646.png", result.LabelDownload.Png);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/xJi-OIh8UU-_RBVmfA6dDw/label-80255646.zpl", result.LabelDownload.Zpl);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/xJi-OIh8UU-_RBVmfA6dDw/label-80255646.pdf", result.LabelDownload.Href);

            Assert.Null(result.FormDownload);
            Assert.Null(result.InsuranceClaim);

            var package = result.Packages[0];
            Assert.Equal(85151459, package.PackageId);

            Assert.Equal("package", package.PackageCode);
            Assert.Equal(17.0, package.Weight.Value);
            Assert.Equal(ShipEngineSDK.Common.Enums.WeightUnit.Pound, package.Weight.Unit);

            Assert.Equal(ShipEngineSDK.Common.Enums.DimensionUnit.Inch, package.Dimensions.Unit);
            Assert.Equal(36.0, package.Dimensions.Length);
            Assert.Equal(12.0, package.Dimensions.Width);
            Assert.Equal(24.0, package.Dimensions.Height);

            Assert.Equal(Currency.USD, package.InsuredValue.Currency);
            Assert.Equal(0.0, package.InsuredValue.Amount);

            Assert.Equal("1Z63R0960332529481", package.TrackingNumber);

            Assert.Null(package.LabelMessages.Reference1);
            Assert.Null(package.LabelMessages.Reference2);
            Assert.Null(package.LabelMessages.Reference3);

            Assert.Null(package.ExternalPackageId);
            Assert.Equal(1, package.Sequence);

            Assert.Equal(ChargeEvent.CarrierDefault, result.ChargeEvent);
        }

        [Fact]
        public async Task ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromRate200Response.json"));

            var voidLabelResult = JsonSerializer.Deserialize<ShipEngineSDK.CreateLabelFromRate.Result>(json);
            var request = new HttpRequestMessage(HttpMethod.Post, "v1/labels/rates/se-1234");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<ShipEngineSDK.CreateLabelFromRate.Result>
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

            await shipEngine.CreateLabelFromRate(Params, methodConfig: customConfig);

            mockHandler.VerifyAll();
        }

        [Fact]
        public async Task InvalidRetriesInMethodCall()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString);
            var mockHandler = new Mock<ShipEngine>(config);
            var shipEngine = mockHandler.Object;

            var ex = await Assert.ThrowsAsync<ShipEngineException>(async () => await shipEngine.CreateLabelFromRate(Params, methodConfig: new Config(apiKey: "12345", retries: -1)));
            Assert.Equal(ShipEngineSDK.ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ShipEngineSDK.ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ShipEngineSDK.ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }


        [Fact]
        public void CanDeserializeLabelResponseWithGeneratedModel()
        {
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/CreateLabelFromRate200Response.json"));

            var response = JsonSerializer.Deserialize<CreateLabelResponseBody>(json);
            Assert.Equal("1Z63R0960332529481", response.TrackingNumber);
            var package = Assert.Single(response.Packages);
            Assert.Equal("https://api.shipengine.com/v1/downloads/10/2zzavkE0J0irTipDXRePHQ/labelpackage-85151459.pdf", package.LabelDownload.Pdf);
        }

    }
}
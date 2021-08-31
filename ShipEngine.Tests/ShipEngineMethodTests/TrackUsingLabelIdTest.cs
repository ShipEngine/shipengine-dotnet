using Moq;
using Newtonsoft.Json;
using ShipEngineSDK;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.TrackUsingLabelId;
using ShipEngineSDK.TrackUsingLabelId.Result;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class TrackUsingLabelIdTest
    {
        public TestUtils TestUtils;

        public TrackUsingLabelIdTest()
        {
            TestUtils = new TestUtils();
        }

        [Fact]
        public async void ValidTrackUsingLabelIdTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/TrackUsingLabelId200Response.json"));

            mockShipEngineFixture.StubRequest(HttpMethod.Get, "/v1/labels/se-1234/track", System.Net.HttpStatusCode.OK, json);

            var result = await mockShipEngineFixture.ShipEngine.TrackUsingLabelId("se-1234");

            Assert.Equal("1026167028310292", result.TrackingNumber);
            Assert.Equal(TrackingStatusCode.UN, result.StatusCode);
            Assert.Null(result.CarrierDetailCode);
            Assert.Equal(TrackingStatusDescription.Unknown, result.StatusDescription);
            Assert.Equal("INDUCTION", result.CarrierStatusCode);
            Assert.Equal("Electronic information submitted by shipper", result.CarrierStatusDescription);
            Assert.Equal("2021-07-09T07:00:00Z", result.ShipDate);
            Assert.Equal("2021-07-19T07:00:00Z", result.EstimatedDeliveryDate);
            Assert.Null(result.ActualDeliveryDate);
            Assert.Null(result.ExceptionDescription);

            Assert.Equal("2021-07-10T02:58:01Z", result.Events[0].OccurredAt);
            Assert.Equal("2021-07-10T02:58:01Z", result.Events[0].CarrierOccurredAt);
            Assert.Equal("Electronic information submitted by shipper", result.Events[0].Description);
            Assert.Null(result.Events[0].CityLocality);
            Assert.Null(result.Events[0].StateProvince);
            Assert.Null(result.Events[0].PostalCode);
            Assert.Null(result.Events[0].CountryCode);
            Assert.Null(result.Events[0].CompanyName);
            Assert.Null(result.Events[0].Signer);
            Assert.Equal("3000", result.Events[0].EventCode);
            Assert.Null(result.Events[0].CarrierDetailCode);
            Assert.Equal("", result.Events[0].StatusCode);
            Assert.Equal("3000", result.Events[0].CarrierStatusCode);
            Assert.Null(result.Events[0].Latitude);
            Assert.Null(result.Events[0].Longitude);
        }

        [Fact]
        // Check that both API Key and timeout can be set at the method level
        public async void ValidateCustomSettingsAtMethodLevel()
        {
            var apiKeyString = "TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk";

            var config = new Config(apiKey: apiKeyString, timeout: TimeSpan.FromSeconds(1));

            var mockHandler = new Mock<ShipEngine>(config);

            var shipEngine = mockHandler.Object;
            string json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../HttpResponseMocks/ListCarriers200Response.json"));

            var listCarriersResult = JsonConvert.DeserializeObject<TrackingInfo>(json);
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            // Verify that the client has a custom timeout of 1 second when called.
            mockHandler
                .Setup(x => x.SendHttpRequestAsync<TrackingInfo>
                (
                    It.IsAny<HttpMethod>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.Is<HttpClient>(client =>
                        client.DefaultRequestHeaders.ToString().Contains("12345")),
                    It.IsAny<Config>()
                ))
                .Returns(Task.FromResult(listCarriersResult));

            var customConfig = new Config(apiKey: "12345", timeout: TimeSpan.FromSeconds(1));

            await shipEngine.TrackUsingLabelId("se-1234", methodConfig: customConfig);

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
                async () => await shipEngine.TrackUsingLabelId("se-1234", methodConfig: new Config(apiKey: "12345", retries: -1))
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
using Moq.Protected;
using ShipEngineSDK;
using ShipEngineSDK.TrackUsingCarrierCodeAndTrackingNumber;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ShipEngineTest
{
    public class TrackUsingCarrierCodeAndTrackingNumberTest
    {

        [Fact]
        public async void ValidTrackUsingCarrierCodeAndTrackingNumberTest()
        {
            var config = new Config("TEST_bTYAskEX6tD7vv6u/cZ/M4LaUSWBJ219+8S1jgFcnkk");
            var mockShipEngineFixture = new MockShipEngineFixture(config);

            string json = File.ReadAllText(
                Path.Combine(Directory.GetCurrentDirectory(),
                "../../../HttpResponseMocks/TrackUsingCarrierCodeAndTrackingNumber200Response.json")
            );

            var responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            responseMessage.Content = new StringContent(json);

            mockShipEngineFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == HttpMethod.Get &&
                        m.RequestUri.AbsolutePath.Contains("/v1/tracking")),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));

            var result = await mockShipEngineFixture.ShipEngine.TrackUsingCarrierCodeAndTrackingNumber("1026167028310292", "usps");

            Assert.Equal("1026167028310292", result.TrackingNumber);
            Assert.Equal(StatusCode.UN, result.StatusCode);
            Assert.Null(result.CarrierDetailCode);
            Assert.Equal(StatusDescription.Unknown, result.StatusDescription);
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
    }
}
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using ShipEngineSDK;

namespace ShipEngineSDK
{
    public class ShipEngine : ShipEngineClient
    {
        public ShipEngine(string apiKey) : base(apiKey) { }

        public ShipEngine(ShipEngineConfig config) : base(config) { }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses)
        {
            string addressesJsonString = JsonSerializer.Serialize(addresses);

            var request = new HttpRequestMessage(HttpMethod.Post, "v1/addresses/validate")
            {
                Content = new StringContent(addressesJsonString, System.Text.Encoding.UTF8, "application/json")
            };

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(request);

            return validatedAddresses;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            var carriers = await SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(request);

            return carriers;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/{LabelId}/void");

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(request);

            return VoidedLabelResponse;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/labels/{LabelId}/track");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(request);

            return TrackingInfo;
        }

        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string TrackingNumber, string CarrierCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/tracking?tracking_number={TrackingNumber}&carrier_code={CarrierCode}");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(request);

            return TrackingInfo;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams LabelDetails)
        {

            string LabelParamsString = JsonSerializer.Serialize(LabelDetails, new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var request = new HttpRequestMessage(HttpMethod.Post, "/v1/labels")
            {
                Content = new StringContent(LabelParamsString, System.Text.Encoding.UTF8, "application/json")
            };

            var LabelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(request);

            return LabelResult;
        }
    }
}
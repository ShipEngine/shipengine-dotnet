using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngine
    {

        public HttpClient _client;
        public ShipEngineConfig config;

        public ShipEngine(string apiKey)
        {

            var client = new HttpClient();
            config = new ShipEngineConfig(apiKey);
            _client = ShipEngineClient.ConfigureHttpClient(config, client);

        }

        public ShipEngine(ShipEngineConfig config)
        {
            var client = new HttpClient();
            this.config = config;
            _client = ShipEngineClient.ConfigureHttpClient(config, client);
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses)
        {
            string addressesJsonString = JsonSerializer.Serialize(addresses);

            var request = new HttpRequestMessage(HttpMethod.Post, "v1/addresses/validate")
            {
                Content = new StringContent(addressesJsonString, System.Text.Encoding.UTF8, "application/json")
            };

            var validatedAddresses = await ShipEngineClient.SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(request, _client);

            return validatedAddresses;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            var carriers = await ShipEngineClient.SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(request, _client);

            return carriers;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/{LabelId}/void");

            var VoidedLabelResponse = await ShipEngineClient.SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(request, _client);

            return VoidedLabelResponse;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/labels/{LabelId}/track");

            var TrackingInfo = await ShipEngineClient.SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(request, _client);

            return TrackingInfo;
        }

        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string TrackingNumber, string CarrierCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/tracking?tracking_number={TrackingNumber}&carrier_code={CarrierCode}");

            var TrackingInfo = await ShipEngineClient.SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(request, _client);

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

            var LabelResult = await ShipEngineClient.SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(request, _client);

            return LabelResult;
        }
    }
}






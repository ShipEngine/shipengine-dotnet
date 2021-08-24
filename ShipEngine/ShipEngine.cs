using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngine : ShipEngineClient
    {
        public HttpClient _client;
        public Config config;

        public ShipEngine(string apiKey) : base()
        {

            var client = new HttpClient();
            config = new Config(apiKey);
            _client = ConfigureHttpClient(config, client);
        }

        public ShipEngine(Config config) : base()
        {
            var client = new HttpClient();
            this.config = config;
            _client = ConfigureHttpClient(config, client);
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses)
        {

            string addressesJsonString = JsonConvert.SerializeObject(addresses, JsonSerializerSettings);

            var path = "v1/addresses/validate";

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(HttpMethod.Post, path, addressesJsonString, _client, config);

            return validatedAddresses;
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string addressesJsonString = JsonConvert.SerializeObject(addresses, JsonSerializerSettings);

            var path = "v1/addresses/validate";

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(HttpMethod.Post, path, addressesJsonString, client, methodConfig);

            client.Dispose();

            return validatedAddresses;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers()
        {
            var path = "v1/carriers";

            var carriers = await SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(HttpMethod.Get, path, null, _client, config);

            return carriers;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers(Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = "v1/carriers";

            var carriers = await SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return carriers;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string labelId)
        {
            var path = $"v1/labels/{labelId}/void";

            var voidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(HttpMethod.Put, path, null, _client, config);

            return voidedLabelResponse;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string labelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"v1/labels/{labelId}/void";

            var voidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(HttpMethod.Put, path, null, client, methodConfig);

            client.Dispose();

            return voidedLabelResponse;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string labelId)
        {
            var path = $"/v1/labels/{labelId}/track";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(HttpMethod.Get, path, null, _client, config);

            return trackingInfo;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string labelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/labels/{labelId}/track";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return trackingInfo;
        }

        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode)
        {
            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(HttpMethod.Get, path, null, _client, config);

            return trackingInfo;
        }


        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return trackingInfo;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams labelDetails)
        {

            string labelParamsString = JsonConvert.SerializeObject(labelDetails, JsonSerializerSettings);

            var path = "/v1/labels";

            var labelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(HttpMethod.Post, path, labelParamsString, _client, config);

            return labelResult;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams labelDetails, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string labelParamsString = JsonConvert.SerializeObject(labelDetails, JsonSerializerSettings);

            var path = "/v1/labels";

            var labelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(HttpMethod.Post, path, labelParamsString, client, methodConfig);

            client.Dispose();

            return labelResult;
        }
    }
}
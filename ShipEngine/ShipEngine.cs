using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngine : ShipEngineClient
    {
        public HttpClient _client;
        public Config config;

        public ShipEngine(string apiKey)
        {

            var client = new HttpClient();
            config = new Config(apiKey);
            _client = ConfigureHttpClient(config, client);
        }

        public ShipEngine(Config config)
        {
            var client = new HttpClient();
            this.config = config;
            _client = ConfigureHttpClient(config, client);
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses)
        {

            string addressesJsonString = JsonSerializer.Serialize(addresses);

            var path = "v1/addresses/validate";

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(HttpMethod.Post, path, addressesJsonString, _client, config);

            return validatedAddresses;
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string addressesJsonString = JsonSerializer.Serialize(addresses);

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

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId)
        {
            var path = $"v1/labels/{LabelId}/void";

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(HttpMethod.Put, path, null, _client, config);

            return VoidedLabelResponse;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"v1/labels/{LabelId}/void";

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(HttpMethod.Put, path, null, client, methodConfig);

            client.Dispose();

            return VoidedLabelResponse;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId)
        {
            var path = $"/v1/labels/{LabelId}/track";

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(HttpMethod.Get, path, null, _client, config);

            return TrackingInfo;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/labels/{LabelId}/track";

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return TrackingInfo;
        }

        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode)
        {
            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(HttpMethod.Get, path, null, _client, config);

            return TrackingInfo;
        }


        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return TrackingInfo;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams labelDetails)
        {

            string LabelParamsString = JsonSerializer.Serialize(labelDetails, new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var path = "/v1/labels";

            var LabelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(HttpMethod.Post, path, LabelParamsString, _client, config);

            return LabelResult;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams labelDetails, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string LabelParamsString = JsonSerializer.Serialize(labelDetails, new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var path = "/v1/labels";

            var LabelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(HttpMethod.Post, path, LabelParamsString, client, methodConfig);

            client.Dispose();

            return LabelResult;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngine
    {
        public HttpClient _client;
        public Config config;

        public ShipEngine(string apiKey)
        {

            var client = new HttpClient();
            config = new Config(apiKey);
            _client = ShipEngineClient.ConfigureHttpClient(config, client);
        }

        public ShipEngine(Config config)
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

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(request, _client);

            return validatedAddresses;
        }

        public async Task<List<ValidateAddresses.Result.ValidateAddressResult>> ValidateAddresses(List<ValidateAddresses.Params.Address> addresses, Config config)
        {

            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            string addressesJsonString = JsonSerializer.Serialize(addresses);

            var request = new HttpRequestMessage(HttpMethod.Post, "v1/addresses/validate")
            {
                Content = new StringContent(addressesJsonString, System.Text.Encoding.UTF8, "application/json")
            };

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result.ValidateAddressResult>>(request, client);

            client.Dispose();

            return validatedAddresses;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            var carriers = await SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(request, _client);

            return carriers;
        }

        public async Task<ListCarriers.Result.CarrierResponse> ListCarriers(Config config)
        {
            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            var carriers = await SendHttpRequestAsync<ListCarriers.Result.CarrierResponse>(request, client);

            return carriers;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/{LabelId}/void");

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(request, _client);

            return VoidedLabelResponse;
        }

        public async Task<VoidLabelWithLabelId.Result.VoidLabelIdResult> VoidLabelWithLabelId(string LabelId, Config config)
        {
            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/{LabelId}/void");

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result.VoidLabelIdResult>(request, client);

            return VoidedLabelResponse;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/labels/{LabelId}/track");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(request, _client);

            return TrackingInfo;
        }

        public async Task<TrackUsingLabelId.Result.TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId, Config config)
        {
            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/labels/{LabelId}/track");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result.TrackUsingLabelIdResult>(request, client);

            return TrackingInfo;
        }

        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string TrackingNumber, string CarrierCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/tracking?tracking_number={TrackingNumber}&carrier_code={CarrierCode}");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(request, _client);

            return TrackingInfo;
        }


        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult> TrackUsingCarrierCodeAndTrackingNumber(string TrackingNumber, string CarrierCode, Config config)
        {
            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/tracking?tracking_number={TrackingNumber}&carrier_code={CarrierCode}");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result.TrackUsingCarrierCodeAndTrackingNumberResult>(request, client);

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

            var LabelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(request, _client);

            return LabelResult;
        }

        public async Task<CreateLabelFromShipmentDetails.Result.LabelResult> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params.LabelParams LabelDetails, Config config)
        {

            var client = ShipEngineClient.ConfigureHttpClient(config, new HttpClient());

            string LabelParamsString = JsonSerializer.Serialize(LabelDetails, new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var request = new HttpRequestMessage(HttpMethod.Post, "/v1/labels")
            {
                Content = new StringContent(LabelParamsString, System.Text.Encoding.UTF8, "application/json")
            };

            var LabelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result.LabelResult>(request, client);

            return LabelResult;
        }

        public virtual async Task<T> SendHttpRequestAsync<T>(HttpRequestMessage request, HttpClient client)
        {
            try
            {
                var streamTask = client.SendAsync(request);
                var response = await streamTask;

                var deserializedResult = await ShipEngineClient.DeserializedResultOrThrow<T>(response);

                return deserializedResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
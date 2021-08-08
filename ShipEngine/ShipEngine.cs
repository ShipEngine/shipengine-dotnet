using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using ShipEngineSDK.ValidateAddresses.Params;
using ShipEngineSDK.ValidateAddresses.Result;
using ShipEngineSDK.ListCarriers.Result;
using ShipEngineSDK.VoidLabelWithLabelId.Result;
using ShipEngineSDK.TrackUsingLabelId.Result;

namespace ShipEngineSDK
{
    public class ShipEngine : ShipEngineClient
    {
        public ShipEngine(string apiKey, HttpClient httpClient = null) : base(apiKey, httpClient) { }


        public async Task<List<ValidateAddressResult>> ValidateAddresses(List<Address> addresses)
        {
            string addressesJsonString = JsonSerializer.Serialize(addresses);

            var request = new HttpRequestMessage(HttpMethod.Post, "v1/addresses/validate")
            {
                Content = new StringContent(addressesJsonString, System.Text.Encoding.UTF8, "application/json")
            };

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddressResult>>(request);

            return validatedAddresses;
        }

        public async Task<CarrierResponse> ListCarriers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "v1/carriers");

            var carriers = await SendHttpRequestAsync<CarrierResponse>(request);

            return carriers;
        }

        public async Task<VoidLabelIdResult> VoidLabelWithLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"v1/labels/{LabelId}/void");

            var VoidedLabelResponse = await SendHttpRequestAsync<VoidLabelIdResult>(request);

            return VoidedLabelResponse;
        }

        public async Task<TrackUsingLabelIdResult> TrackUsingLabelId(string LabelId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/labels/{LabelId}/track");

            var TrackingInfo = await SendHttpRequestAsync<TrackUsingLabelIdResult>(request);

            return TrackingInfo;
        }
    }
}
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using ShipEngineSDK.ValidateAddresses.Params;
using ShipEngineSDK.ValidateAddresses.Result;

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
    }
}
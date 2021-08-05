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

            var validatedAddresses = await PostHttpRequest<List<ValidateAddressResult>>("v1/addresses/validate", addressesJsonString);

            return validatedAddresses;
        }
    }
}
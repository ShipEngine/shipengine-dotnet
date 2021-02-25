using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Anemonis.JsonRpc.ServiceClient;
using Newtonsoft.Json;

namespace ShipEngine
{


    sealed public class ShipEngineClient
    {
        private ShipEngineConfig Config;
        private JsonRpcClient Client;

        public ShipEngineClient(ShipEngineConfig config)
        {
            Config = config;

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Api-Key", Config.ApiKey);

            // var Foo = new JsonRpcClientFactory.Create<IRandomOrgService>;
            Client = new JsonRpcClient(Config.BaseUri, httpClient);
        }

        public Task<Results> exec<Parameters, Results>(string method, Parameters parameters) where Parameters : class
        {
            var id = System.Guid.NewGuid().ToString();

            // hacky way to convert from a class to a dictionary with keys reflected in DTO attributes
            var serialized = JsonConvert.SerializeObject(parameters);
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(serialized);

            return this.Client.InvokeAsync<Results>(method, id, values);
        }
    }
}
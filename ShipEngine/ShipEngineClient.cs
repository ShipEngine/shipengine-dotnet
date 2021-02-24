using System.Net.Http;
using System.Threading.Tasks;
using Anemonis.JsonRpc.ServiceClient;
using System.Collections.Generic;


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

            Client = new JsonRpcClient(Config.BaseUri, httpClient);
        }

        public Task<Results> exec<Parameters, Results>(string method, Dictionary<string, object> parameters)
        {
            var id = System.Guid.NewGuid().ToString();
            return this.Client.InvokeAsync<Results>(method, id, parameters);
        }
    }
}
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Anemonis.JsonRpc.ServiceClient;


namespace ShipEngine
{
    sealed public class ShipEngineClient
    {
        private ShipEngineConfig Config;
        private readonly JsonRpcClient Client = new JsonRpcClient("http://localhost:8888");

        public ShipEngineClient(ShipEngineConfig config)
        {
            // Config = config;

            // Client.BaseAddress = Config.BaseUri;

            // Client.DefaultRequestHeaders.Add("Api-Key", Config.ApiKey);
            // Client.DefaultRequestHeaders.Add("Accept", "application/json");
            // Client.DefaultRequestHeaders.Add("User-Agent", Config.UserAgent);

        }

        private HttpRequestMessage CloneRequest(HttpRequestMessage message)
        {
            var request = new HttpRequestMessage(message.Method, message.RequestUri);
            request.Content = message.Content;
            return request;
        }
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {

        }
    }
}

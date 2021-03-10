using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShipEngine.Models.Exceptions;
using ShipEngine.Models.JsonRpc;
using System.Collections.Generic;
namespace ShipEngine
{
    sealed public class ShipEngineClient
    {
        private ShipEngineConfig Config;
        private HttpClient Client;

        public ShipEngineClient(ShipEngineConfig config)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client = client;
            Config = config;
        }

        private async Task<JsonRpcResponse<T>?> DeserializeJsonRpcResponse<T>(HttpResponseMessage message)
        {
            string messageStr = await message.Content.ReadAsStringAsync();

            var serializerSettings = new JsonSerializerSettings { Error = (se, ev) => { ev.ErrorContext.Handled = true; } };
            return JsonConvert.DeserializeObject<JsonRpcResponse<T>>(messageStr, serializerSettings);
        }

        private HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Config.BaseUri);
            var jsonRpcRequest = new JsonRpcRequest<Parameters>(jsonRpcMethod, parameters);
            string serializedRequest = JsonConvert.SerializeObject(jsonRpcRequest);
            request.Content = new StringContent(serializedRequest, Encoding.UTF8, "application/json");
            return request;
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {
            var request = new HttpRequestMessage(message.Method, message.RequestUri);
            request.Content = message.Content;
            return Client.SendAsync(request);
        }

        public async Task<Results> exec<Parameters, Results>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var httpResponseMessage = await this.SendAsync(CreateJsonRpcMessage<Parameters>(jsonRpcMethod, parameters));
            httpResponseMessage.EnsureSuccessStatusCode();

            var rpcResponse = await this.DeserializeJsonRpcResponse<Results>(httpResponseMessage);
            if (rpcResponse == null)
            {
                throw new ShipEngineException("Invalid response; content empty");
            }
            else if (rpcResponse.Error != null)
            {
                // On a fatal user OR server error -- for example, the server was unable to handle the results
                throw new ShipEngineException(rpcResponse.Error.Message ?? "Unknown RPC error", rpcResponse.Error.Code, rpcResponse.Error.Data);
            }
            else if (rpcResponse.Result == null) // JSON RPC contract violation: Result/Error are mutually exclusive.
            {
                throw new ShipEngineException("Invalid response; result missing");
            }
            else
            {
                return rpcResponse.Result;
            }
        }

        public async Task<List<Results>> exec<Parameters, Results>(string jsonRpcMethod, List<Parameters> parameters) where Parameters : class
        {
            var result = await this.exec<List<Parameters>, List<Results>>(jsonRpcMethod, parameters);
            return result;
        }
    }
}
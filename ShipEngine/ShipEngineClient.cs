using Newtonsoft.Json;
using ShipEngine.Models.Exceptions;
using ShipEngine.Models.JsonRpc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShipEngine
{

    sealed public class ShipEngineClient
    {
        private readonly ShipEngineConfig Config;
        private readonly HttpClient Client;

        private readonly JsonSerializerSettings serializerSettings = new()
        {
            Error = (se, ev) => { ev.ErrorContext.Handled = true; }
        };

        public ShipEngineClient(ShipEngineConfig config)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client = client;
            Config = config;
        }

        private async Task<T> DeserializeHttpContent<T>(HttpResponseMessage message)
        {
            string msgContent = await message.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(msgContent, serializerSettings);
            if (result == null)
            {
                throw new ShipEngineException("Invalid response, Content empty after deserialization");
            }
            return result;
        }

        private HttpRequestMessage CreateConfiguredRequestMessage(string content)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Config.BaseUri)
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };
            return request;
        }

        private HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var jsonRpcRequest = new JsonRpcRequest<Parameters>(jsonRpcMethod, parameters);
            string serializedRequest = JsonConvert.SerializeObject(jsonRpcRequest);
            return CreateConfiguredRequestMessage(serializedRequest);
        }

        public HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, List<Parameters> parameters) where Parameters : class
        {
            var jsonRpcRequests = parameters.Select(p => new JsonRpcRequest<Parameters>(jsonRpcMethod, p)).ToList();
            string serializedRequest = JsonConvert.SerializeObject(jsonRpcRequests);
            return CreateConfiguredRequestMessage(serializedRequest);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {
            var request = new HttpRequestMessage(message.Method, message.RequestUri)
            {
                Content = message.Content
            };
            return Client.SendAsync(request);
        }

        private async Task<HttpResponseMessage> SendAsyncRpc<Parameters>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var httpResponseMessage = await SendAsync(CreateJsonRpcMessage(jsonRpcMethod, parameters));
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }

        public async Task<JsonRpcResponse<Result>> Exec<Parameters, Result>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var httpResponseMessage = await SendAsyncRpc(jsonRpcMethod, parameters);
            var rpcResponse = await DeserializeHttpContent<JsonRpcResponse<Result>>(httpResponseMessage);

            return rpcResponse;
        }

        public async Task<List<JsonRpcResponse<Result>>> Exec<Parameters, Result>(string jsonRpcMethod, List<Parameters> parameters) where Parameters : class
        {
            var httpResponseMessage = await SendAsyncRpc(jsonRpcMethod, parameters);

            // Only reason this overload is neccessary is because we want List<JsonRpcResponse<Foo>> rather than JsonRpcResponse<List<Foo>>
            var rpcResponse = await DeserializeHttpContent<List<JsonRpcResponse<Result>>>(httpResponseMessage);
            return rpcResponse;
        }
    }
}
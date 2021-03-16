using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngine.Models;
using ShipEngine.Models.Exceptions;
using ShipEngine.Models.JsonRpc;
using ShipEngine.Models.Package.Dto;
using System.Collections.Generic;
using System.Globalization;
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
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Error = (serializer, err) => err.ErrorContext.Handled = true,
            Converters =
            {
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },

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
            var deserializedObject = JsonConvert.DeserializeObject<T>(msgContent, serializerSettings);
            if (deserializedObject == null)
            {
                throw new ShipEngineException("Content is null after deserialization.");
            };
            return deserializedObject;
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

        private HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, IEnumerable<Parameters> parameters) where Parameters : class
        {
            var jsonRpcRequests = parameters.Select(p => new JsonRpcRequest<Parameters>(jsonRpcMethod, p));
            string serializedRequest = JsonConvert.SerializeObject(jsonRpcRequests);
            return CreateConfiguredRequestMessage(serializedRequest);
        }

        private Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {
            var request = new HttpRequestMessage(message.Method, message.RequestUri)
            {
                Content = message.Content
            };
            return Client.SendAsync(request);
        }

        public async Task<JsonRpcResponse<Result>> Exec<Parameters, Result>(string jsonRpcMethod, Parameters parameters) where Parameters : class where Result : IResult
        {
            var httpResponseMessage = await SendAsync(CreateJsonRpcMessage(jsonRpcMethod, parameters));
            httpResponseMessage.EnsureSuccessStatusCode();
            var rpcResponse = await DeserializeHttpContent<JsonRpcResponse<Result>>(httpResponseMessage);
            return rpcResponse;
        }

        public async Task<IEnumerable<JsonRpcResponse<Result>>> Exec<Parameters, Result>(string jsonRpcMethod, IEnumerable<Parameters> parameters) where Parameters : class where Result : IResult
        {
            var httpResponseMessage = await SendAsync(CreateJsonRpcMessage(jsonRpcMethod, parameters));
            httpResponseMessage.EnsureSuccessStatusCode();

            // Only reason this overload is neccessary is because we want IEnumerable<JsonRpcResponse<Foo>> rather than JsonRpcResponse<IEnumerable<Foo>>
            var rpcResponse = await DeserializeHttpContent<IEnumerable<JsonRpcResponse<Result>>>(httpResponseMessage);
            return rpcResponse;
        }

    }
}
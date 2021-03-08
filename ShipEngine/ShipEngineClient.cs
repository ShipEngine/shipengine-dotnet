using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ShipEngine
{
    namespace ShipEngineExceptions
    {
        [Serializable]
        public class ShipEngineException : Exception
        {
            public int Code
            {
                get;
            }

            public readonly Dictionary<string, object>? Details;

            public ShipEngineException(string message) : base(message)
            {
            }

            public ShipEngineException(string message, int errorCode, Dictionary<string, object>? data) : base(message)
            {
                Code = errorCode;
                Details = data;
            }

        }
    }

    abstract class BaseResponse
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpcVersion
        {
            get; set;
        }

        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }
    }

    class JsonRpcResponse<Data> : BaseResponse
    {
        public JsonRpcResponse() : base() { }

        [JsonProperty("result")]
        public Data? Result;

        [JsonProperty("error")]
        public JsonRpcResponseErrorData? Error;

        JsonRpcResponse(Data result)
        {
            this.Result = result;
        }

    }

    class JsonRpcResponseErrorData
    {
        [JsonProperty("code")]
        public int Code
        {
            get; set;
        }

        [JsonProperty("message")]
        public string? Message
        {
            get; set;
        }

        [JsonProperty("data")]
        public Dictionary<string, object>? Data
        {
            get; set;
        }
    }

    class JsonRpcRequest<Parameters>
    {
        [JsonProperty("jsonrpc")]
        public readonly string JsonRpcVersion = "2.0";

        [JsonProperty("id")]
        public readonly string Id = new Guid().ToString();

        [JsonProperty("method")]
        public string Method
        {
            get; set;
        }

        [JsonProperty("params")]
        public Parameters Params
        {
            get; set;
        }

        public JsonRpcRequest(string method, Parameters parameters)
        {
            Method = method;
            Params = parameters;
        }
    }
}



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

        public HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, Parameters parameters) where Parameters : class
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
            HttpRequestMessage message = CreateJsonRpcMessage<Parameters>(jsonRpcMethod, parameters);
            var httpResponseMessage = await this.SendAsync(message);
            httpResponseMessage.EnsureSuccessStatusCode();
            var rpcResponse = JsonConvert.DeserializeObject<JsonRpcResponse<Results>>(
                await httpResponseMessage.Content.ReadAsStringAsync(),
                new JsonSerializerSettings { Error = (se, ev) => { ev.ErrorContext.Handled = true; } }
            );

            if (rpcResponse == null)
            {
                throw new ShipEngineExceptions.ShipEngineException("Invalid response; content empty");
            }
            else if (rpcResponse.Error != null)
            {
                // On a fatal user OR server error -- for example, the server was unable to handle the results
                throw new ShipEngineExceptions.ShipEngineException(rpcResponse.Error.Message ?? "Unknown RPC error", rpcResponse.Error.Code, rpcResponse.Error.Data);
            }
            else if (rpcResponse.Result == null) // JSON RPC contract violation: Result/Error are mutually exclusive.
            {
                throw new ShipEngineExceptions.ShipEngineException("Invalid response; result missing");
            }
            else
            {
                return rpcResponse.Result;
            }
        }
    }
}
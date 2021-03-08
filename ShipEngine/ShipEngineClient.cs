using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Anemonis.JsonRpc.ServiceClient;
using Newtonsoft.Json;

namespace JsonRpc
{
    abstract class BaseResponse
    {
        [JsonProperty("jsonrpc")]
        public readonly string JsonRpcVersion = "2.0";

        [JsonProperty("id")]
        public readonly string Id = System.Guid.NewGuid().ToString();
    }

    class JsonRpcResponseSuccess<Data> : BaseResponse
    {

        [JsonProperty("result")]
        public Data Result;

        JsonRpcResponseSuccess(Data result)
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
    class JsonRpcResponseError : BaseResponse
    {

        [JsonProperty("error")]
        JsonRpcResponseError error = default!;
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
            Config = config;

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Api-Key", Config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", Config.UserAgent);
            Client = client;
        }

        public HttpRequestMessage CreateJsonRpcMessage<Parameters>(string jsonRpcMethod, Parameters parameters) where Parameters : class
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Config.BaseUri);
            var id = System.Guid.NewGuid().ToString();

            var serialized = JsonConvert.SerializeObject(parameters);
            request.Content = new StringContent(serialized, Encoding.UTF8, "application/json");


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
            Results results = JsonConvert.DeserializeObject<Results>(await httpResponseMessage.Content.ReadAsStringAsync());
            return results;

        }
    }
}
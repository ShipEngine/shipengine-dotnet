using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace ShipEngine.Models.JsonRpc
{
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

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShipEngine.Models.JsonRpc
{

    public class JsonRpcResponse<ResultData> : IResponse<ResultData> where ResultData : IResult
    {
        [JsonProperty("id")]
        public string Id
        {
            get; set;
        }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultData? Result
        {
            get; set;
        }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public JsonRpcResponseErrorData? Error
        {
            get; set;
        }


    }

    public class JsonRpcResponseErrorData
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

    public class JsonRpcRequest<Parameters>
    {
        [JsonProperty("jsonrpc")]
        public readonly string JsonRpcVersion = "2.0";


        [JsonProperty("id")]
        public readonly string Id = new Utils.RequestId().Id;


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
using Newtonsoft.Json;
using ShipEngine.Models.Exceptions;
using System;
using System.Collections.Generic;
namespace ShipEngine.Models.JsonRpc
{

    public abstract class BaseResponse
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

    public class JsonRpcResponse<Data> : BaseResponse
    {
        public JsonRpcResponse() : base() { }

        [JsonProperty("result")]
        public Data? Result;


        [JsonProperty("error")]
        public JsonRpcResponseErrorData? Error;

        public Data UnwrapResultOrThrow()
        {
            {
                if (Error != null)
                {
                    // On a fatal user OR server error -- for example, the server was unable to handle the results
                    throw new ShipEngineException(Error.Message ?? "Unknown RPC error", Error.Code, Error.Data);
                }
                else if (Result == null) // JSON RPC contract violation: Result/Error are mutually exclusive.
                {
                    throw new ShipEngineException("Invalid response; result missing");
                }
                else
                {
                    return Result;
                }
            }
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
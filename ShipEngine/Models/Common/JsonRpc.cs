using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ShipEngine.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShipEngine.Models.JsonRpc
{

    public class JsonRpcResponse<ResultData>
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
        public JsonRpcResponseErrorData? Error;

        public ResultData UnwrapResultOrThrow()
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
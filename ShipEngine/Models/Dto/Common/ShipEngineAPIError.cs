using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ShipEngineSDK.Common
{
    public class ShipEngineAPIError
    {
        public string RequestId { get; set; }

        public List<Error> Errors { get; set; }

    }

    public class Error
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ErrorSource ErrorSource { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ErrorType ErrorType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ErrorCode ErrorCode { get; set; }

        public string Message { get; set; }
    }
}
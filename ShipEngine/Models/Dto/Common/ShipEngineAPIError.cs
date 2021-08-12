using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    public class ShipEngineAPIError
    {
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }

    }

    public class Error
    {
        [JsonPropertyName("error_source")]
        public string? ErrorSource { get; set; }

        [JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        [JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
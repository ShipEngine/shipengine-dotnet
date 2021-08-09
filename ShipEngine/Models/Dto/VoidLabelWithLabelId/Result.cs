using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace ShipEngineSDK.VoidLabelWithLabelId.Result
{
    public class VoidLabelIdResult
    {
        [JsonPropertyName("approved")]
        public bool? Approved { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
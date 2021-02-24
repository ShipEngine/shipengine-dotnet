using System.Text.Json.Serialization;

namespace ShipEngine.Dtos
{
    public class CreateTagParams
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class CreateTagResult
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
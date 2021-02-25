using Newtonsoft.Json;

namespace ShipEngine.Models
{
    public class CreateTagParamsDto
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class CreateTagResultDto
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}





using Newtonsoft.Json;
namespace ShipEngine.Models
{
    public class CreateTagParams
    {
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }

    public class CreateTagResult
    {
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }

}




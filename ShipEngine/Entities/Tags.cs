using System.Text.Json.Serialization;

namespace ShipEngine.Entities
{
  public class Tag
  {
    [JsonPropertyName("name")]
    public string Name {get; set;}
  }
}
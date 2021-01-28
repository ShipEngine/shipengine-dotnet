using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using ShipEngine.Entities;

namespace ShipEngine.Services
{
  
  public class TagsService : AbstractService
  {
    public TagsService(ShipEngineClient client) : base(client)
    {
    }

    public async Task<Tag?> Create(string tag)
    {
      var request = new HttpRequestMessage(HttpMethod.Post, $"/v1/tags/{tag}");
      var response = await this.Client.SendAsync(request);

      response.EnsureSuccessStatusCode();

      var content = await response.Content.ReadAsStringAsync();
      
      return JsonSerializer.Deserialize<Tag>(content);
    }
  }
}
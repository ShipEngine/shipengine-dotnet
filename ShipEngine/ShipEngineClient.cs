using System.Net.Http;
using System.Threading.Tasks;

namespace ShipEngine
{
  sealed public class ShipEngineClient
  {
    public readonly HttpClient Client = new HttpClient();
    public ShipEngineClient(ShipEngineConfig config) {
      this.Client.BaseAddress = config.BaseUri;

      this.Client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
      this.Client.DefaultRequestHeaders.Add("Accept", "application/json");
      this.Client.DefaultRequestHeaders.Add("User-Agent", config.UserAgent);
    }

    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
    {
      return this.Client.SendAsync(message);
    }
  }
}
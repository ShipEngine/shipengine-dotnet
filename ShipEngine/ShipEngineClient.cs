using System.Net.Http;
using System.Threading.Tasks;

namespace ShipEngine
{
  sealed public class ShipEngineClient
  {
    private ShipEngineConfig Config;
    private readonly HttpClient Client = new HttpClient();

    public ShipEngineClient(ShipEngineConfig config) {
      Config = config;

      Client.BaseAddress = Config.BaseUri;

      Client.DefaultRequestHeaders.Add("Api-Key", Config.ApiKey);
      Client.DefaultRequestHeaders.Add("Accept", "application/json");
      Client.DefaultRequestHeaders.Add("User-Agent", Config.UserAgent);
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
    {
      int tries = 0;

      while (tries <= Config.Retries) {
        tries++;

        HttpResponseMessage response = await Client.SendAsync(message).ConfigureAwait(false);

        if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests) {
          await Task.Delay(1000).ConfigureAwait(false);
          continue;
        }

        return response;
      }

      return await Client.SendAsync(message);
    }
  }
}
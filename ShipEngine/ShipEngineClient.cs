using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Polly;
using Polly.Retry;

namespace ShipEngine
{
  sealed public class ShipEngineClient
  {
    private ShipEngineConfig Config;
    private readonly HttpClient Client = new HttpClient();
    private readonly AsyncRetryPolicy<HttpResponseMessage> Policy;

    public ShipEngineClient(ShipEngineConfig config)
    {
      Config = config;

      Client.BaseAddress = Config.BaseUri;

      Client.DefaultRequestHeaders.Add("Api-Key", Config.ApiKey);
      Client.DefaultRequestHeaders.Add("Accept", "application/json");
      Client.DefaultRequestHeaders.Add("User-Agent", Config.UserAgent);

      Policy = Polly.Policy.HandleResult<HttpResponseMessage>(r => r.StatusCode == HttpStatusCode.TooManyRequests)
      .WaitAndRetryAsync(Config.Retries, _ => TimeSpan.FromSeconds(1));
    }

    private HttpRequestMessage CloneRequest(HttpRequestMessage message)
    {
      var request = new HttpRequestMessage(message.Method, message.RequestUri);
      request.Content = message.Content;
      return request;
    }
    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
    {
      return await Policy.ExecuteAsync(() => Client.SendAsync(CloneRequest(message)));
    }
  }
}
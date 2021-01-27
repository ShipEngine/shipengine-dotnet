using System;

namespace ShipEngine
{
  sealed public class ShipEngineConfig
  {
    public readonly string ApiKey;
    public readonly Uri URI;
    public readonly string UserAgent;
    
    public ShipEngineConfig(string apiKey, string userAgent)
    {
      this.ApiKey = apiKey;
      this.URI = new Uri("http://localhost:8500");
      this.UserAgent = userAgent;
    }
  }
}
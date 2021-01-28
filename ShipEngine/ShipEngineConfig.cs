using System;

namespace ShipEngine
{
  sealed public class ShipEngineConfig
  {
    public readonly string ApiKey;
    public Uri BaseUri { get; set; }
    public int PageSize { get; set; }
    public int Retries { get; set; }
    public string? UserAgent { get; set; }

    public ShipEngineConfig(string apiKey)
    {
      this.ApiKey = apiKey;
      this.BaseUri = ShipEngineConfigValidator.DefaultBaseUri;
      this.PageSize = ShipEngineConfigValidator.DefaultPageSize;
      this.Retries = ShipEngineConfigValidator.DefaultRetries;
    }
  }
}
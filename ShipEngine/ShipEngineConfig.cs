using System;

namespace ShipEngine
{
    sealed public class ShipEngineConfig
    {
        public readonly string ApiKey;
        public Uri BaseUri { get; set; }
        public int PageSize { get; set; }
        public string? UserAgent { get; set; }

        public ShipEngineConfig(string apiKey)
        {
            ApiKey = apiKey;
            BaseUri = ShipEngineConfigValidator.DefaultBaseUri;
            PageSize = ShipEngineConfigValidator.DefaultPageSize;
        }
    }
}
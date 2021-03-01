using System;

namespace ShipEngine
{
    sealed public class ShipEngineConfig
    {
        public readonly string ApiKey;
        public Uri BaseUri { get; set; }

        public ShipEngineConfig(string apiKey)
        {
            ApiKey = apiKey;
            BaseUri = ShipEngineConfigValidator.DefaultBaseUri;
        }
    }
}
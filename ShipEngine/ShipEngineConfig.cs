using System;

namespace ShipEngineSDK
{
    sealed public class ShipEngineConfig
    {
        public readonly string ApiKey;
        public readonly TimeSpan Timeout;

        public ShipEngineConfig(string apiKey, TimeSpan? timeout = null)
        {
            ApiKey = apiKey ?? throw new ArgumentException(message: $"Missing API Key:", paramName: nameof(ApiKey));
            Timeout = timeout ?? TimeSpan.FromSeconds(5);
        }
    }
}



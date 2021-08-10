using System;

namespace ShipEngineSDK
{
    sealed public class Config
    {
        public readonly string ApiKey;
        public readonly TimeSpan Timeout;

        public Config(string apiKey, TimeSpan? timeout = null)
        {
            ApiKey = apiKey ?? throw new ArgumentException(message: $"Missing API Key:", paramName: nameof(ApiKey));
            Timeout = timeout ?? TimeSpan.FromSeconds(5);
        }
    }
}
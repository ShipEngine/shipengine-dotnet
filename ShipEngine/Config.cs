using System;

namespace ShipEngineSDK
{
    sealed public class Config
    {
        public readonly string ApiKey;
        public readonly TimeSpan Timeout;

        public Config(string apiKey, TimeSpan? timeout = null)
        {
            if (apiKey == null || apiKey == "")
            {
                var message = "A ShipEngine API key must be specified";
                throw new ShipEngineException(message, ErrorSource.ShipEngine, ErrorType.Validation, ErrorCode.FieldValueRequired);
            }
            ApiKey = apiKey;
            Timeout = timeout ?? TimeSpan.FromSeconds(5);
        }
    }
}
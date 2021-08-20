using System;

namespace ShipEngineSDK
{
    sealed public class Config
    {
        public readonly string ApiKey;
        public readonly TimeSpan Timeout;
        public readonly int Retries;

        public Config(string apiKey, TimeSpan? timeout = null, int retries = 1)
        {
            if (apiKey == null || apiKey == "")
            {
                var message = "A ShipEngine API key must be specified.";
                throw new ShipEngineException(message, ErrorSource.ShipEngine, ErrorType.Validation, ErrorCode.FieldValueRequired);
            }
            ApiKey = apiKey;


            if (timeout <= TimeSpan.Zero)
            {
                var message = "Timeout must be greater than zero.";
                throw new ShipEngineException(message, ErrorSource.ShipEngine, ErrorType.Validation, ErrorCode.InvalidFieldValue);
            }

            Timeout = timeout ?? TimeSpan.FromSeconds(5);

            if (retries < 0)
            {
                var message = "Retries must be greater than zero.";
                throw new ShipEngineException(message, ErrorSource.ShipEngine, ErrorType.Validation, ErrorCode.InvalidFieldValue);
            }

            Retries = retries;
        }
    }
}
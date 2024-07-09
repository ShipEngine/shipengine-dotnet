using System;
using ShipEngineSDK.Enums;

namespace ShipEngineSDK
{
    /// <summary>
    /// Sets the various configuration options for the ShipEngine SDK.
    /// </summary>
    public class Config
    {
        /// <summary>
        ///  Your ShipEngine API key.
        /// </summary>
        public readonly string ApiKey;

        /// <summary>
        /// The timespan to wait before the request times out.
        /// Defaults to 60 seconds.
        /// </summary>
        public readonly TimeSpan Timeout;

        /// <summary>
        /// The number of retries to attempt after a failed request.
        /// Defaults to 1.
        /// </summary>
        public readonly int Retries;

        /// <summary>
        /// Configure the global settings for the ShipEngine SDK.
        /// </summary>
        /// <param name="apiKey">The api key associated with the account you wish to use.</param>
        /// <param name="timeout">The timespan to wait before the request times out. Defaults to 60 seconds</param>
        /// <param name="retries">The number of retries to attempt after a failed request. Defaults to 1</param>
        public Config(string apiKey, TimeSpan? timeout = null, int retries = 1)
        {
            if (apiKey == null || apiKey == "")
            {
                var message = "A ShipEngine API key must be specified.";
                throw new ShipEngineException(message, ErrorSource.Shipengine, ErrorType.Validation, ErrorCode.FieldValueRequired);
            }

            ApiKey = apiKey;


            if (timeout <= TimeSpan.Zero)
            {
                var message = "Timeout must be greater than zero.";
                throw new ShipEngineException(message, ErrorSource.Shipengine, ErrorType.Validation, ErrorCode.InvalidFieldValue);
            }

            Timeout = timeout ?? TimeSpan.FromSeconds(60);

            if (retries < 0)
            {
                var message = "Retries must be greater than zero.";
                throw new ShipEngineException(message, ErrorSource.Shipengine, ErrorType.Validation, ErrorCode.InvalidFieldValue);
            }

            Retries = retries;
        }
    }
}
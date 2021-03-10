using System;
using System.Runtime.InteropServices;

namespace ShipEngine
{
    sealed public class ShipEngineConfig
    {
        public readonly string ApiKey;
        public readonly Uri BaseUri;


        // since BaseUri will be only be modified for testing purposes, we only expose it here, rather than directly in the `ShipEngine` constructor.
        public ShipEngineConfig(string apiKey, string baseUri = "http://localhost:8500")
        {
            ApiKey = apiKey;
            var uri = new System.Uri(baseUri);
            if (uri == null)
            {
                throw new ArgumentException(message: $"Could not construct URI with {baseUri}", paramName: nameof(baseUri));
            };
            BaseUri = uri;
        }
    }
}
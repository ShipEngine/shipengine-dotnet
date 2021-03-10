using System;
using Newtonsoft.Json;

namespace ShipEngine.Converters
{
    /// <summary>
    /// Serialization methods for various datatypes before making requests to the API
    /// </summary>
    public class Serializers
    {

        public static string DateTimeIso8601(DateTime? input)
        {
            if (input == null) return null;

            return input.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

    }
};
#pragma warning disable 1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    public class MonetaryValue
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency? Currency { get; set; }

        public double? Amount { get; set; }
    }
}
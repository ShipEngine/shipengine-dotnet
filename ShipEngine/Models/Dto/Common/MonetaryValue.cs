#pragma warning disable 1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using ShipEngineSDK.Common.Enums;
using System;
using System.Linq;

namespace ShipEngineSDK.Common
{
    public class MonetaryValue
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency? Currency { get; set; }

        public double? Amount { get; set; }
    }

    public class MonetaryValueConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MonetaryValue);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.ValueType == typeof(double))
            {
                return new MonetaryValue() { Amount = (double)reader.Value };
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
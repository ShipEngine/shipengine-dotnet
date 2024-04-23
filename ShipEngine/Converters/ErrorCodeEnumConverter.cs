using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ShipEngineSDK.Converters
{
    public class ErrorCodeEnumConverter : StringEnumConverter
    {
        public ErrorCode DefaultValue { get; set; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                return DefaultValue;
            }
        }
    }
}
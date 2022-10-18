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

    public class MonetaryValueConverter : JsonConverter<MonetaryValue>
    {
        public override bool CanWrite => false;

        public override MonetaryValue ReadJson(JsonReader reader, Type objectType, MonetaryValue existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var response = new MonetaryValue();
                while (reader.TokenType != JsonToken.EndObject)
                {
                    reader.Read();
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        switch (reader.Value)
                        {
                            case "amount":
                                response.Amount = reader.ReadAsDouble();
                                break;
                            case "currency":
                                if (Enum.TryParse(reader.ReadAsString(), true, out Currency currency))
                                {
                                    response.Currency = currency;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                return response;
            }
            if (reader.TokenType == JsonToken.Float)
            {
                return new MonetaryValue() { Amount = (double)reader.Value };
            }
            return new MonetaryValue();
        }

        public override void WriteJson(JsonWriter writer, MonetaryValue value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
#pragma warning disable 1591

using ShipEngineSDK.Common.Enums;
using System;
using System.Buffers;
using System.Buffers.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{

    public class MonetaryValue
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Currency? Currency { get; set; }

        public double? Amount { get; set; }
    }

    public class MonetaryValueConverter : JsonConverter<MonetaryValue>
    {
        public override MonetaryValue Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var response = new MonetaryValue();
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    reader.Read();
                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        switch (reader.GetString())
                        {
                            case "amount":
                                response.Amount = reader.GetDouble();
                                break;
                            case "currency":
                                if (Enum.TryParse(reader.GetString(), true, out Currency currency))
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
            if (reader.TokenType == JsonTokenType.Number)
            {
                var amount = reader.GetDouble();
                return new MonetaryValue() { Amount = reader.GetDouble() };
            }
            return new MonetaryValue();
        }

        public override void Write(Utf8JsonWriter writer, MonetaryValue value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Amount.ToString());
        }
    }
}
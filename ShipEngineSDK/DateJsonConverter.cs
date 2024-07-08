namespace ShipEngineSDK;

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DateJsonConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        DateTime.ParseExact(reader.GetString()!, Format, CultureInfo.InvariantCulture);

    public override void Write(Utf8JsonWriter writer, DateTime dateTimeValue, JsonSerializerOptions options) =>
        writer.WriteStringValue(dateTimeValue.ToString(Format, CultureInfo.InvariantCulture));
}
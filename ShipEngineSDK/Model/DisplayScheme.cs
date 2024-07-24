// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The display format that the label should be shown in.
/// </summary>
/// <value>The display format that the label should be shown in.</value>
[JsonConverter(typeof(DisplaySchemeJsonConverter))]
public class DisplayScheme
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of DisplayScheme with a predefined value.
    /// </summary>
    internal DisplayScheme()
    {
        _value = "label";
    }

    /// <summary>
    /// Create a new instance of DisplayScheme with a custom value.
    /// </summary>
    /// <param name="value">The value of the DisplayScheme</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public DisplayScheme(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Label for value: label
    /// </summary>
    public static DisplayScheme Label { get; } = new("label");


    /// <summary>
    /// Enum QrCode for value: qr_code
    /// </summary>
    public static DisplayScheme QrCode { get; } = new("qr_code");


    /// <summary>
    /// Enum LabelAndQrCode for value: label_and_qr_code
    /// </summary>
    public static DisplayScheme LabelAndQrCode { get; } = new("label_and_qr_code");


    /// <summary>
    /// Enum Paperless for value: paperless
    /// </summary>
    public static DisplayScheme Paperless { get; } = new("paperless");


    /// <summary>
    /// Enum LabelAndPaperless for value: label_and_paperless
    /// </summary>
    public static DisplayScheme LabelAndPaperless { get; } = new("label_and_paperless");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is DisplayScheme other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class DisplaySchemeJsonConverter : JsonConverter<DisplayScheme>
{
    public override DisplayScheme? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new DisplayScheme(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, DisplayScheme value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(DisplayScheme);
}
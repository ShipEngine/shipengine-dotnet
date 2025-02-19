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
/// The available layouts (sizes) in which shipping labels can be downloaded.  The label format determines which sizes are supported.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format. 
/// </summary>
/// <value>The available layouts (sizes) in which shipping labels can be downloaded.  The label format determines which sizes are supported.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format. </value>
[JsonConverter(typeof(LabelLayoutJsonConverter))]
public class LabelLayout
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of LabelLayout with a predefined value.
    /// </summary>
    internal LabelLayout()
    {
        _value = "4x6";
    }

    /// <summary>
    /// Create a new instance of LabelLayout with a custom value.
    /// </summary>
    /// <param name="value">The value of the LabelLayout</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public LabelLayout(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum _4x6 for value: 4x6
    /// </summary>
    public static LabelLayout _4x6 { get; } = new("4x6");


    /// <summary>
    /// Enum Letter for value: letter
    /// </summary>
    public static LabelLayout Letter { get; } = new("letter");


    /// <summary>
    /// Enum A4 for value: A4
    /// </summary>
    public static LabelLayout A4 { get; } = new("A4");


    /// <summary>
    /// Enum A6 for value: A6
    /// </summary>
    public static LabelLayout A6 { get; } = new("A6");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is LabelLayout other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class LabelLayoutJsonConverter : JsonConverter<LabelLayout>
{
    public override LabelLayout? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new LabelLayout(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, LabelLayout value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(LabelLayout);
}
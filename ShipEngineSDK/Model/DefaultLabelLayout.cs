/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
/// The possible default label layout values
/// </summary>
/// <value>The possible default label layout values</value>
[JsonConverter(typeof(DefaultLabelLayoutJsonConverter))]
public class DefaultLabelLayout
{
    private string _value;

    internal DefaultLabelLayout()
    {
        _value = "4x6";
    }

    /// <summary>
    /// Create a new instance of DefaultLabelLayout with a custom value.
    /// </summary>
    /// <param name="value">The value of the DefaultLabelLayout</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public DefaultLabelLayout(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum _4x6 for value: 4x6
    /// </summary>
    public static DefaultLabelLayout _4x6 { get; } = new("4x6");


    /// <summary>
    /// Enum Letter for value: Letter
    /// </summary>
    public static DefaultLabelLayout Letter { get; } = new("Letter");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class DefaultLabelLayoutJsonConverter : JsonConverter<DefaultLabelLayout>
{
    public override DefaultLabelLayout? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new DefaultLabelLayout(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, DefaultLabelLayout value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(DefaultLabelLayout);
}
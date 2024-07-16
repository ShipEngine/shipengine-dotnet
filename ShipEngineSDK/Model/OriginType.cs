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
/// Indicates if the package will be picked up or dropped off by the carrier
/// </summary>
/// <value>Indicates if the package will be picked up or dropped off by the carrier</value>
[JsonConverter(typeof(OriginTypeJsonConverter))]
public class OriginType
{
    private string _value;

    internal OriginType()
    {
        _value = "pickup";
    }

    /// <summary>
    /// Create a new instance of OriginType with a custom value.
    /// </summary>
    /// <param name="value">The value of the OriginType</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public OriginType(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Pickup for value: pickup
    /// </summary>
    public static OriginType Pickup { get; } = new("pickup");


    /// <summary>
    /// Enum DropOff for value: drop_off
    /// </summary>
    public static OriginType DropOff { get; } = new("drop_off");


    public override string ToString() => _value;
}

internal class OriginTypeJsonConverter : JsonConverter<OriginType>
{
    public override OriginType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new OriginType(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, OriginType value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(OriginType);
}
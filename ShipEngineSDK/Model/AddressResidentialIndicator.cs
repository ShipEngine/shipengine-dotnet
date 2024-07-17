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
/// Indicates whether an address is residential.
/// </summary>
/// <value>Indicates whether an address is residential.</value>
[JsonConverter(typeof(AddressResidentialIndicatorJsonConverter))]
public class AddressResidentialIndicator
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of AddressResidentialIndicator with a predefined value.
    /// </summary>
    internal AddressResidentialIndicator()
    {
        _value = "unknown";
    }

    /// <summary>
    /// Create a new instance of AddressResidentialIndicator with a custom value.
    /// </summary>
    /// <param name="value">The value of the AddressResidentialIndicator</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public AddressResidentialIndicator(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Unknown for value: unknown
    /// </summary>
    public static AddressResidentialIndicator Unknown { get; } = new("unknown");


    /// <summary>
    /// Enum Yes for value: yes
    /// </summary>
    public static AddressResidentialIndicator Yes { get; } = new("yes");


    /// <summary>
    /// Enum No for value: no
    /// </summary>
    public static AddressResidentialIndicator No { get; } = new("no");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is AddressResidentialIndicator other && _value == other._value;
}

internal class AddressResidentialIndicatorJsonConverter : JsonConverter<AddressResidentialIndicator>
{
    public override AddressResidentialIndicator? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AddressResidentialIndicator(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, AddressResidentialIndicator value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AddressResidentialIndicator);
}
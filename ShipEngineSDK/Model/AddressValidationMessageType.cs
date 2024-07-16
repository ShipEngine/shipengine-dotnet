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
/// The different types of messages that can be returned by the address validation API
/// </summary>
/// <value>The different types of messages that can be returned by the address validation API</value>
[JsonConverter(typeof(AddressValidationMessageTypeJsonConverter))]
public class AddressValidationMessageType
{
    private string _value;

    /// <summary>
    /// Create a new instance of AddressValidationMessageType with a predefined value.
    /// </summary>
    internal AddressValidationMessageType()
    {
        _value = "error";
    }

    /// <summary>
    /// Create a new instance of AddressValidationMessageType with a custom value.
    /// </summary>
    /// <param name="value">The value of the AddressValidationMessageType</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public AddressValidationMessageType(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Error for value: error
    /// </summary>
    public static AddressValidationMessageType Error { get; } = new("error");


    /// <summary>
    /// Enum Warning for value: warning
    /// </summary>
    public static AddressValidationMessageType Warning { get; } = new("warning");


    /// <summary>
    /// Enum Info for value: info
    /// </summary>
    public static AddressValidationMessageType Info { get; } = new("info");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class AddressValidationMessageTypeJsonConverter : JsonConverter<AddressValidationMessageType>
{
    public override AddressValidationMessageType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AddressValidationMessageType(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, AddressValidationMessageType value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AddressValidationMessageType);
}
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
/// The source of the error, as indicated by the name this informs us if the API call failed because of the carrier, the order source, or the ShipEngine API itself. 
/// </summary>
/// <value>The source of the error, as indicated by the name this informs us if the API call failed because of the carrier, the order source, or the ShipEngine API itself. </value>
[JsonConverter(typeof(ErrorSourceJsonConverter))]
public class ErrorSource
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of ErrorSource with a predefined value.
    /// </summary>
    internal ErrorSource()
    {
        _value = "carrier";
    }

    /// <summary>
    /// Create a new instance of ErrorSource with a custom value.
    /// </summary>
    /// <param name="value">The value of the ErrorSource</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public ErrorSource(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Carrier for value: carrier
    /// </summary>
    public static ErrorSource Carrier { get; } = new("carrier");


    /// <summary>
    /// Enum OrderSource for value: order_source
    /// </summary>
    public static ErrorSource OrderSource { get; } = new("order_source");


    /// <summary>
    /// Enum Shipengine for value: shipengine
    /// </summary>
    public static ErrorSource Shipengine { get; } = new("shipengine");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is ErrorSource other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class ErrorSourceJsonConverter : JsonConverter<ErrorSource>
{
    public override ErrorSource? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new ErrorSource(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, ErrorSource value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(ErrorSource);
}
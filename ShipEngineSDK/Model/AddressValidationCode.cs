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
/// The error codes that can be returned by the address validation API
/// </summary>
/// <value>The error codes that can be returned by the address validation API</value>
[JsonConverter(typeof(AddressValidationCodeJsonConverter))]
public class AddressValidationCode
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of AddressValidationCode with a predefined value.
    /// </summary>
    internal AddressValidationCode()
    {
        _value = "a1000";
    }

    /// <summary>
    /// Create a new instance of AddressValidationCode with a custom value.
    /// </summary>
    /// <param name="value">The value of the AddressValidationCode</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public AddressValidationCode(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum A1000 for value: a1000
    /// </summary>
    public static AddressValidationCode A1000 { get; } = new("a1000");


    /// <summary>
    /// Enum A1001 for value: a1001
    /// </summary>
    public static AddressValidationCode A1001 { get; } = new("a1001");


    /// <summary>
    /// Enum A1002 for value: a1002
    /// </summary>
    public static AddressValidationCode A1002 { get; } = new("a1002");


    /// <summary>
    /// Enum A1003 for value: a1003
    /// </summary>
    public static AddressValidationCode A1003 { get; } = new("a1003");


    /// <summary>
    /// Enum A1004 for value: a1004
    /// </summary>
    public static AddressValidationCode A1004 { get; } = new("a1004");


    /// <summary>
    /// Enum A1005 for value: a1005
    /// </summary>
    public static AddressValidationCode A1005 { get; } = new("a1005");


    /// <summary>
    /// Enum A1006 for value: a1006
    /// </summary>
    public static AddressValidationCode A1006 { get; } = new("a1006");


    /// <summary>
    /// Enum A1007 for value: a1007
    /// </summary>
    public static AddressValidationCode A1007 { get; } = new("a1007");


    /// <summary>
    /// Enum A1008 for value: a1008
    /// </summary>
    public static AddressValidationCode A1008 { get; } = new("a1008");


    /// <summary>
    /// Enum R1000 for value: r1000
    /// </summary>
    public static AddressValidationCode R1000 { get; } = new("r1000");


    /// <summary>
    /// Enum R1001 for value: r1001
    /// </summary>
    public static AddressValidationCode R1001 { get; } = new("r1001");


    /// <summary>
    /// Enum R1002 for value: r1002
    /// </summary>
    public static AddressValidationCode R1002 { get; } = new("r1002");


    /// <summary>
    /// Enum R1003 for value: r1003
    /// </summary>
    public static AddressValidationCode R1003 { get; } = new("r1003");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is AddressValidationCode other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class AddressValidationCodeJsonConverter : JsonConverter<AddressValidationCode>
{
    public override AddressValidationCode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AddressValidationCode(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, AddressValidationCode value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AddressValidationCode);
}
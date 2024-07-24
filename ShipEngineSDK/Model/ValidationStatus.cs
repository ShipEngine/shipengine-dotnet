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
/// The possible validation status values
/// </summary>
/// <value>The possible validation status values</value>
[JsonConverter(typeof(ValidationStatusJsonConverter))]
public class ValidationStatus
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of ValidationStatus with a predefined value.
    /// </summary>
    internal ValidationStatus()
    {
        _value = "valid";
    }

    /// <summary>
    /// Create a new instance of ValidationStatus with a custom value.
    /// </summary>
    /// <param name="value">The value of the ValidationStatus</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public ValidationStatus(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Valid for value: valid
    /// </summary>
    public static ValidationStatus Valid { get; } = new("valid");


    /// <summary>
    /// Enum Invalid for value: invalid
    /// </summary>
    public static ValidationStatus Invalid { get; } = new("invalid");


    /// <summary>
    /// Enum HasWarnings for value: has_warnings
    /// </summary>
    public static ValidationStatus HasWarnings { get; } = new("has_warnings");


    /// <summary>
    /// Enum Unknown for value: unknown
    /// </summary>
    public static ValidationStatus Unknown { get; } = new("unknown");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is ValidationStatus other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class ValidationStatusJsonConverter : JsonConverter<ValidationStatus>
{
    public override ValidationStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new ValidationStatus(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, ValidationStatus value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(ValidationStatus);
}
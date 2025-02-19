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
/// The possible non delivery values
/// </summary>
/// <value>The possible non delivery values</value>
[JsonConverter(typeof(NonDeliveryJsonConverter))]
public class NonDelivery
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of NonDelivery with a predefined value.
    /// </summary>
    internal NonDelivery()
    {
        _value = "return_to_sender";
    }

    /// <summary>
    /// Create a new instance of NonDelivery with a custom value.
    /// </summary>
    /// <param name="value">The value of the NonDelivery</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public NonDelivery(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum ReturnToSender for value: return_to_sender
    /// </summary>
    public static NonDelivery ReturnToSender { get; } = new("return_to_sender");


    /// <summary>
    /// Enum TreatAsAbandoned for value: treat_as_abandoned
    /// </summary>
    public static NonDelivery TreatAsAbandoned { get; } = new("treat_as_abandoned");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is NonDelivery other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class NonDeliveryJsonConverter : JsonConverter<NonDelivery>
{
    public override NonDelivery? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new NonDelivery(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, NonDelivery value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(NonDelivery);
}
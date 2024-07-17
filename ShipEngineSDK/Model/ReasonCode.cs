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
/// The possible normalized reasons a label void request may not have been approved
/// </summary>
/// <value>The possible normalized reasons a label void request may not have been approved</value>
[JsonConverter(typeof(ReasonCodeJsonConverter))]
public class ReasonCode
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of ReasonCode with a predefined value.
    /// </summary>
    internal ReasonCode()
    {
        _value = "unknown";
    }

    /// <summary>
    /// Create a new instance of ReasonCode with a custom value.
    /// </summary>
    /// <param name="value">The value of the ReasonCode</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public ReasonCode(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Unknown for value: unknown
    /// </summary>
    public static ReasonCode Unknown { get; } = new("unknown");


    /// <summary>
    /// Enum Unspecified for value: unspecified
    /// </summary>
    public static ReasonCode Unspecified { get; } = new("unspecified");


    /// <summary>
    /// Enum ValidationFailed for value: validation_failed
    /// </summary>
    public static ReasonCode ValidationFailed { get; } = new("validation_failed");


    /// <summary>
    /// Enum LabelNotFoundWithinVoidPeriod for value: label_not_found_within_void_period
    /// </summary>
    public static ReasonCode LabelNotFoundWithinVoidPeriod { get; } = new("label_not_found_within_void_period");


    /// <summary>
    /// Enum LabelAlreadyUsed for value: label_already_used
    /// </summary>
    public static ReasonCode LabelAlreadyUsed { get; } = new("label_already_used");


    /// <summary>
    /// Enum LabelAlreadyVoided for value: label_already_voided
    /// </summary>
    public static ReasonCode LabelAlreadyVoided { get; } = new("label_already_voided");


    /// <summary>
    /// Enum ContactCarrier for value: contact_carrier
    /// </summary>
    public static ReasonCode ContactCarrier { get; } = new("contact_carrier");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is ReasonCode other && _value == other._value;
}

internal class ReasonCodeJsonConverter : JsonConverter<ReasonCode>
{
    public override ReasonCode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new ReasonCode(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, ReasonCode value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(ReasonCode);
}
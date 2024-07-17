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
/// The possible batch status values
/// </summary>
/// <value>The possible batch status values</value>
[JsonConverter(typeof(BatchStatusJsonConverter))]
public class BatchStatus
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of BatchStatus with a predefined value.
    /// </summary>
    internal BatchStatus()
    {
        _value = "open";
    }

    /// <summary>
    /// Create a new instance of BatchStatus with a custom value.
    /// </summary>
    /// <param name="value">The value of the BatchStatus</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public BatchStatus(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Open for value: open
    /// </summary>
    public static BatchStatus Open { get; } = new("open");


    /// <summary>
    /// Enum Queued for value: queued
    /// </summary>
    public static BatchStatus Queued { get; } = new("queued");


    /// <summary>
    /// Enum Processing for value: processing
    /// </summary>
    public static BatchStatus Processing { get; } = new("processing");


    /// <summary>
    /// Enum Completed for value: completed
    /// </summary>
    public static BatchStatus Completed { get; } = new("completed");


    /// <summary>
    /// Enum CompletedWithErrors for value: completed_with_errors
    /// </summary>
    public static BatchStatus CompletedWithErrors { get; } = new("completed_with_errors");


    /// <summary>
    /// Enum Archived for value: archived
    /// </summary>
    public static BatchStatus Archived { get; } = new("archived");


    /// <summary>
    /// Enum Notifying for value: notifying
    /// </summary>
    public static BatchStatus Notifying { get; } = new("notifying");


    /// <summary>
    /// Enum Invalid for value: invalid
    /// </summary>
    public static BatchStatus Invalid { get; } = new("invalid");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is BatchStatus other && _value == other._value;
}

internal class BatchStatusJsonConverter : JsonConverter<BatchStatus>
{
    public override BatchStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new BatchStatus(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, BatchStatus value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(BatchStatus);
}
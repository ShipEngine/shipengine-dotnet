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
/// The possible statuses of a manifest request
/// </summary>
/// <value>The possible statuses of a manifest request</value>
[JsonConverter(typeof(ManifestRequestStatusJsonConverter))]
public class ManifestRequestStatus
{
    private string _value;

    internal ManifestRequestStatus()
    {
        _value = "in_progress";
    }

    /// <summary>
    /// Create a new instance of ManifestRequestStatus with a custom value.
    /// </summary>
    /// <param name="value">The value of the ManifestRequestStatus</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public ManifestRequestStatus(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum InProgress for value: in_progress
    /// </summary>
    public static ManifestRequestStatus InProgress { get; } = new("in_progress");


    /// <summary>
    /// Enum Completed for value: completed
    /// </summary>
    public static ManifestRequestStatus Completed { get; } = new("completed");


    public override string ToString() => _value;
}

internal class ManifestRequestStatusJsonConverter : JsonConverter<ManifestRequestStatus>
{
    public override ManifestRequestStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new ManifestRequestStatus(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, ManifestRequestStatus value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(ManifestRequestStatus);
}
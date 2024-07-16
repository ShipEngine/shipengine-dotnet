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
/// The possible shipment status values
/// </summary>
/// <value>The possible shipment status values</value>
[JsonConverter(typeof(ShipmentStatusJsonConverter))]
public class ShipmentStatus
{
    private string _value;

    /// <summary>
    /// Create a new instance of ShipmentStatus with a predefined value.
    /// </summary>
    internal ShipmentStatus()
    {
        _value = "pending";
    }

    /// <summary>
    /// Create a new instance of ShipmentStatus with a custom value.
    /// </summary>
    /// <param name="value">The value of the ShipmentStatus</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public ShipmentStatus(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Pending for value: pending
    /// </summary>
    public static ShipmentStatus Pending { get; } = new("pending");


    /// <summary>
    /// Enum Processing for value: processing
    /// </summary>
    public static ShipmentStatus Processing { get; } = new("processing");


    /// <summary>
    /// Enum LabelPurchased for value: label_purchased
    /// </summary>
    public static ShipmentStatus LabelPurchased { get; } = new("label_purchased");


    /// <summary>
    /// Enum Cancelled for value: cancelled
    /// </summary>
    public static ShipmentStatus Cancelled { get; } = new("cancelled");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class ShipmentStatusJsonConverter : JsonConverter<ShipmentStatus>
{
    public override ShipmentStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new ShipmentStatus(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, ShipmentStatus value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(ShipmentStatus);
}
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
/// The shipping carriers for which ShipEngine supports carrier settings
/// </summary>
/// <value>The shipping carriers for which ShipEngine supports carrier settings</value>
[JsonConverter(typeof(CarrierNameWithSettingsJsonConverter))]
public class CarrierNameWithSettings
{
    private string _value;

    internal CarrierNameWithSettings()
    {
        _value = "dhl_express";
    }

    /// <summary>
    /// Create a new instance of CarrierNameWithSettings with a custom value.
    /// </summary>
    /// <param name="value">The value of the CarrierNameWithSettings</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public CarrierNameWithSettings(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum DhlExpress for value: dhl_express
    /// </summary>
    public static CarrierNameWithSettings DhlExpress { get; } = new("dhl_express");


    /// <summary>
    /// Enum Fedex for value: fedex
    /// </summary>
    public static CarrierNameWithSettings Fedex { get; } = new("fedex");


    /// <summary>
    /// Enum Newgistics for value: newgistics
    /// </summary>
    public static CarrierNameWithSettings Newgistics { get; } = new("newgistics");


    /// <summary>
    /// Enum Ups for value: ups
    /// </summary>
    public static CarrierNameWithSettings Ups { get; } = new("ups");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class CarrierNameWithSettingsJsonConverter : JsonConverter<CarrierNameWithSettings>
{
    public override CarrierNameWithSettings? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new CarrierNameWithSettings(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, CarrierNameWithSettings value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(CarrierNameWithSettings);
}
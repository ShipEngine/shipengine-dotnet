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
/// Defines transport_mean
/// </summary>
[JsonConverter(typeof(TransportMeanJsonConverter))]
public class TransportMean
{
    private string _value;

    internal TransportMean()
    {
        _value = "ground";
    }

    /// <summary>
    /// Create a new instance of TransportMean with a custom value.
    /// </summary>
    /// <param name="value">The value of the TransportMean</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public TransportMean(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Ground for value: ground
    /// </summary>
    public static TransportMean Ground { get; } = new("ground");


    /// <summary>
    /// Enum Water for value: water
    /// </summary>
    public static TransportMean Water { get; } = new("water");


    /// <summary>
    /// Enum CargoAircraftOnly for value: cargo_aircraft_only
    /// </summary>
    public static TransportMean CargoAircraftOnly { get; } = new("cargo_aircraft_only");


    /// <summary>
    /// Enum PassengerAircraft for value: passenger_aircraft
    /// </summary>
    public static TransportMean PassengerAircraft { get; } = new("passenger_aircraft");


    public override string ToString() => _value;
}

internal class TransportMeanJsonConverter : JsonConverter<TransportMean>
{
    public override TransportMean? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new TransportMean(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, TransportMean value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(TransportMean);
}
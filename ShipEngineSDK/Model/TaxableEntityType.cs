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
/// The taxable entity type for this tax item. Valid values include the following  |Value       |Description |:- -- -- -- --  |:- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;shipper&#x60;   | The shipper is responsible for this tax. |&#x60;recipient&#x60; | The recipient of the shipment is responsible for this tax. |&#x60;ior&#x60;       | The importer of records is responsible for tax. 
/// </summary>
/// <value>The taxable entity type for this tax item. Valid values include the following  |Value       |Description |:- -- -- -- --  |:- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;shipper&#x60;   | The shipper is responsible for this tax. |&#x60;recipient&#x60; | The recipient of the shipment is responsible for this tax. |&#x60;ior&#x60;       | The importer of records is responsible for tax. </value>
[JsonConverter(typeof(TaxableEntityTypeJsonConverter))]
public class TaxableEntityType
{
    private string _value;

    /// <summary>
    /// Create a new instance of TaxableEntityType with a predefined value.
    /// </summary>
    internal TaxableEntityType()
    {
        _value = "shipper";
    }

    /// <summary>
    /// Create a new instance of TaxableEntityType with a custom value.
    /// </summary>
    /// <param name="value">The value of the TaxableEntityType</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public TaxableEntityType(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Shipper for value: shipper
    /// </summary>
    public static TaxableEntityType Shipper { get; } = new("shipper");


    /// <summary>
    /// Enum Recipient for value: recipient
    /// </summary>
    public static TaxableEntityType Recipient { get; } = new("recipient");


    /// <summary>
    /// Enum Ior for value: ior
    /// </summary>
    public static TaxableEntityType Ior { get; } = new("ior");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class TaxableEntityTypeJsonConverter : JsonConverter<TaxableEntityType>
{
    public override TaxableEntityType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new TaxableEntityType(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, TaxableEntityType value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(TaxableEntityType);
}
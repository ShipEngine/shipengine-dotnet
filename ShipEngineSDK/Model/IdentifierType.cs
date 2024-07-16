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
/// Tax identifier type for customs declaration  |Pickup Type    | Description |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;vat&#x60;          | The tax identifier is a Value Added Tax. |&#x60;eori&#x60;         | The tax identifier is an Economic Operators Registration and Identification Number (EORI). |&#x60;ssn&#x60;          | The tax identifier is a Social Security Number. |&#x60;ein&#x60;          | The tax identifier is an Employer Identification Number (EIN). |&#x60;tin&#x60;          | The tax identifier is a Tax Identification Number (TIN). |&#x60;ioss&#x60;         | The tax identifier is an Import One-Stop Shop (IOSS). |&#x60;pan&#x60;          | The tax identifier is a Permanent Account Number (PAN). |&#x60;voec&#x60;         | The tax identifier is a Norwegian VAT On E-Commerce(VOEC). |&#x60;pccc&#x60;         | The tax identifier is a Personal Customs Clearance Code (PCCC). |&#x60;oss&#x60;          | The tax identifier is an One-Stop Shop (OSS). |&#x60;passport&#x60;     | The tax identifier is a Passport Number. |&#x60;abn&#x60;          | The tax identifier is an Australian Business Number. 
/// </summary>
/// <value>Tax identifier type for customs declaration  |Pickup Type    | Description |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;vat&#x60;          | The tax identifier is a Value Added Tax. |&#x60;eori&#x60;         | The tax identifier is an Economic Operators Registration and Identification Number (EORI). |&#x60;ssn&#x60;          | The tax identifier is a Social Security Number. |&#x60;ein&#x60;          | The tax identifier is an Employer Identification Number (EIN). |&#x60;tin&#x60;          | The tax identifier is a Tax Identification Number (TIN). |&#x60;ioss&#x60;         | The tax identifier is an Import One-Stop Shop (IOSS). |&#x60;pan&#x60;          | The tax identifier is a Permanent Account Number (PAN). |&#x60;voec&#x60;         | The tax identifier is a Norwegian VAT On E-Commerce(VOEC). |&#x60;pccc&#x60;         | The tax identifier is a Personal Customs Clearance Code (PCCC). |&#x60;oss&#x60;          | The tax identifier is an One-Stop Shop (OSS). |&#x60;passport&#x60;     | The tax identifier is a Passport Number. |&#x60;abn&#x60;          | The tax identifier is an Australian Business Number. </value>
[JsonConverter(typeof(IdentifierTypeJsonConverter))]
public class IdentifierType
{
    private string _value;

    /// <summary>
    /// Create a new instance of IdentifierType with a predefined value.
    /// </summary>
    internal IdentifierType()
    {
        _value = "vat";
    }

    /// <summary>
    /// Create a new instance of IdentifierType with a custom value.
    /// </summary>
    /// <param name="value">The value of the IdentifierType</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public IdentifierType(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Vat for value: vat
    /// </summary>
    public static IdentifierType Vat { get; } = new("vat");


    /// <summary>
    /// Enum Eori for value: eori
    /// </summary>
    public static IdentifierType Eori { get; } = new("eori");


    /// <summary>
    /// Enum Ssn for value: ssn
    /// </summary>
    public static IdentifierType Ssn { get; } = new("ssn");


    /// <summary>
    /// Enum Ein for value: ein
    /// </summary>
    public static IdentifierType Ein { get; } = new("ein");


    /// <summary>
    /// Enum Tin for value: tin
    /// </summary>
    public static IdentifierType Tin { get; } = new("tin");


    /// <summary>
    /// Enum Ioss for value: ioss
    /// </summary>
    public static IdentifierType Ioss { get; } = new("ioss");


    /// <summary>
    /// Enum Pan for value: pan
    /// </summary>
    public static IdentifierType Pan { get; } = new("pan");


    /// <summary>
    /// Enum Voec for value: voec
    /// </summary>
    public static IdentifierType Voec { get; } = new("voec");


    /// <summary>
    /// Enum Pccc for value: pccc
    /// </summary>
    public static IdentifierType Pccc { get; } = new("pccc");


    /// <summary>
    /// Enum Oss for value: oss
    /// </summary>
    public static IdentifierType Oss { get; } = new("oss");


    /// <summary>
    /// Enum Passport for value: passport
    /// </summary>
    public static IdentifierType Passport { get; } = new("passport");


    /// <summary>
    /// Enum Abn for value: abn
    /// </summary>
    public static IdentifierType Abn { get; } = new("abn");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class IdentifierTypeJsonConverter : JsonConverter<IdentifierType>
{
    public override IdentifierType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new IdentifierType(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, IdentifierType value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(IdentifierType);
}
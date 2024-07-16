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
/// The possible file formats in which shipping labels can be downloaded.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  |Label Format  | Supported Carriers |- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;pdf&#x60;         | All carriers |&#x60;png&#x60;         | &#x60;fedex&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; |&#x60;zpl&#x60;         | &#x60;access_worldwide&#x60; &lt;br&gt; &#x60;apc&#x60; &lt;br&gt; &#x60;asendia&#x60; &lt;br&gt; &#x60;dhl_global_mail&#x60; &lt;br&gt; &#x60;dhl_express&#x60; &lt;br&gt; &#x60;dhl_express_australia&#x60; &lt;br&gt; &#x60;dhl_express_canada&#x60; &lt;br&gt; &#x60;dhl_express_worldwide&#x60; &lt;br&gt; &#x60;dhl_express_uk&#x60; &lt;br&gt; &#x60;dpd&#x60; &lt;br&gt; &#x60;endicia&#x60; &lt;br&gt; &#x60;fedex&#x60; &lt;br&gt; &#x60;fedex_uk&#x60; &lt;br&gt; &#x60;firstmile&#x60; &lt;br&gt; &#x60;imex&#x60; &lt;br&gt; &#x60;newgistics&#x60; &lt;br&gt; &#x60;ontrac&#x60; &lt;br&gt; &#x60;rr_donnelley&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; 
/// </summary>
/// <value>The possible file formats in which shipping labels can be downloaded.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  |Label Format  | Supported Carriers |- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;pdf&#x60;         | All carriers |&#x60;png&#x60;         | &#x60;fedex&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; |&#x60;zpl&#x60;         | &#x60;access_worldwide&#x60; &lt;br&gt; &#x60;apc&#x60; &lt;br&gt; &#x60;asendia&#x60; &lt;br&gt; &#x60;dhl_global_mail&#x60; &lt;br&gt; &#x60;dhl_express&#x60; &lt;br&gt; &#x60;dhl_express_australia&#x60; &lt;br&gt; &#x60;dhl_express_canada&#x60; &lt;br&gt; &#x60;dhl_express_worldwide&#x60; &lt;br&gt; &#x60;dhl_express_uk&#x60; &lt;br&gt; &#x60;dpd&#x60; &lt;br&gt; &#x60;endicia&#x60; &lt;br&gt; &#x60;fedex&#x60; &lt;br&gt; &#x60;fedex_uk&#x60; &lt;br&gt; &#x60;firstmile&#x60; &lt;br&gt; &#x60;imex&#x60; &lt;br&gt; &#x60;newgistics&#x60; &lt;br&gt; &#x60;ontrac&#x60; &lt;br&gt; &#x60;rr_donnelley&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; </value>
[JsonConverter(typeof(LabelFormatJsonConverter))]
public class LabelFormat
{
    private string _value;

    /// <summary>
    /// Create a new instance of LabelFormat with a predefined value.
    /// </summary>
    internal LabelFormat()
    {
        _value = "pdf";
    }

    /// <summary>
    /// Create a new instance of LabelFormat with a custom value.
    /// </summary>
    /// <param name="value">The value of the LabelFormat</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public LabelFormat(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Pdf for value: pdf
    /// </summary>
    public static LabelFormat Pdf { get; } = new("pdf");


    /// <summary>
    /// Enum Png for value: png
    /// </summary>
    public static LabelFormat Png { get; } = new("png");


    /// <summary>
    /// Enum Zpl for value: zpl
    /// </summary>
    public static LabelFormat Zpl { get; } = new("zpl");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class LabelFormatJsonConverter : JsonConverter<LabelFormat>
{
    public override LabelFormat? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new LabelFormat(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, LabelFormat value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(LabelFormat);
}
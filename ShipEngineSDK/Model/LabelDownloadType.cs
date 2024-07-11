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
/// There are two different ways to [download a label](https://www.shipengine.com/docs/labels/downloading/):  |Label Download Type | Description |- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |&#x60;url&#x60;               |You will receive a URL, which you can use to download the label in a separate request. The URL will remain valid for 90 days.&lt;br&gt;&lt;br&gt;This is the default if &#x60;label_download_type&#x60; is unspecified. |&#x60;inline&#x60;            |You will receive the Base64-encoded label as part of the response. No need for a second request to download the label. 
/// </summary>
/// <value>There are two different ways to [download a label](https://www.shipengine.com/docs/labels/downloading/):  |Label Download Type | Description |- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |&#x60;url&#x60;               |You will receive a URL, which you can use to download the label in a separate request. The URL will remain valid for 90 days.&lt;br&gt;&lt;br&gt;This is the default if &#x60;label_download_type&#x60; is unspecified. |&#x60;inline&#x60;            |You will receive the Base64-encoded label as part of the response. No need for a second request to download the label. </value>
[JsonConverter(typeof(LabelDownloadTypeJsonConverter))]
public class LabelDownloadType
{
    private string _value;

    internal LabelDownloadType()
    {
        _value = "url";
    }

    /// <summary>
    /// Create a new instance of LabelDownloadType with a custom value.
    /// </summary>
    /// <param name="value">The value of the LabelDownloadType</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public LabelDownloadType(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum Url for value: url
    /// </summary>
    public static LabelDownloadType Url { get; } = new("url");


    /// <summary>
    /// Enum Inline for value: inline
    /// </summary>
    public static LabelDownloadType Inline { get; } = new("inline");


    public override string ToString() => _value;
}

internal class LabelDownloadTypeJsonConverter : JsonConverter<LabelDownloadType>
{
    public override LabelDownloadType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new LabelDownloadType(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, LabelDownloadType value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(LabelDownloadType);
}
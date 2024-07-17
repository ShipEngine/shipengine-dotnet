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
/// A newgistics account settings request body
/// </summary>
public partial class UpdateNewgisticsSettingsRequestBody
{

    /// <summary>
    /// Gets or Sets IncludeBarcodeWithOrderNumber
    /// </summary>
    [JsonPropertyName("include_barcode_with_order_number"), JsonPropertyOrder(1)]
    public bool? IncludeBarcodeWithOrderNumber { get; set; }

    /// <summary>
    /// Gets or Sets ReceiveEmailOnManifestProcessing
    /// </summary>
    [JsonPropertyName("receive_email_on_manifest_processing"), JsonPropertyOrder(2)]
    public bool? ReceiveEmailOnManifestProcessing { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateNewgisticsSettingsRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  IncludeBarcodeWithOrderNumber: ").Append(IncludeBarcodeWithOrderNumber).Append("\n");
        sb.Append("  ReceiveEmailOnManifestProcessing: ").Append(ReceiveEmailOnManifestProcessing).Append("\n");
#pragma warning restore CS0612 // Type or member is obsolete
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }

}
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
/// A create manifest request body
/// </summary>
public partial class CreateManifestByObjectRequestBody
{

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    [JsonRequired]
    public string CarrierId { get; set; }

    /// <summary>
    /// The list of label ids to exclude from the manifest
    /// </summary>
    /// <value>The list of label ids to exclude from the manifest</value>
    [JsonPropertyName("excluded_label_ids")]
    public List<string> ExcludedLabelIds { get; set; }

    /// <summary>
    /// The list of label ids to include for the manifest
    /// </summary>
    /// <value>The list of label ids to include for the manifest</value>
    [JsonPropertyName("label_ids")]
    public List<string> LabelIds { get; set; }

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id")]
    [JsonRequired]
    public string WarehouseId { get; set; }

    /// <summary>
    /// The ship date that the shipment will be sent out on
    /// </summary>
    /// <value>The ship date that the shipment will be sent out on</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    [JsonRequired]
    public DateTimeOffset ShipDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateManifestByObjectRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ExcludedLabelIds: ").Append(ExcludedLabelIds).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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
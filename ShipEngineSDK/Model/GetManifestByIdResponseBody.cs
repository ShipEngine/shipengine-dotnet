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
/// A get manifest by id response body
/// </summary>
public partial class GetManifestByIdResponseBody
{

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; private set; }

    /// <summary>
    /// The date-time that the manifest was created
    /// </summary>
    /// <value>The date-time that the manifest was created</value>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the form
    /// </summary>
    /// <value>A string that uniquely identifies the form</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("form_id"), JsonInclude]
    public string? FormId { get; private set; }

    /// <summary>
    /// An array of the label ids used in this manifest.
    /// </summary>
    /// <value>An array of the label ids used in this manifest.</value>
    [JsonPropertyName("label_ids"), JsonInclude]
    public List<string>? LabelIds { get; private set; }

    /// <summary>
    /// Gets or Sets ManifestDownload
    /// </summary>
    [JsonPropertyName("manifest_download"), JsonInclude]
    public ManifestDownload? ManifestDownload { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the manifest
    /// </summary>
    /// <value>A string that uniquely identifies the manifest</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("manifest_id"), JsonInclude]
    public string? ManifestId { get; private set; }

    /// <summary>
    /// The date-time that the manifests shipments will be picked up
    /// </summary>
    /// <value>The date-time that the manifests shipments will be picked up</value>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("ship_date"), JsonInclude]
    public DateTimeOffset? ShipDate { get; private set; }

    /// <summary>
    /// The number of shipments that are included in this manifest
    /// </summary>
    /// <value>The number of shipments that are included in this manifest</value>
    /// <example>
    /// 100
    /// </example>
    [JsonPropertyName("shipments"), JsonInclude]
    public int? Shipments { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the submission
    /// </summary>
    /// <value>A string that uniquely identifies the submission</value>
    /// <example>
    /// 9475711899564878915476
    /// </example>
    [JsonPropertyName("submission_id"), JsonInclude]
    public string? SubmissionId { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id"), JsonInclude]
    public string? WarehouseId { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetManifestByIdResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  FormId: ").Append(FormId).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  ManifestDownload: ").Append(ManifestDownload).Append("\n");
        sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  Shipments: ").Append(Shipments).Append("\n");
        sb.Append("  SubmissionId: ").Append(SubmissionId).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
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
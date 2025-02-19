// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


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
/// Used for combining packages into one scannable form that a carrier can use when picking up a large  number of shipments 
/// </summary>
public partial class Manifest
{

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; set; }

    /// <summary>
    /// The date-time that the manifest was created
    /// </summary>
    /// <value>The date-time that the manifest was created</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// A string that uniquely identifies the form
    /// </summary>
    /// <value>A string that uniquely identifies the form</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("form_id"), JsonInclude]
    public string? FormId { get; set; }

    /// <summary>
    /// An array of the label ids used in this manifest.
    /// </summary>
    /// <value>An array of the label ids used in this manifest.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("label_ids"), JsonInclude]
    public List<string>? LabelIds { get; set; }

    /// <summary>
    /// Gets or Sets ManifestDownload
    /// </summary>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("manifest_download"), JsonInclude]
    public ManifestDownload? ManifestDownload { get; set; }

    /// <summary>
    /// A string that uniquely identifies the manifest
    /// </summary>
    /// <value>A string that uniquely identifies the manifest</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("manifest_id"), JsonInclude]
    public string? ManifestId { get; set; }

    /// <summary>
    /// The date-time that the manifests shipments will be picked up
    /// </summary>
    /// <value>The date-time that the manifests shipments will be picked up</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("ship_date"), JsonInclude]
    public DateTimeOffset? ShipDate { get; set; }

    /// <summary>
    /// The number of shipments that are included in this manifest
    /// </summary>
    /// <value>The number of shipments that are included in this manifest</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 100
    /// </example>
    [JsonPropertyName("shipments"), JsonInclude]
    public int? Shipments { get; set; }

    /// <summary>
    /// A string that uniquely identifies the submission
    /// </summary>
    /// <value>A string that uniquely identifies the submission</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 9475711899564878915476
    /// </example>
    [JsonPropertyName("submission_id"), JsonInclude]
    public string? SubmissionId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id"), JsonInclude]
    public string? WarehouseId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Manifest {\n");
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
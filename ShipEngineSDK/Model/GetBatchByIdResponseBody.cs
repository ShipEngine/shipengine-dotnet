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
/// A get batch by id response body
/// </summary>
public partial class GetBatchByIdResponseBody
{

    /// <summary>
    /// Link to batch errors endpoint
    /// </summary>
    /// <value>Link to batch errors endpoint</value>
    [JsonPropertyName("batch_errors_url"), JsonInclude]
    public OptionalLink? BatchErrorsUrl { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the batch
    /// </summary>
    /// <value>A string that uniquely identifies the batch</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("batch_id"), JsonInclude]
    public string? BatchId { get; private set; }

    /// <summary>
    /// Link to batch labels query
    /// </summary>
    /// <value>Link to batch labels query</value>
    [JsonPropertyName("batch_labels_url"), JsonPropertyOrder(3)]
    public required OptionalLink BatchLabelsUrl { get; set; }

    /// <summary>
    /// The batch number.
    /// </summary>
    /// <value>The batch number.</value>
    [JsonPropertyName("batch_number"), JsonInclude]
    public string? BatchNumber { get; private set; }

    /// <summary>
    /// The batch shipments endpoint
    /// </summary>
    /// <value>The batch shipments endpoint</value>
    [JsonPropertyName("batch_shipments_url"), JsonPropertyOrder(5)]
    public required OptionalLink BatchShipmentsUrl { get; set; }

    /// <summary>
    /// The number of labels generated in the batch
    /// </summary>
    /// <value>The number of labels generated in the batch</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("completed"), JsonInclude]
    public int? Completed { get; private set; }

    /// <summary>
    /// The total of errors, warnings, and completed properties
    /// </summary>
    /// <value>The total of errors, warnings, and completed properties</value>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("count"), JsonInclude]
    public int? Count { get; private set; }

    /// <summary>
    /// The date and time the batch was created in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was created in ShipEngine</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; private set; }

    /// <summary>
    /// The number of errors that occurred while generating the batch
    /// </summary>
    /// <value>The number of errors that occurred while generating the batch</value>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("errors"), JsonInclude]
    public int? Errors { get; private set; }

    /// <summary>
    /// The form download for any customs that are needed
    /// </summary>
    /// <value>The form download for any customs that are needed</value>
    [JsonPropertyName("form_download"), JsonInclude]
    public OptionalLink? FormDownload { get; private set; }

    /// <summary>
    /// The number of forms for customs that are available for download
    /// </summary>
    /// <value>The number of forms for customs that are available for download</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("forms"), JsonInclude]
    public int? Forms { get; private set; }

    /// <summary>
    /// The label download for the batch
    /// </summary>
    /// <value>The label download for the batch</value>
    [JsonPropertyName("label_download"), JsonInclude]
    public LabelDownload? LabelDownload { get; private set; }

    /// <summary>
    /// Gets or Sets LabelFormat
    /// </summary>
    [JsonPropertyName("label_format"), JsonInclude]
    public LabelFormat? LabelFormat { get; private set; }

    /// <summary>
    /// label layout
    /// </summary>
    /// <value>label layout</value>
    [JsonPropertyName("label_layout"), JsonInclude]
    public LabelLayout? LabelLayout { get; private set; }

    /// <summary>
    /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.
    /// </summary>
    /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.</value>
    [JsonPropertyName("paperless_download"), JsonInclude]
    public PaperlessDownload? PaperlessDownload { get; private set; }

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("process_errors"), JsonInclude]
    public List<Error>? ProcessErrors { get; private set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status"), JsonInclude]
    public BatchStatus? Status { get; private set; }

    /// <summary>
    /// The number of warnings that occurred while generating the batch
    /// </summary>
    /// <value>The number of warnings that occurred while generating the batch</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("warnings"), JsonInclude]
    public int? Warnings { get; private set; }

    /// <summary>
    /// Custom notes you can add for each created batch
    /// </summary>
    /// <value>Custom notes you can add for each created batch</value>
    /// <example>
    /// Batch for morning shipment
    /// </example>
    [JsonPropertyName("batch_notes"), JsonInclude]
    public string? BatchNotes { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the external batch
    /// </summary>
    /// <value>A string that uniquely identifies the external batch</value>
    [JsonPropertyName("external_batch_id"), JsonInclude]
    public string? ExternalBatchId { get; private set; }

    /// <summary>
    /// The date and time the batch was processed in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was processed in ShipEngine</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("processed_at"), JsonInclude]
    public DateTimeOffset? ProcessedAt { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetBatchByIdResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  BatchErrorsUrl: ").Append(BatchErrorsUrl).Append("\n");
        sb.Append("  BatchId: ").Append(BatchId).Append("\n");
        sb.Append("  BatchLabelsUrl: ").Append(BatchLabelsUrl).Append("\n");
        sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
        sb.Append("  BatchShipmentsUrl: ").Append(BatchShipmentsUrl).Append("\n");
        sb.Append("  Completed: ").Append(Completed).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  FormDownload: ").Append(FormDownload).Append("\n");
        sb.Append("  Forms: ").Append(Forms).Append("\n");
        sb.Append("  LabelDownload: ").Append(LabelDownload).Append("\n");
        sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
        sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
        sb.Append("  PaperlessDownload: ").Append(PaperlessDownload).Append("\n");
        sb.Append("  ProcessErrors: ").Append(ProcessErrors).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Warnings: ").Append(Warnings).Append("\n");
        sb.Append("  BatchNotes: ").Append(BatchNotes).Append("\n");
        sb.Append("  ExternalBatchId: ").Append(ExternalBatchId).Append("\n");
        sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
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
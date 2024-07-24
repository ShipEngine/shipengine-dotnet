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
/// Batches are an advanced feature of ShipEngine designed for users who need to generate hundreds or thousands of labels at a time. 
/// </summary>
public partial class Batch
{

    /// <summary>
    /// Link to batch errors endpoint
    /// </summary>
    /// <value>Link to batch errors endpoint</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("batch_errors_url"), JsonInclude]
    public OptionalLink? BatchErrorsUrl { get; set; }

    /// <summary>
    /// A string that uniquely identifies the batch
    /// </summary>
    /// <value>A string that uniquely identifies the batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("batch_id"), JsonInclude]
    public string? BatchId { get; set; }

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
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("batch_number"), JsonInclude]
    public string? BatchNumber { get; set; }

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
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("completed"), JsonInclude]
    public int? Completed { get; set; }

    /// <summary>
    /// The total of errors, warnings, and completed properties
    /// </summary>
    /// <value>The total of errors, warnings, and completed properties</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("count"), JsonInclude]
    public int? Count { get; set; }

    /// <summary>
    /// The date and time the batch was created in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was created in ShipEngine</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The number of errors that occurred while generating the batch
    /// </summary>
    /// <value>The number of errors that occurred while generating the batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("errors"), JsonInclude]
    public int? Errors { get; set; }

    /// <summary>
    /// The form download for any customs that are needed
    /// </summary>
    /// <value>The form download for any customs that are needed</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("form_download"), JsonInclude]
    public OptionalLink? FormDownload { get; set; }

    /// <summary>
    /// The number of forms for customs that are available for download
    /// </summary>
    /// <value>The number of forms for customs that are available for download</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("forms"), JsonInclude]
    public int? Forms { get; set; }

    /// <summary>
    /// The label download for the batch
    /// </summary>
    /// <value>The label download for the batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("label_download"), JsonInclude]
    public LabelDownload? LabelDownload { get; set; }

    /// <summary>
    /// Gets or Sets LabelFormat
    /// </summary>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("label_format"), JsonInclude]
    public LabelFormat? LabelFormat { get; set; }

    /// <summary>
    /// label layout
    /// </summary>
    /// <value>label layout</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("label_layout"), JsonInclude]
    public LabelLayout? LabelLayout { get; set; }

    /// <summary>
    /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.
    /// </summary>
    /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("paperless_download"), JsonInclude]
    public PaperlessDownload? PaperlessDownload { get; set; }

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("process_errors"), JsonInclude]
    public List<Error>? ProcessErrors { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("status"), JsonInclude]
    public BatchStatus? Status { get; set; }

    /// <summary>
    /// The number of warnings that occurred while generating the batch
    /// </summary>
    /// <value>The number of warnings that occurred while generating the batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("warnings"), JsonInclude]
    public int? Warnings { get; set; }

    /// <summary>
    /// Custom notes you can add for each created batch
    /// </summary>
    /// <value>Custom notes you can add for each created batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// Batch for morning shipment
    /// </example>
    [JsonPropertyName("batch_notes"), JsonInclude]
    public string? BatchNotes { get; set; }

    /// <summary>
    /// A string that uniquely identifies the external batch
    /// </summary>
    /// <value>A string that uniquely identifies the external batch</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("external_batch_id"), JsonInclude]
    public string? ExternalBatchId { get; set; }

    /// <summary>
    /// The date and time the batch was processed in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was processed in ShipEngine</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("processed_at"), JsonInclude]
    public DateTimeOffset? ProcessedAt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Batch {\n");
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
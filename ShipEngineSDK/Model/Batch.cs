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
/// Batches are an advanced feature of ShipEngine designed for users who need to generate hundreds or thousands of labels at a time. 
/// </summary>
public partial class Batch
{

    /// <summary>
    /// label layout  CLOVUS
    /// </summary>
    /// <value>label layout</value>
    [JsonPropertyName("label_layout")]
    [JsonRequired]
    public LabelLayout LabelLayout { get; set; } = new();


    /// <summary>
    /// Gets or Sets LabelFormat  CLOVUS
    /// </summary>
    [JsonPropertyName("label_format")]
    [JsonRequired]
    public LabelFormat LabelFormat { get; set; } = new();


    /// <summary>
    /// Gets or Sets Status  CLOVUS
    /// </summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public BatchStatus Status { get; set; } = new();


    /// <summary>
    /// A string that uniquely identifies the batch
    /// </summary>
    /// <value>A string that uniquely identifies the batch</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("batch_id")]
    [JsonRequired]
    public string BatchId { get; set; }

    /// <summary>
    /// The batch number.
    /// </summary>
    /// <value>The batch number.</value>
    [JsonPropertyName("batch_number")]
    [JsonRequired]
    public string BatchNumber { get; set; }

    /// <summary>
    /// A string that uniquely identifies the external batch
    /// </summary>
    /// <value>A string that uniquely identifies the external batch</value>
    [JsonPropertyName("external_batch_id")]
    [JsonRequired]
    public string ExternalBatchId { get; set; }

    /// <summary>
    /// Custom notes you can add for each created batch
    /// </summary>
    /// <value>Custom notes you can add for each created batch</value>
    /// <example>
    /// Batch for morning shipment
    /// </example>
    [JsonPropertyName("batch_notes")]
    [JsonRequired]
    public string BatchNotes { get; set; }

    /// <summary>
    /// The date and time the batch was created in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was created in ShipEngine</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at")]
    [JsonRequired]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The date and time the batch was processed in ShipEngine
    /// </summary>
    /// <value>The date and time the batch was processed in ShipEngine</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("processed_at")]
    [JsonRequired]
    public DateTimeOffset ProcessedAt { get; set; }

    /// <summary>
    /// The number of errors that occurred while generating the batch
    /// </summary>
    /// <value>The number of errors that occurred while generating the batch</value>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public int Errors { get; set; }

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("process_errors")]
    [JsonRequired]
    public List<Error> ProcessErrors { get; set; }

    /// <summary>
    /// The number of warnings that occurred while generating the batch
    /// </summary>
    /// <value>The number of warnings that occurred while generating the batch</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("warnings")]
    [JsonRequired]
    public int Warnings { get; set; }

    /// <summary>
    /// The number of labels generated in the batch
    /// </summary>
    /// <value>The number of labels generated in the batch</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("completed")]
    [JsonRequired]
    public int Completed { get; set; }

    /// <summary>
    /// The number of forms for customs that are available for download
    /// </summary>
    /// <value>The number of forms for customs that are available for download</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("forms")]
    [JsonRequired]
    public int Forms { get; set; }

    /// <summary>
    /// The total of errors, warnings, and completed properties
    /// </summary>
    /// <value>The total of errors, warnings, and completed properties</value>
    /// <example>
    /// 2
    /// </example>
    [JsonPropertyName("count")]
    [JsonRequired]
    public int Count { get; set; }

    /// <summary>
    /// The batch shipments endpoint
    /// </summary>
    /// <value>The batch shipments endpoint</value>
    [JsonPropertyName("batch_shipments_url")]
    [JsonRequired]
    public OptionalLink BatchShipmentsUrl { get; set; }

    /// <summary>
    /// Link to batch labels query
    /// </summary>
    /// <value>Link to batch labels query</value>
    [JsonPropertyName("batch_labels_url")]
    [JsonRequired]
    public OptionalLink BatchLabelsUrl { get; set; }

    /// <summary>
    /// Link to batch errors endpoint
    /// </summary>
    /// <value>Link to batch errors endpoint</value>
    [JsonPropertyName("batch_errors_url")]
    [JsonRequired]
    public OptionalLink BatchErrorsUrl { get; set; }

    /// <summary>
    /// The label download for the batch
    /// </summary>
    /// <value>The label download for the batch</value>
    [JsonPropertyName("label_download")]
    [JsonRequired]
    public LabelDownload LabelDownload { get; set; }

    /// <summary>
    /// The form download for any customs that are needed
    /// </summary>
    /// <value>The form download for any customs that are needed</value>
    [JsonPropertyName("form_download")]
    [JsonRequired]
    public OptionalLink FormDownload { get; set; }

    /// <summary>
    /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.
    /// </summary>
    /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.</value>
    [JsonPropertyName("paperless_download")]
    [JsonRequired]
    public PaperlessDownload PaperlessDownload { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Batch {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
        sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
        sb.Append("  BatchId: ").Append(BatchId).Append("\n");
        sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
        sb.Append("  ExternalBatchId: ").Append(ExternalBatchId).Append("\n");
        sb.Append("  BatchNotes: ").Append(BatchNotes).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  ProcessErrors: ").Append(ProcessErrors).Append("\n");
        sb.Append("  Warnings: ").Append(Warnings).Append("\n");
        sb.Append("  Completed: ").Append(Completed).Append("\n");
        sb.Append("  Forms: ").Append(Forms).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  BatchShipmentsUrl: ").Append(BatchShipmentsUrl).Append("\n");
        sb.Append("  BatchLabelsUrl: ").Append(BatchLabelsUrl).Append("\n");
        sb.Append("  BatchErrorsUrl: ").Append(BatchErrorsUrl).Append("\n");
        sb.Append("  LabelDownload: ").Append(LabelDownload).Append("\n");
        sb.Append("  FormDownload: ").Append(FormDownload).Append("\n");
        sb.Append("  PaperlessDownload: ").Append(PaperlessDownload).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
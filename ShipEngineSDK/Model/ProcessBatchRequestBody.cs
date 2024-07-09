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
/// A process batch request body
/// </summary>
//[DataContract(Name = "process_batch_request_body")]
public partial class ProcessBatchRequestBody
{

    /// <summary>
    /// Gets or Sets LabelLayout  CLOVUS
    /// </summary>
    [JsonPropertyName("label_layout")]
    public LabelLayout? LabelLayout { get; set; }
    /// <summary>
    /// Gets or Sets LabelFormat  CLOVUS
    /// </summary>
    [JsonPropertyName("label_format")]
    public LabelFormat? LabelFormat { get; set; }
    /// <summary>
    /// The display format that the label should be shown in.  CLOVUS
    /// </summary>
    /// <value>The display format that the label should be shown in.</value>
    [JsonPropertyName("display_scheme")]
    public DisplayScheme? DisplayScheme { get; set; }
    /// <summary>
    /// The Ship date the batch is being processed for
    /// </summary>
    /// <value>The Ship date the batch is being processed for</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    public DateTime ShipDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ProcessBatchRequestBody {\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
        sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
        sb.Append("  DisplayScheme: ").Append(DisplayScheme).Append("\n");
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
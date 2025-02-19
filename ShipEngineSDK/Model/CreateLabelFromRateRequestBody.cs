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
/// A purchase label without shipment request body
/// </summary>
public partial class CreateLabelFromRateRequestBody
{

    /// <summary>
    /// Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field1
    /// </summary>
    /// <value>Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field1</value>
    [JsonPropertyName("custom_field1"), JsonPropertyOrder(1)]
    public string? CustomField1 { get; set; }

    /// <summary>
    /// Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field2
    /// </summary>
    /// <value>Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field2</value>
    [JsonPropertyName("custom_field2"), JsonPropertyOrder(2)]
    public string? CustomField2 { get; set; }

    /// <summary>
    /// Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field3
    /// </summary>
    /// <value>Optional - Value will be saved in the shipment&#39;s advanced_options &gt; custom_field3</value>
    [JsonPropertyName("custom_field3"), JsonPropertyOrder(3)]
    public string? CustomField3 { get; set; }

    /// <summary>
    /// The display format that the label should be shown in.
    /// </summary>
    /// <value>The display format that the label should be shown in.</value>
    [JsonPropertyName("display_scheme"), JsonPropertyOrder(4)]
    public DisplayScheme? DisplayScheme { get; set; }

    /// <summary>
    /// Gets or Sets LabelDownloadType
    /// </summary>
    [JsonPropertyName("label_download_type"), JsonPropertyOrder(5)]
    public LabelDownloadType? LabelDownloadType { get; set; }

    /// <summary>
    /// Gets or Sets LabelFormat
    /// </summary>
    [JsonPropertyName("label_format"), JsonPropertyOrder(6)]
    public LabelFormat? LabelFormat { get; set; }

    /// <summary>
    /// Gets or Sets LabelLayout
    /// </summary>
    [JsonPropertyName("label_layout"), JsonPropertyOrder(7)]
    public LabelLayout? LabelLayout { get; set; }

    /// <summary>
    /// Gets or Sets ValidateAddress
    /// </summary>
    [JsonPropertyName("validate_address"), JsonPropertyOrder(8)]
    public ValidateAddress? ValidateAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateLabelFromRateRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CustomField1: ").Append(CustomField1).Append("\n");
        sb.Append("  CustomField2: ").Append(CustomField2).Append("\n");
        sb.Append("  CustomField3: ").Append(CustomField3).Append("\n");
        sb.Append("  DisplayScheme: ").Append(DisplayScheme).Append("\n");
        sb.Append("  LabelDownloadType: ").Append(LabelDownloadType).Append("\n");
        sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
        sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
        sb.Append("  ValidateAddress: ").Append(ValidateAddress).Append("\n");
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
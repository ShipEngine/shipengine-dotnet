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
/// A batch response error
/// </summary>
public partial class BatchResponseError
{

    /// <summary>
    /// Error message associated with the shipment.
    /// </summary>
    /// <value>Error message associated with the shipment.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// Recipient address has not been verified.
    /// </example>
    [JsonPropertyName("error"), JsonInclude]
    public string? Error { get; set; }

    /// <summary>
    /// An external shipment id associated with the shipment
    /// </summary>
    /// <value>An external shipment id associated with the shipment</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("external_shipment_id"), JsonInclude]
    public string? ExternalShipmentId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the shipment
    /// </summary>
    /// <value>A string that uniquely identifies the shipment</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_id"), JsonInclude]
    public string? ShipmentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchResponseError {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  ExternalShipmentId: ").Append(ExternalShipmentId).Append("\n");
        sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
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
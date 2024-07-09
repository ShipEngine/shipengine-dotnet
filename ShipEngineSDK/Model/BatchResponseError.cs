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
/// A batch response error
/// </summary>
//[DataContract(Name = "batch_response_error")]
public partial class BatchResponseError
{

    /// <summary>
    /// Error message associated with the shipment.
    /// </summary>
    /// <value>Error message associated with the shipment.</value>
    /// <example>
    /// Recipient address has not been verified.
    /// </example>
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// A string that uniquely identifies the shipment
    /// </summary>
    /// <value>A string that uniquely identifies the shipment</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_id")]
    public string ShipmentId { get; set; }

    /// <summary>
    /// An external shipment id associated with the shipment
    /// </summary>
    /// <value>An external shipment id associated with the shipment</value>
    [JsonPropertyName("external_shipment_id")]
    public string ExternalShipmentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BatchResponseError {\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
        sb.Append("  ExternalShipmentId: ").Append(ExternalShipmentId).Append("\n");
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
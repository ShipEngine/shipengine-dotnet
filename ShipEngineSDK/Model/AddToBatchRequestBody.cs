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
/// An add to batch request body
/// </summary>
public partial class AddToBatchRequestBody
{

    /// <summary>
    /// Array of Rate IDs to be modifed on the batch
    /// </summary>
    /// <value>Array of Rate IDs to be modifed on the batch</value>
    [JsonPropertyName("rate_ids")]
    public List<string>? RateIds { get; set; }

    /// <summary>
    /// The Shipment Ids to be modified on the batch
    /// </summary>
    /// <value>The Shipment Ids to be modified on the batch</value>
    [JsonPropertyName("shipment_ids")]
    public List<string>? ShipmentIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AddToBatchRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  RateIds: ").Append(RateIds).Append("\n");
        sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
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
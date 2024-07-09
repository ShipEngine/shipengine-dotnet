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
/// UpdateShipmentsTagsShipmentsTagsInner
/// </summary>
public partial class UpdateShipmentsTagsShipmentsTagsInner
{

    /// <summary>
    /// Gets or Sets ShipmentId
    /// </summary>
    [JsonPropertyName("shipment_id")]
    public string ShipmentId { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UpdateShipmentsTagsShipmentsTagsInner {\n");
        sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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
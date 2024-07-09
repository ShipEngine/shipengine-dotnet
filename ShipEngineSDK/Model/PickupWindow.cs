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
/// The desired time range for the package pickup.
/// </summary>
public partial class PickupWindow
{

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("start_at")]
    [JsonRequired]
    public DateTime StartAt { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("end_at")]
    [JsonRequired]
    public DateTime EndAt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PickupWindow {\n");
        sb.Append("  StartAt: ").Append(StartAt).Append("\n");
        sb.Append("  EndAt: ").Append(EndAt).Append("\n");
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
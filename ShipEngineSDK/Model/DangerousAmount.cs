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
/// This model represents the amount of the dangerous goods..
/// </summary>
public partial class DangerousAmount
{

    /// <summary>
    /// The amount of dangerous goods.
    /// </summary>
    /// <value>The amount of dangerous goods.</value>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// The unit of dangerous goods.
    /// </summary>
    /// <value>The unit of dangerous goods.</value>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DangerousAmount {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Amount: ").Append(Amount).Append("\n");
        sb.Append("  Unit: ").Append(Unit).Append("\n");
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
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
/// ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner
/// </summary>
public partial class ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner
{

    /// <summary>
    /// Closing time
    /// </summary>
    /// <value>Closing time</value>
    /// <example>
    /// 12:00
    /// </example>
    [JsonPropertyName("close"), JsonPropertyOrder(1)]
    public string? Close { get; set; }

    /// <summary>
    /// Opening time
    /// </summary>
    /// <value>Opening time</value>
    /// <example>
    /// 09:15
    /// </example>
    [JsonPropertyName("open"), JsonPropertyOrder(2)]
    public string? Open { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Close: ").Append(Close).Append("\n");
        sb.Append("  Open: ").Append(Open).Append("\n");
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
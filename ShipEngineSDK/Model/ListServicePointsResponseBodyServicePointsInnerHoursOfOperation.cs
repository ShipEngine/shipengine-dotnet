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
/// Hours of operation
/// </summary>
public partial class ListServicePointsResponseBodyServicePointsInnerHoursOfOperation
{

    /// <summary>
    /// Gets or Sets Friday
    /// </summary>
    [JsonPropertyName("friday"), JsonPropertyOrder(1)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Friday { get; set; }

    /// <summary>
    /// Gets or Sets Monday
    /// </summary>
    [JsonPropertyName("monday"), JsonPropertyOrder(2)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Monday { get; set; }

    /// <summary>
    /// Gets or Sets Saturday
    /// </summary>
    [JsonPropertyName("saturday"), JsonPropertyOrder(3)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Saturday { get; set; }

    /// <summary>
    /// Gets or Sets Sunday
    /// </summary>
    [JsonPropertyName("sunday"), JsonPropertyOrder(4)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Sunday { get; set; }

    /// <summary>
    /// Gets or Sets Thursday
    /// </summary>
    [JsonPropertyName("thursday"), JsonPropertyOrder(5)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Thursday { get; set; }

    /// <summary>
    /// Gets or Sets Tuesday
    /// </summary>
    [JsonPropertyName("tuesday"), JsonPropertyOrder(6)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Tuesday { get; set; }

    /// <summary>
    /// Gets or Sets Wednesday
    /// </summary>
    [JsonPropertyName("wednesday"), JsonPropertyOrder(7)]
    public List<ListServicePointsResponseBodyServicePointsInnerHoursOfOperationMondayInner>? Wednesday { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ListServicePointsResponseBodyServicePointsInnerHoursOfOperation {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Friday: ").Append(Friday).Append("\n");
        sb.Append("  Monday: ").Append(Monday).Append("\n");
        sb.Append("  Saturday: ").Append(Saturday).Append("\n");
        sb.Append("  Sunday: ").Append(Sunday).Append("\n");
        sb.Append("  Thursday: ").Append(Thursday).Append("\n");
        sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
        sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
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
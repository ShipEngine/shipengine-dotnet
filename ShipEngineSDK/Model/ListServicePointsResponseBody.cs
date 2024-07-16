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
/// A list service points response body
/// </summary>
public partial class ListServicePointsResponseBody
{

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("errors")]
    public List<Error>? Errors { get; set; }

    /// <summary>
    /// The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 48.842608
    /// </example>
    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 0.032875
    /// </example>
    [JsonPropertyName("long")]
    public double? Long { get; set; }

    /// <summary>
    /// Gets or Sets ServicePoints
    /// </summary>
    [JsonPropertyName("service_points")]
    public List<ListServicePointsResponseBodyServicePointsInner>? ServicePoints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ListServicePointsResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Lat: ").Append(Lat).Append("\n");
        sb.Append("  Long: ").Append(Long).Append("\n");
        sb.Append("  ServicePoints: ").Append(ServicePoints).Append("\n");
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
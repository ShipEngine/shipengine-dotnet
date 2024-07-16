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
/// The dimensions of a package
/// </summary>
public partial class Dimensions
{

    /// <summary>
    /// Gets or Sets Unit  CLOVUS
    /// </summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required DimensionUnit Unit { get; set; } = new();


    /// <summary>
    /// The height of the package, in the specified unit
    /// </summary>
    /// <value>The height of the package, in the specified unit</value>
    [JsonPropertyName("height")]
    [JsonRequired]
    public required double Height { get; set; }

    /// <summary>
    /// The length of the package, in the specified unit
    /// </summary>
    /// <value>The length of the package, in the specified unit</value>
    [JsonPropertyName("length")]
    [JsonRequired]
    public required double Length { get; set; }

    /// <summary>
    /// The width of the package, in the specified unit
    /// </summary>
    /// <value>The width of the package, in the specified unit</value>
    [JsonPropertyName("width")]
    [JsonRequired]
    public required double Width { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Dimensions {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Unit: ").Append(Unit).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
        sb.Append("  Length: ").Append(Length).Append("\n");
        sb.Append("  Width: ").Append(Width).Append("\n");
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
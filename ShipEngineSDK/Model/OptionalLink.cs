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
/// A link to a related resource, or an empty object if there is no resource to link to
/// </summary>
public partial class OptionalLink
{

    /// <summary>
    /// The URL of the linked resource, if any
    /// </summary>
    /// <value>The URL of the linked resource, if any</value>
    /// <example>
    /// http://api.shipengine.com/v1/labels/se-28529731
    /// </example>
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    /// <summary>
    /// The type of resource, or the type of relationship to the parent resource
    /// </summary>
    /// <value>The type of resource, or the type of relationship to the parent resource</value>
    [JsonPropertyName("type")]
    public string? Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class OptionalLink {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Href: ").Append(Href).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
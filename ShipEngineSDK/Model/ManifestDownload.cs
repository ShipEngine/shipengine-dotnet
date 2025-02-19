// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


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
/// Object containing the href link to download the manifest file
/// </summary>
public partial class ManifestDownload
{

    /// <summary>
    /// The URL of the linked resource, if any
    /// </summary>
    /// <value>The URL of the linked resource, if any</value>
    /// <example>
    /// http://api.shipengine.com/v1/labels/se-28529731
    /// </example>
    [JsonPropertyName("href"), JsonPropertyOrder(1)]
    public string? Href { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ManifestDownload {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Href: ").Append(Href).Append("\n");
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
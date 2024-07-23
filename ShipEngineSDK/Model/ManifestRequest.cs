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
/// A reference to the manifest request
/// </summary>
public partial class ManifestRequest
{

    /// <summary>
    /// A string that uniquely identifies a manifest request
    /// </summary>
    /// <value>A string that uniquely identifies a manifest request</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("manifest_request_id"), JsonInclude]
    public string? ManifestRequestId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status"), JsonPropertyOrder(2)]
    public ManifestRequestStatus? Status { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ManifestRequest {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  ManifestRequestId: ").Append(ManifestRequestId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
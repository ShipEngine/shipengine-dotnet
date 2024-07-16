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
/// A reference to the manifest request
/// </summary>
public partial class ManifestRequest
{

    /// <summary>
    /// Gets or Sets Status  CLOVUS
    /// </summary>
    [JsonPropertyName("status")]
    public ManifestRequestStatus? Status { get; set; }
    /// <summary>
    /// A string that uniquely identifies a manifest request
    /// </summary>
    /// <value>A string that uniquely identifies a manifest request</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("manifest_request_id")]
    public string ManifestRequestId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
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
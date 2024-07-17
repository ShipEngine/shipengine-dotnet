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
/// A create package type request body
/// </summary>
public partial class CreatePackageTypeRequestBody
{

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    /// <example>
    /// laptop_box
    /// </example>
    [JsonPropertyName("name"), JsonRequired, JsonPropertyOrder(1)]
    public required string Name { get; set; }

    /// <summary>
    /// A [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  Use the code &#x60;package&#x60; for custom or unknown package types. 
    /// </summary>
    /// <value>A [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  Use the code &#x60;package&#x60; for custom or unknown package types. </value>
    /// <example>
    /// small_flat_rate_box
    /// </example>
    [JsonPropertyName("package_code"), JsonRequired, JsonPropertyOrder(2)]
    public required string PackageCode { get; set; }

    /// <summary>
    /// Provides a helpful description for the custom package.
    /// </summary>
    /// <value>Provides a helpful description for the custom package.</value>
    /// <example>
    /// Packaging for laptops
    /// </example>
    [JsonPropertyName("description"), JsonPropertyOrder(3)]
    public string? Description { get; set; }

    /// <summary>
    /// The custom dimensions for the package.
    /// </summary>
    /// <value>The custom dimensions for the package.</value>
    [JsonPropertyName("dimensions"), JsonPropertyOrder(4)]
    public Dimensions? Dimensions { get; set; }

    /// <summary>
    /// A string that uniquely identifies the package.
    /// </summary>
    /// <value>A string that uniquely identifies the package.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("package_id"), JsonPropertyOrder(5)]
    public string? PackageId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreatePackageTypeRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
        sb.Append("  PackageId: ").Append(PackageId).Append("\n");
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
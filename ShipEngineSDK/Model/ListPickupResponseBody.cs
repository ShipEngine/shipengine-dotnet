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
/// A list pickup response body
/// </summary>
public partial class ListPickupResponseBody
{

    /// <summary>
    /// Helpful links to other pages of results
    /// </summary>
    /// <value>Helpful links to other pages of results</value>
    [JsonPropertyName("links"), JsonInclude]
    public PaginationLink? Links { get; private set; }

    /// <summary>
    /// Current page of the list pickups results
    /// </summary>
    /// <value>Current page of the list pickups results</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("page"), JsonInclude]
    public int? Page { get; private set; }

    /// <summary>
    /// Total number of pages for list pickups results
    /// </summary>
    /// <value>Total number of pages for list pickups results</value>
    /// <example>
    /// 4
    /// </example>
    [JsonPropertyName("pages"), JsonInclude]
    public int? Pages { get; private set; }

    /// <summary>
    /// An array of pickups associated with the user&#39;s account.
    /// </summary>
    /// <value>An array of pickups associated with the user&#39;s account.</value>
    [JsonPropertyName("pickups"), JsonPropertyOrder(4)]
    public required List<Pickup> Pickups { get; set; }

    /// <summary>
    /// The total number of pickups returned
    /// </summary>
    /// <value>The total number of pickups returned</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("total"), JsonInclude]
    public long? Total { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ListPickupResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
        sb.Append("  Pickups: ").Append(Pickups).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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
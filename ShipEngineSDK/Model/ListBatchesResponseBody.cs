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
/// A list batch response body
/// </summary>
public partial class ListBatchesResponseBody
{

    /// <summary>
    /// Batch List
    /// </summary>
    /// <value>Batch List</value>
    [JsonPropertyName("batches"), JsonInclude]
    public List<Batch>? Batches { get; private set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [JsonPropertyName("links"), JsonInclude]
    public PaginationLink? Links { get; private set; }

    /// <summary>
    /// The page that is currently being read
    /// </summary>
    /// <value>The page that is currently being read</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("page"), JsonInclude]
    public int? Page { get; private set; }

    /// <summary>
    /// The total number of batch pages the API call returned
    /// </summary>
    /// <value>The total number of batch pages the API call returned</value>
    /// <example>
    /// 10
    /// </example>
    [JsonPropertyName("pages"), JsonInclude]
    public int? Pages { get; private set; }

    /// <summary>
    /// The total number of batches the API call returned
    /// </summary>
    /// <value>The total number of batches the API call returned</value>
    /// <example>
    /// 10
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
        sb.Append("class ListBatchesResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Batches: ").Append(Batches).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
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
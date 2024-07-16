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
/// GetPickupsResponseBody
/// </summary>
public partial class GetPickupsResponseBody
{

    /// <summary>
    /// An array of pickups associated with the user&#39;s account.
    /// </summary>
    /// <value>An array of pickups associated with the user&#39;s account.</value>
    [JsonPropertyName("pickups")]
    [JsonRequired]
    public List<Pickup> Pickups { get; set; }

    /// <summary>
    /// The total number of pickups returned
    /// </summary>
    /// <value>The total number of pickups returned</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("total")]
    [JsonRequired]
    public long Total { get; set; }

    /// <summary>
    /// Current page of the list pickups results
    /// </summary>
    /// <value>Current page of the list pickups results</value>
    /// <example>
    /// 3
    /// </example>
    [JsonPropertyName("page")]
    [JsonRequired]
    public int Page { get; set; }

    /// <summary>
    /// Total number of pages for list pickups results
    /// </summary>
    /// <value>Total number of pages for list pickups results</value>
    /// <example>
    /// 4
    /// </example>
    [JsonPropertyName("pages")]
    [JsonRequired]
    public int Pages { get; set; }

    /// <summary>
    /// Helpful links to other pages of results
    /// </summary>
    /// <value>Helpful links to other pages of results</value>
    [JsonPropertyName("links")]
    [JsonRequired]
    public PaginationLink Links { get; set; }

    /// <summary>
    /// A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur 
    /// </summary>
    /// <value>A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur </value>
    /// <example>
    /// aa3d8e8e-462b-4476-9618-72db7f7b7009
    /// </example>
    [JsonPropertyName("request_id")]
    [JsonRequired]
    public Guid RequestId { get; set; }

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public List<Error> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetPickupsResponseBody {\n");
        sb.Append("  Pickups: ").Append(Pickups).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
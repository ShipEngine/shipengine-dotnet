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
/// DeletePickupByIdResponseBody
/// </summary>
public partial class DeletePickupByIdResponseBody
{

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public required List<Error> Errors { get; set; }

    /// <summary>
    /// Pickup Resource ID
    /// </summary>
    /// <value>Pickup Resource ID</value>
    /// <example>
    /// pik_3YcKU5zdtJuCqoeNwyqqbW
    /// </example>
    [JsonPropertyName("pickup_id")]
    [JsonRequired]
    public required string PickupId { get; set; }

    /// <summary>
    /// A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur 
    /// </summary>
    /// <value>A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur </value>
    /// <example>
    /// aa3d8e8e-462b-4476-9618-72db7f7b7009
    /// </example>
    [JsonPropertyName("request_id")]
    [JsonRequired]
    public required Guid RequestId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DeletePickupByIdResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  PickupId: ").Append(PickupId).Append("\n");
        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
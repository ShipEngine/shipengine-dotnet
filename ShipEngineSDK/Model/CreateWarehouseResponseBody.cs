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
/// A create warehouse response body
/// </summary>
public partial class CreateWarehouseResponseBody
{

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id")]
    [JsonRequired]
    public string WarehouseId { get; set; }

    /// <summary>
    /// Designates which single warehouse is the default on the account
    /// </summary>
    /// <value>Designates which single warehouse is the default on the account</value>
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Name of the warehouse
    /// </summary>
    /// <value>Name of the warehouse</value>
    /// <example>
    /// Zero Cool HQ
    /// </example>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; }

    /// <summary>
    /// Timestamp that indicates when the warehouse was created
    /// </summary>
    /// <value>Timestamp that indicates when the warehouse was created</value>
    /// <example>
    /// 2019-06-25T18:12:35.583Z
    /// </example>
    [JsonPropertyName("created_at")]
    [JsonRequired]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The origin address of the warehouse
    /// </summary>
    /// <value>The origin address of the warehouse</value>
    [JsonPropertyName("origin_address")]
    [JsonRequired]
    public Address OriginAddress { get; set; }

    /// <summary>
    /// The return address associated with the warehouse
    /// </summary>
    /// <value>The return address associated with the warehouse</value>
    [JsonPropertyName("return_address")]
    [JsonRequired]
    public Address ReturnAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateWarehouseResponseBody {\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  OriginAddress: ").Append(OriginAddress).Append("\n");
        sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
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
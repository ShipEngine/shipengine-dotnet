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
/// A create warehouse request body
/// </summary>
public partial class CreateWarehouseRequestBody
{

    /// <summary>
    /// Name of the warehouse
    /// </summary>
    /// <value>Name of the warehouse</value>
    /// <example>
    /// Zero Cool HQ
    /// </example>
    [JsonPropertyName("name"), JsonPropertyOrder(1)]
    public required string Name { get; set; }

    /// <summary>
    /// The origin address of the warehouse
    /// </summary>
    /// <value>The origin address of the warehouse</value>
    [JsonPropertyName("origin_address"), JsonPropertyOrder(2)]
    public required Address OriginAddress { get; set; }

    /// <summary>
    /// Timestamp that indicates when the warehouse was created
    /// </summary>
    /// <value>Timestamp that indicates when the warehouse was created</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2019-06-25T18:12:35.583Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// Designates which single warehouse is the default on the account
    /// </summary>
    /// <value>Designates which single warehouse is the default on the account</value>
    [JsonPropertyName("is_default"), JsonPropertyOrder(4)]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// The return address associated with the warehouse
    /// </summary>
    /// <value>The return address associated with the warehouse</value>
    [JsonPropertyName("return_address"), JsonPropertyOrder(5)]
    public Address? ReturnAddress { get; set; }

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id"), JsonInclude]
    public string? WarehouseId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWarehouseRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  OriginAddress: ").Append(OriginAddress).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
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
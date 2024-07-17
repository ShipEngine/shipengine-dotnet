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
/// A DHL Express account settings
/// </summary>
public partial class DhlExpressAccountSettings
{

    /// <summary>
    /// Indicates if this is primary account
    /// </summary>
    /// <value>Indicates if this is primary account</value>
    [JsonPropertyName("is_primary_account"), JsonPropertyOrder(1)]
    public bool? IsPrimaryAccount { get; set; }

    /// <summary>
    /// Account nickname
    /// </summary>
    /// <value>Account nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(2)]
    public string? Nickname { get; set; }

    /// <summary>
    /// Indicates if the account number should be hidden on the archive documentation
    /// </summary>
    /// <value>Indicates if the account number should be hidden on the archive documentation</value>
    [JsonPropertyName("should_hide_account_number_on_archive_doc"), JsonPropertyOrder(3)]
    public bool? ShouldHideAccountNumberOnArchiveDoc { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DhlExpressAccountSettings {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  IsPrimaryAccount: ").Append(IsPrimaryAccount).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  ShouldHideAccountNumberOnArchiveDoc: ").Append(ShouldHideAccountNumberOnArchiveDoc).Append("\n");
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
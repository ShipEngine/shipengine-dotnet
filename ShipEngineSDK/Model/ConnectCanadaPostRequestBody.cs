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
/// A Canada Post account information request body
/// </summary>
public partial class ConnectCanadaPostRequestBody
{

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public string Nickname { get; set; }

    /// <summary>
    /// Canada Post Account API Key
    /// </summary>
    /// <value>Canada Post Account API Key</value>
    [JsonPropertyName("api_key")]
    [JsonRequired]
    public string ApiKey { get; set; }

    /// <summary>
    /// Canada Post Account API Secret
    /// </summary>
    /// <value>Canada Post Account API Secret</value>
    [JsonPropertyName("api_secret")]
    [JsonRequired]
    public string ApiSecret { get; set; }

    /// <summary>
    /// Canada Post Account Number
    /// </summary>
    /// <value>Canada Post Account Number</value>
    [JsonPropertyName("account_number")]
    [JsonRequired]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Canada Post Account Contract ID
    /// </summary>
    /// <value>Canada Post Account Contract ID</value>
    [JsonPropertyName("contract_id")]
    [JsonRequired]
    public string ContractId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectCanadaPostRequestBody {\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
        sb.Append("  ApiSecret: ").Append(ApiSecret).Append("\n");
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  ContractId: ").Append(ContractId).Append("\n");
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
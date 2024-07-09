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
/// A Purolator account information request body
/// </summary>
public partial class ConnectPurolatorRequestBody
{

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number")]
    [JsonRequired]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Activation key
    /// </summary>
    /// <value>Activation key</value>
    [JsonPropertyName("activation_key")]
    [JsonRequired]
    public string ActivationKey { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public string Nickname { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectPurolatorRequestBody {\n");
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  ActivationKey: ").Append(ActivationKey).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
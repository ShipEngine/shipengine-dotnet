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
/// An Ontrac account information request body
/// </summary>
public partial class ConnectOntracRequestBody
{

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number"), JsonPropertyOrder(1)]
    public required string AccountNumber { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(2)]
    public required string Nickname { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    /// <value>Password</value>
    [JsonPropertyName("password"), JsonPropertyOrder(3)]
    public required string Password { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectOntracRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
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
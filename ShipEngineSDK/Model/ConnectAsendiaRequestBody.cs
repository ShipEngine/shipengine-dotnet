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
/// An Asendia account information request body
/// </summary>
public partial class ConnectAsendiaRequestBody
{

    /// <summary>
    /// Asendia account number
    /// </summary>
    /// <value>Asendia account number</value>
    [JsonPropertyName("account_number")]
    [JsonRequired]
    public string AccountNumber { get; set; }

    /// <summary>
    /// FTP password
    /// </summary>
    /// <value>FTP password</value>
    [JsonPropertyName("ftp_password")]
    [JsonRequired]
    public string FtpPassword { get; set; }

    /// <summary>
    /// FTP username
    /// </summary>
    /// <value>FTP username</value>
    [JsonPropertyName("ftp_username")]
    [JsonRequired]
    public string FtpUsername { get; set; }

    /// <summary>
    /// The nickname of the Asendia account
    /// </summary>
    /// <value>The nickname of the Asendia account</value>
    /// <example>
    /// Asendia account
    /// </example>
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
        sb.Append("class ConnectAsendiaRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  FtpPassword: ").Append(FtpPassword).Append("\n");
        sb.Append("  FtpUsername: ").Append(FtpUsername).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
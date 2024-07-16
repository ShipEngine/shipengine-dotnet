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
/// An APC account information request body
/// </summary>
public partial class ConnectApcRequestBody
{

    /// <summary>
    /// The nickname for the APC account
    /// </summary>
    /// <value>The nickname for the APC account</value>
    /// <example>
    /// APC carrier account
    /// </example>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public string Nickname { get; set; }

    /// <summary>
    /// The username for the APC account
    /// </summary>
    /// <value>The username for the APC account</value>
    /// <example>
    /// john_doe
    /// </example>
    [JsonPropertyName("username")]
    [JsonRequired]
    public string Username { get; set; }

    /// <summary>
    /// The password for the APC account
    /// </summary>
    /// <value>The password for the APC account</value>
    /// <example>
    /// 12345
    /// </example>
    [JsonPropertyName("password")]
    [JsonRequired]
    public string Password { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectApcRequestBody {\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
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
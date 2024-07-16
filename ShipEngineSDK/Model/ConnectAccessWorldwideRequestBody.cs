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
/// An Access Worldwide account information request body
/// </summary>
public partial class ConnectAccessWorldwideRequestBody
{

    /// <summary>
    /// The nickname associated with the carrier connection
    /// </summary>
    /// <value>The nickname associated with the carrier connection</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public string Nickname { get; set; }

    /// <summary>
    /// Access Worldwide Username
    /// </summary>
    /// <value>Access Worldwide Username</value>
    [JsonPropertyName("username")]
    [JsonRequired]
    public string Username { get; set; }

    /// <summary>
    /// Access Worldwide Password
    /// </summary>
    /// <value>Access Worldwide Password</value>
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
        sb.Append("class ConnectAccessWorldwideRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
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
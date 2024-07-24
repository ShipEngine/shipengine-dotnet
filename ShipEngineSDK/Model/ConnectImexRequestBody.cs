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
/// An Imex account information request body
/// </summary>
public partial class ConnectImexRequestBody
{

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(1)]
    public required string Nickname { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    /// <value>Password</value>
    [JsonPropertyName("password"), JsonPropertyOrder(2)]
    public required string Password { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    /// <value>Username</value>
    [JsonPropertyName("username"), JsonPropertyOrder(3)]
    public required string Username { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectImexRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
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
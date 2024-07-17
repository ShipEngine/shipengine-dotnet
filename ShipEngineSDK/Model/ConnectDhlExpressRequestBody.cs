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
/// A DHL express account information request body
/// </summary>
public partial class ConnectDhlExpressRequestBody
{

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number"), JsonRequired, JsonPropertyOrder(1)]
    public required string AccountNumber { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonRequired, JsonPropertyOrder(2)]
    public required string Nickname { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code"), JsonPropertyOrder(3)]
    public string? CountryCode { get; set; }

    /// <summary>
    /// Required if site id is provided
    /// </summary>
    /// <value>Required if site id is provided</value>
    [JsonPropertyName("password"), JsonPropertyOrder(4)]
    public string? Password { get; set; }

    /// <summary>
    /// Required if password is provided
    /// </summary>
    /// <value>Required if password is provided</value>
    [JsonPropertyName("site_id"), JsonPropertyOrder(5)]
    public string? SiteId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectDhlExpressRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  SiteId: ").Append(SiteId).Append("\n");
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
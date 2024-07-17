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
/// A Royal Mail account information request body
/// </summary>
public partial class ConnectRoyalMailRequestBody
{

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number"), JsonRequired, JsonPropertyOrder(1)]
    public required string AccountNumber { get; set; }

    /// <summary>
    /// City
    /// </summary>
    /// <value>City</value>
    [JsonPropertyName("city"), JsonRequired, JsonPropertyOrder(2)]
    public required string City { get; set; }

    /// <summary>
    /// Contact name
    /// </summary>
    /// <value>Contact name</value>
    [JsonPropertyName("contact_name"), JsonRequired, JsonPropertyOrder(3)]
    public required string ContactName { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonRequired, JsonPropertyOrder(4)]
    public required string Nickname { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    [JsonPropertyName("postal_code"), JsonRequired, JsonPropertyOrder(5)]
    public required string PostalCode { get; set; }

    /// <summary>
    /// Company name
    /// </summary>
    /// <value>Company name</value>
    [JsonPropertyName("company_name"), JsonPropertyOrder(6)]
    public string? CompanyName { get; set; }

    /// <summary>
    /// The email address
    /// </summary>
    /// <value>The email address</value>
    /// <example>
    /// john.doe@example.com
    /// </example>
    [JsonPropertyName("email"), JsonPropertyOrder(7)]
    public string? Email { get; set; }

    /// <summary>
    /// The oba email address
    /// </summary>
    /// <value>The oba email address</value>
    /// <example>
    /// john.doe@example.com
    /// </example>
    [JsonPropertyName("oba_email"), JsonPropertyOrder(8)]
    public string? ObaEmail { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    /// <value>Phone</value>
    [JsonPropertyName("phone"), JsonPropertyOrder(9)]
    public string? Phone { get; set; }

    /// <summary>
    /// Street line1
    /// </summary>
    /// <value>Street line1</value>
    [JsonPropertyName("street_line1"), JsonPropertyOrder(10)]
    public string? StreetLine1 { get; set; }

    /// <summary>
    /// Street line2
    /// </summary>
    /// <value>Street line2</value>
    [JsonPropertyName("street_line2"), JsonPropertyOrder(11)]
    public string? StreetLine2 { get; set; }

    /// <summary>
    /// Street line3
    /// </summary>
    /// <value>Street line3</value>
    [JsonPropertyName("street_line3"), JsonPropertyOrder(12)]
    public string? StreetLine3 { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectRoyalMailRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  ContactName: ").Append(ContactName).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  ObaEmail: ").Append(ObaEmail).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
        sb.Append("  StreetLine1: ").Append(StreetLine1).Append("\n");
        sb.Append("  StreetLine2: ").Append(StreetLine2).Append("\n");
        sb.Append("  StreetLine3: ").Append(StreetLine3).Append("\n");
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
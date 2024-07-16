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
/// A Fedex UK account information request body
/// </summary>
public partial class ConnectFedexUkRequestBody
{

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number")]
    [JsonRequired]
    public required string AccountNumber { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    /// <value>Address</value>
    [JsonPropertyName("address1")]
    [JsonRequired]
    public required string Address1 { get; set; }

    /// <summary>
    /// Boolean signaling agreement to the Fedex End User License Agreement
    /// </summary>
    /// <value>Boolean signaling agreement to the Fedex End User License Agreement</value>
    [JsonPropertyName("agree_to_eula")]
    [JsonRequired]
    public required bool AgreeToEula { get; set; }

    /// <summary>
    /// The city
    /// </summary>
    /// <value>The city</value>
    [JsonPropertyName("city")]
    [JsonRequired]
    public required string City { get; set; }

    /// <summary>
    /// Country code
    /// </summary>
    /// <value>Country code</value>
    [JsonPropertyName("country_code")]
    [JsonRequired]
    public required string CountryCode { get; set; }

    /// <summary>
    /// The email address
    /// </summary>
    /// <value>The email address</value>
    /// <example>
    /// john.doe@example.com
    /// </example>
    [JsonPropertyName("email")]
    [JsonRequired]
    public required string Email { get; set; }

    /// <summary>
    /// First name
    /// </summary>
    /// <value>First name</value>
    [JsonPropertyName("first_name")]
    [JsonRequired]
    public required string FirstName { get; set; }

    /// <summary>
    /// Last name
    /// </summary>
    /// <value>Last name</value>
    [JsonPropertyName("last_name")]
    [JsonRequired]
    public required string LastName { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public required string Nickname { get; set; }

    /// <summary>
    /// Phone number
    /// </summary>
    /// <value>Phone number</value>
    [JsonPropertyName("phone")]
    [JsonRequired]
    public required string Phone { get; set; }

    /// <summary>
    /// Postal Code
    /// </summary>
    /// <value>Postal Code</value>
    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public required string PostalCode { get; set; }

    /// <summary>
    /// State
    /// </summary>
    /// <value>State</value>
    [JsonPropertyName("state")]
    [JsonRequired]
    public required string State { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    /// <value>Address</value>
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// The company
    /// </summary>
    /// <value>The company</value>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// Meter number
    /// </summary>
    /// <value>Meter number</value>
    [JsonPropertyName("meter_number")]
    public string? MeterNumber { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectFedexUkRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  Address1: ").Append(Address1).Append("\n");
        sb.Append("  AgreeToEula: ").Append(AgreeToEula).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Address2: ").Append(Address2).Append("\n");
        sb.Append("  Company: ").Append(Company).Append("\n");
        sb.Append("  MeterNumber: ").Append(MeterNumber).Append("\n");
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
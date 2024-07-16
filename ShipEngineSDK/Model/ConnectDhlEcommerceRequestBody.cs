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
/// A DHL Ecommerce account information request body
/// </summary>
public partial class ConnectDhlEcommerceRequestBody
{

    /// <summary>
    /// Gets or Sets AncillaryEndorsement  CLOVUS
    /// </summary>
    [JsonPropertyName("ancillary_endorsement")]
    public AncillaryServiceEndorsement? AncillaryEndorsement { get; set; }
    /// <summary>
    /// The client id
    /// </summary>
    /// <value>The client id</value>
    [JsonPropertyName("client_id")]
    [JsonRequired]
    public required string ClientId { get; set; }

    /// <summary>
    /// The distribution center
    /// </summary>
    /// <value>The distribution center</value>
    [JsonPropertyName("distribution_center")]
    [JsonRequired]
    public required string DistributionCenter { get; set; }

    /// <summary>
    /// A nickname to help you identify this account
    /// </summary>
    /// <value>A nickname to help you identify this account</value>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public required string Nickname { get; set; }

    /// <summary>
    /// The account password
    /// </summary>
    /// <value>The account password</value>
    [JsonPropertyName("password")]
    [JsonRequired]
    public required string Password { get; set; }

    /// <summary>
    /// The pickup number
    /// </summary>
    /// <value>The pickup number</value>
    [JsonPropertyName("pickup_number")]
    [JsonRequired]
    public required string PickupNumber { get; set; }

    /// <summary>
    /// The account username
    /// </summary>
    /// <value>The account username</value>
    [JsonPropertyName("username")]
    [JsonRequired]
    public required string Username { get; set; }

    /// <summary>
    /// Account number
    /// </summary>
    /// <value>Account number</value>
    [JsonPropertyName("account_number")]
    [Obsolete]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The DHL E-Commerce API key. This field is optional, but if not set you will not be able to get rates for this account. 
    /// </summary>
    /// <value>The DHL E-Commerce API key. This field is optional, but if not set you will not be able to get rates for this account. </value>
    [JsonPropertyName("api_key")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// The DHL E-Commerce API secret. This field is optional, but if not set you will not be able to get rates for this account. 
    /// </summary>
    /// <value>The DHL E-Commerce API secret. This field is optional, but if not set you will not be able to get rates for this account. </value>
    [JsonPropertyName("api_secret")]
    public string? ApiSecret { get; set; }

    /// <summary>
    /// FTP password
    /// </summary>
    /// <value>FTP password</value>
    [JsonPropertyName("ftp_password")]
    [Obsolete]
    public string? FtpPassword { get; set; }

    /// <summary>
    /// FTP username
    /// </summary>
    /// <value>FTP username</value>
    [JsonPropertyName("ftp_username")]
    [Obsolete]
    public string? FtpUsername { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationId
    /// </summary>
    [JsonPropertyName("registration_id")]
    public string? RegistrationId { get; set; }

    /// <summary>
    /// Gets or Sets SoftwareName
    /// </summary>
    [JsonPropertyName("software_name")]
    public string? SoftwareName { get; set; }

    /// <summary>
    /// Sold To field
    /// </summary>
    /// <value>Sold To field</value>
    [JsonPropertyName("sold_to")]
    public string? SoldTo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectDhlEcommerceRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  DistributionCenter: ").Append(DistributionCenter).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  PickupNumber: ").Append(PickupNumber).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  AncillaryEndorsement: ").Append(AncillaryEndorsement).Append("\n");
        sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
        sb.Append("  ApiSecret: ").Append(ApiSecret).Append("\n");
        sb.Append("  FtpPassword: ").Append(FtpPassword).Append("\n");
        sb.Append("  FtpUsername: ").Append(FtpUsername).Append("\n");
        sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
        sb.Append("  SoftwareName: ").Append(SoftwareName).Append("\n");
        sb.Append("  SoldTo: ").Append(SoldTo).Append("\n");
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
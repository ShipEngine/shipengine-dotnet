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
/// A Newgistics account information request body
/// </summary>
public partial class ConnectNewgisticsRequestBody
{

    /// <summary>
    /// Induction site
    /// </summary>
    /// <value>Induction site</value>
    [JsonPropertyName("induction_site"), JsonPropertyOrder(1)]
    public required string InductionSite { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(2)]
    public required string Nickname { get; set; }

    /// <summary>
    /// Mailer id
    /// </summary>
    /// <value>Mailer id</value>
    [JsonPropertyName("mailer_id"), JsonPropertyOrder(3)]
    public int? MailerId { get; set; }

    /// <summary>
    /// Merchant id
    /// </summary>
    /// <value>Merchant id</value>
    [JsonPropertyName("merchant_id"), JsonPropertyOrder(4)]
    public int? MerchantId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectNewgisticsRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  InductionSite: ").Append(InductionSite).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  MailerId: ").Append(MailerId).Append("\n");
        sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
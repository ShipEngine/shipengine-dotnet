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
/// An Amazon Shipping UK account information request body
/// </summary>
public partial class ConnectAmazonShippingUk
{

    /// <summary>
    /// Amazon UK Shipping auth code.
    /// </summary>
    /// <value>Amazon UK Shipping auth code.</value>
    [JsonPropertyName("auth_code")]
    [JsonRequired]
    public required string AuthCode { get; set; }

    /// <summary>
    /// The nickname associated with the carrier connection
    /// </summary>
    /// <value>The nickname associated with the carrier connection</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("nickname")]
    [JsonRequired]
    public required string Nickname { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConnectAmazonShippingUk {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
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
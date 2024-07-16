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
/// A response message that displays when additional info is needed for an address validation request.
/// </summary>
public partial class ResponseMessage
{

    /// <summary>
    /// Gets or Sets Code  CLOVUS
    /// </summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public AddressValidationCode Code { get; set; } = new();


    /// <summary>
    /// Gets or Sets Type  CLOVUS
    /// </summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public AddressValidationMessageType Type { get; set; } = new();


    /// <summary>
    /// Gets or Sets DetailCode  CLOVUS
    /// </summary>
    [JsonPropertyName("detail_code")]
    [JsonRequired]
    public AddressValidationDetailCode DetailCode { get; set; } = new();


    /// <summary>
    /// Message explaining the address validation error
    /// </summary>
    /// <value>Message explaining the address validation error</value>
    /// <example>
    /// Invalid Postal Code
    /// </example>
    [JsonPropertyName("message")]
    [JsonRequired]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ResponseMessage {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DetailCode: ").Append(DetailCode).Append("\n");
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
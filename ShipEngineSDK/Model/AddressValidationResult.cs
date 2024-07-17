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
/// An address validation result
/// </summary>
public partial class AddressValidationResult
{

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status"), JsonRequired, JsonPropertyOrder(3)]
    public required AddressValidationStatus Status { get; set; }

    /// <summary>
    /// The list of messages that were generated during the address validation request.
    /// </summary>
    /// <value>The list of messages that were generated during the address validation request.</value>
    [JsonPropertyName("messages"), JsonInclude]
    public List<ResponseMessage>? Messages { get; private set; }

    /// <summary>
    /// The original address that was sent for validation
    /// </summary>
    /// <value>The original address that was sent for validation</value>
    [JsonPropertyName("original_address"), JsonRequired, JsonPropertyOrder(2)]
    public required Address OriginalAddress { get; set; }

    /// <summary>
    /// The matched address found by the Shipengine API
    /// </summary>
    /// <value>The matched address found by the Shipengine API</value>
    [JsonPropertyName("matched_address"), JsonInclude]
    public Address? MatchedAddress { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AddressValidationResult {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  OriginalAddress: ").Append(OriginalAddress).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
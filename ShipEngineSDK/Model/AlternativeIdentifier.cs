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
/// Additional information some carriers may provide by which to identify a given label in their system.  
/// </summary>
//[DataContract(Name = "alternative_identifier")]
public partial class AlternativeIdentifier
{

    /// <summary>
    /// The type of alternative_identifier that corresponds to the value. 
    /// </summary>
    /// <value>The type of alternative_identifier that corresponds to the value. </value>
    /// <example>
    /// last_mile_tracking_number
    /// </example>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// The value of the alternative_identifier. 
    /// </summary>
    /// <value>The value of the alternative_identifier. </value>
    /// <example>
    /// 12345678912345678912
    /// </example>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AlternativeIdentifier {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
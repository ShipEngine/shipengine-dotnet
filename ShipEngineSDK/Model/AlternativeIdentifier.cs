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
/// Additional information some carriers may provide by which to identify a given label in their system.  
/// </summary>
public partial class AlternativeIdentifier
{

    /// <summary>
    /// The type of alternative_identifier that corresponds to the value. 
    /// </summary>
    /// <value>The type of alternative_identifier that corresponds to the value. </value>
    /// <example>
    /// last_mile_tracking_number
    /// </example>
    [JsonPropertyName("type"), JsonPropertyOrder(1)]
    public string? Type { get; set; }

    /// <summary>
    /// The value of the alternative_identifier. 
    /// </summary>
    /// <value>The value of the alternative_identifier. </value>
    /// <example>
    /// 12345678912345678912
    /// </example>
    [JsonPropertyName("value"), JsonPropertyOrder(2)]
    public string? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeIdentifier {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
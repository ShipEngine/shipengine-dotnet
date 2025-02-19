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
/// ContactDetails
/// </summary>
public partial class ContactDetails
{

    /// <summary>
    /// An email address.
    /// </summary>
    /// <value>An email address.</value>
    /// <example>
    /// john.doe@example.com
    /// </example>
    [JsonPropertyName("email"), JsonPropertyOrder(1)]
    public required string Email { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name"), JsonPropertyOrder(2)]
    public required string Name { get; set; }

    /// <summary>
    /// Phone number associated
    /// </summary>
    /// <value>Phone number associated</value>
    [JsonPropertyName("phone"), JsonPropertyOrder(3)]
    public required string Phone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactDetails {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
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
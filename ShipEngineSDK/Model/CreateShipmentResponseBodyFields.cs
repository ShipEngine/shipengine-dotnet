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
/// CreateShipmentResponseBodyFields
/// </summary>
public partial class CreateShipmentResponseBodyFields
{

    /// <summary>
    /// The address validation
    /// </summary>
    /// <value>The address validation</value>
    [JsonPropertyName("address_validation"), JsonPropertyOrder(1)]
    public AddressValidationResult? AddressValidation { get; set; }

    /// <summary>
    /// An array of errors that occurred while creating shipment.
    /// </summary>
    /// <value>An array of errors that occurred while creating shipment.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("errors"), JsonInclude, Obsolete]
    public List<string>? Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateShipmentResponseBodyFields {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AddressValidation: ").Append(AddressValidation).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
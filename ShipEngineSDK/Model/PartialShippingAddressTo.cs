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
/// A complete or partial mailing address.
/// </summary>
public partial class PartialShippingAddressTo
{

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [JsonPropertyName("geolocation"), JsonPropertyOrder(1)]
    public List<PartialShippingAddressToGeolocationInner>? Geolocation { get; set; }

    /// <summary>
    /// Additional text about how to handle the shipment at this address. 
    /// </summary>
    /// <value>Additional text about how to handle the shipment at this address. </value>
    [JsonPropertyName("instructions"), JsonPropertyOrder(2)]
    public string? Instructions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PartialShippingAddressTo {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  Instructions: ").Append(Instructions).Append("\n");
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
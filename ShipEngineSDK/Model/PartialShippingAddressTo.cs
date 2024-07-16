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
/// A complete or partial mailing address.
/// </summary>
public partial class PartialShippingAddressTo
{

    /// <summary>
    /// Additional text about how to handle the shipment at this address. 
    /// </summary>
    /// <value>Additional text about how to handle the shipment at this address. </value>
    [JsonPropertyName("instructions")]
    public string Instructions { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [JsonPropertyName("geolocation")]
    public List<PartialShippingAddressToGeolocationInner> Geolocation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PartialShippingAddressTo {\n");
        sb.Append("  Instructions: ").Append(Instructions).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
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
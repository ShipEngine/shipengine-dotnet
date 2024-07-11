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
/// Provide details for the Fedex freight service
/// </summary>
public partial class AdvancedShipmentOptionsFedexFreight
{

    /// <summary>
    /// Gets or Sets ShipperLoadAndCount
    /// </summary>
    [JsonPropertyName("shipper_load_and_count")]
    public string ShipperLoadAndCount { get; set; }

    /// <summary>
    /// Gets or Sets BookingConfirmation
    /// </summary>
    [JsonPropertyName("booking_confirmation")]
    public string BookingConfirmation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AdvancedShipmentOptionsFedexFreight {\n");
        sb.Append("  ShipperLoadAndCount: ").Append(ShipperLoadAndCount).Append("\n");
        sb.Append("  BookingConfirmation: ").Append(BookingConfirmation).Append("\n");
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
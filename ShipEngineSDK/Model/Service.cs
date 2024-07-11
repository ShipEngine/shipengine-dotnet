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
/// A service offered by the carrier
/// </summary>
public partial class Service
{

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    public string CarrierId { get; set; }

    /// <summary>
    /// A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.
    /// </summary>
    /// <value>A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// service code
    /// </summary>
    /// <value>service code</value>
    /// <example>
    /// usps_media_mail
    /// </example>
    [JsonPropertyName("service_code")]
    public string ServiceCode { get; set; }

    /// <summary>
    /// User friendly service name
    /// </summary>
    /// <value>User friendly service name</value>
    /// <example>
    /// USPS First Class Mail
    /// </example>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Supports domestic shipping
    /// </summary>
    /// <value>Supports domestic shipping</value>
    [JsonPropertyName("domestic")]
    public bool Domestic { get; set; }

    /// <summary>
    /// Supports international shipping.
    /// </summary>
    /// <value>Supports international shipping.</value>
    [JsonPropertyName("international")]
    public bool International { get; set; }

    /// <summary>
    /// Carrier supports multiple packages per shipment
    /// </summary>
    /// <value>Carrier supports multiple packages per shipment</value>
    [JsonPropertyName("is_multi_package_supported")]
    public bool IsMultiPackageSupported { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Service {\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Domestic: ").Append(Domestic).Append("\n");
        sb.Append("  International: ").Append(International).Append("\n");
        sb.Append("  IsMultiPackageSupported: ").Append(IsMultiPackageSupported).Append("\n");
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
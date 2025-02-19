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
/// A service offered by the carrier
/// </summary>
public partial class Service
{

    /// <summary>
    /// A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.
    /// </summary>
    /// <value>A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_code"), JsonPropertyOrder(1)]
    public string? CarrierCode { get; set; }

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; set; }

    /// <summary>
    /// Supports domestic shipping
    /// </summary>
    /// <value>Supports domestic shipping</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("domestic"), JsonInclude]
    public bool? Domestic { get; set; }

    /// <summary>
    /// Supports international shipping.
    /// </summary>
    /// <value>Supports international shipping.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("international"), JsonInclude]
    public bool? International { get; set; }

    /// <summary>
    /// Carrier supports multiple packages per shipment
    /// </summary>
    /// <value>Carrier supports multiple packages per shipment</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("is_multi_package_supported"), JsonInclude]
    public bool? IsMultiPackageSupported { get; set; }

    /// <summary>
    /// User friendly service name
    /// </summary>
    /// <value>User friendly service name</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// USPS First Class Mail
    /// </example>
    [JsonPropertyName("name"), JsonInclude]
    public string? Name { get; set; }

    /// <summary>
    /// service code
    /// </summary>
    /// <value>service code</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// usps_media_mail
    /// </example>
    [JsonPropertyName("service_code"), JsonInclude]
    public string? ServiceCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Service {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  Domestic: ").Append(Domestic).Append("\n");
        sb.Append("  International: ").Append(International).Append("\n");
        sb.Append("  IsMultiPackageSupported: ").Append(IsMultiPackageSupported).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
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
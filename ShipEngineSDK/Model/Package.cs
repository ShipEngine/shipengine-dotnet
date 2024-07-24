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
/// A package associated with a shipment 
/// </summary>
public partial class Package
{

    /// <summary>
    /// The package weight
    /// </summary>
    /// <value>The package weight</value>
    [JsonPropertyName("weight"), JsonPropertyOrder(1)]
    public required Weight Weight { get; set; }

    /// <summary>
    /// A short description of the package content. Required for shipments moving to, from, and through Mexico. 
    /// </summary>
    /// <value>A short description of the package content. Required for shipments moving to, from, and through Mexico. </value>
    /// <example>
    /// Hand knitted wool socks
    /// </example>
    [JsonPropertyName("content_description"), JsonPropertyOrder(2)]
    public string? ContentDescription { get; set; }

    /// <summary>
    /// The package dimensions
    /// </summary>
    /// <value>The package dimensions</value>
    [JsonPropertyName("dimensions"), JsonPropertyOrder(3)]
    public Dimensions? Dimensions { get; set; }

    /// <summary>
    /// An external package id.
    /// </summary>
    /// <value>An external package id.</value>
    [JsonPropertyName("external_package_id"), JsonPropertyOrder(4)]
    public string? ExternalPackageId { get; set; }

    /// <summary>
    /// The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. 
    /// </summary>
    /// <value>The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. </value>
    [JsonPropertyName("insured_value"), JsonPropertyOrder(5)]
    public MonetaryValue? InsuredValue { get; set; }

    /// <summary>
    /// Gets or Sets LabelMessages
    /// </summary>
    [JsonPropertyName("label_messages"), JsonPropertyOrder(6)]
    public LabelMessages? LabelMessages { get; set; }

    /// <summary>
    /// The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. 
    /// </summary>
    /// <value>The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. </value>
    /// <example>
    /// small_flat_rate_box
    /// </example>
    [JsonPropertyName("package_code"), JsonPropertyOrder(7)]
    public string? PackageCode { get; set; }

    /// <summary>
    /// A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)
    /// </summary>
    /// <value>A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("package_id"), JsonPropertyOrder(8)]
    public string? PackageId { get; set; }

    /// <summary>
    /// The name of the of the [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)
    /// </summary>
    /// <value>The name of the of the [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)</value>
    [JsonPropertyName("package_name"), JsonPropertyOrder(9)]
    public string? PackageName { get; set; }

    /// <summary>
    /// Details about products inside packages (Information provided would be used on custom documentation)
    /// </summary>
    /// <value>Details about products inside packages (Information provided would be used on custom documentation)</value>
    [JsonPropertyName("products"), JsonPropertyOrder(10)]
    public List<Products>? Products { get; set; }

    /// <summary>
    /// A string that uniquely identifies this shipment package
    /// </summary>
    /// <value>A string that uniquely identifies this shipment package</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_package_id"), JsonInclude]
    public string? ShipmentPackageId { get; set; }

    /// <summary>
    /// The tracking number for the package.  The format depends on the carrier. 
    /// </summary>
    /// <value>The tracking number for the package.  The format depends on the carrier. </value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 1Z932R800392060079
    /// </example>
    [JsonPropertyName("tracking_number"), JsonInclude]
    public string? TrackingNumber { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Package {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  ContentDescription: ").Append(ContentDescription).Append("\n");
        sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
        sb.Append("  ExternalPackageId: ").Append(ExternalPackageId).Append("\n");
        sb.Append("  InsuredValue: ").Append(InsuredValue).Append("\n");
        sb.Append("  LabelMessages: ").Append(LabelMessages).Append("\n");
        sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
        sb.Append("  PackageId: ").Append(PackageId).Append("\n");
        sb.Append("  PackageName: ").Append(PackageName).Append("\n");
        sb.Append("  Products: ").Append(Products).Append("\n");
        sb.Append("  ShipmentPackageId: ").Append(ShipmentPackageId).Append("\n");
        sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
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
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
/// LabelPackagesInner
/// </summary>
public partial class LabelPackagesInner
{

    /// <summary>
    /// The package weight
    /// </summary>
    /// <value>The package weight</value>
    [JsonPropertyName("weight"), JsonRequired, JsonPropertyOrder(1)]
    public required Weight Weight { get; set; }

    /// <summary>
    /// Alternative identifiers associated with this package. 
    /// </summary>
    /// <value>Alternative identifiers associated with this package. </value>
    [JsonPropertyName("alternative_identifiers"), JsonInclude]
    public List<AlternativeIdentifier>? AlternativeIdentifiers { get; private set; }

    /// <summary>
    /// A short description of the package content. Required for shipments moving to, from, and through Mexico. 
    /// </summary>
    /// <value>A short description of the package content. Required for shipments moving to, from, and through Mexico. </value>
    /// <example>
    /// Hand knitted wool socks
    /// </example>
    [JsonPropertyName("content_description"), JsonPropertyOrder(3)]
    public string? ContentDescription { get; set; }

    /// <summary>
    /// The package dimensions
    /// </summary>
    /// <value>The package dimensions</value>
    [JsonPropertyName("dimensions"), JsonPropertyOrder(4)]
    public Dimensions? Dimensions { get; set; }

    /// <summary>
    /// An external package id.
    /// </summary>
    /// <value>An external package id.</value>
    [JsonPropertyName("external_package_id"), JsonPropertyOrder(5)]
    public string? ExternalPackageId { get; set; }

    /// <summary>
    /// The form download for any customs that are needed
    /// </summary>
    /// <value>The form download for any customs that are needed</value>
    [JsonPropertyName("form_download"), JsonInclude]
    public OptionalLink? FormDownload { get; private set; }

    /// <summary>
    /// The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. 
    /// </summary>
    /// <value>The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. </value>
    [JsonPropertyName("insured_value"), JsonPropertyOrder(7)]
    public MonetaryValue? InsuredValue { get; set; }

    /// <summary>
    /// The label download for the package
    /// </summary>
    /// <value>The label download for the package</value>
    [JsonPropertyName("label_download"), JsonInclude]
    public LabelDownload? LabelDownload { get; private set; }

    /// <summary>
    /// Gets or Sets LabelMessages
    /// </summary>
    [JsonPropertyName("label_messages"), JsonPropertyOrder(9)]
    public LabelMessages? LabelMessages { get; set; }

    /// <summary>
    /// The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. 
    /// </summary>
    /// <value>The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. </value>
    /// <example>
    /// small_flat_rate_box
    /// </example>
    [JsonPropertyName("package_code"), JsonPropertyOrder(10)]
    public string? PackageCode { get; set; }

    /// <summary>
    /// A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)
    /// </summary>
    /// <value>A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("package_id"), JsonPropertyOrder(11)]
    public string? PackageId { get; set; }

    /// <summary>
    /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.
    /// </summary>
    /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.</value>
    [JsonPropertyName("paperless_download"), JsonInclude]
    public PaperlessDownload? PaperlessDownload { get; private set; }

    /// <summary>
    /// Details about products inside packages (Information provided would be used on custom documentation)
    /// </summary>
    /// <value>Details about products inside packages (Information provided would be used on custom documentation)</value>
    [JsonPropertyName("products"), JsonPropertyOrder(13)]
    public List<Products>? Products { get; set; }

    /// <summary>
    /// Package sequence
    /// </summary>
    /// <value>Package sequence</value>
    [JsonPropertyName("sequence"), JsonInclude]
    public int? Sequence { get; private set; }

    /// <summary>
    /// The tracking number for the package.  The format depends on the carrier. 
    /// </summary>
    /// <value>The tracking number for the package.  The format depends on the carrier. </value>
    /// <example>
    /// 1Z932R800392060079
    /// </example>
    [JsonPropertyName("tracking_number"), JsonInclude]
    public string? TrackingNumber { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class LabelPackagesInner {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  AlternativeIdentifiers: ").Append(AlternativeIdentifiers).Append("\n");
        sb.Append("  ContentDescription: ").Append(ContentDescription).Append("\n");
        sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
        sb.Append("  ExternalPackageId: ").Append(ExternalPackageId).Append("\n");
        sb.Append("  FormDownload: ").Append(FormDownload).Append("\n");
        sb.Append("  InsuredValue: ").Append(InsuredValue).Append("\n");
        sb.Append("  LabelDownload: ").Append(LabelDownload).Append("\n");
        sb.Append("  LabelMessages: ").Append(LabelMessages).Append("\n");
        sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
        sb.Append("  PackageId: ").Append(PackageId).Append("\n");
        sb.Append("  PaperlessDownload: ").Append(PaperlessDownload).Append("\n");
        sb.Append("  Products: ").Append(Products).Append("\n");
        sb.Append("  Sequence: ").Append(Sequence).Append("\n");
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
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
/// A package associated with a [shipping label](https://www.shipengine.com/docs/labels/create-a-label/) 
/// </summary>
public partial class Package
{

    /// <summary>
    /// A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)
    /// </summary>
    /// <value>A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/)</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("package_id")]
    public string PackageId { get; set; }

    /// <summary>
    /// The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. 
    /// </summary>
    /// <value>The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type. </value>
    /// <example>
    /// small_flat_rate_box
    /// </example>
    [JsonPropertyName("package_code")]
    public string PackageCode { get; set; }

    /// <summary>
    /// A short description of the package content. Required for shipments moving to, from, and through Mexico. 
    /// </summary>
    /// <value>A short description of the package content. Required for shipments moving to, from, and through Mexico. </value>
    /// <example>
    /// Hand knitted wool socks
    /// </example>
    [JsonPropertyName("content_description")]
    public string ContentDescription { get; set; }

    /// <summary>
    /// The package weight
    /// </summary>
    /// <value>The package weight</value>
    [JsonPropertyName("weight")]
    [JsonRequired]
    public Weight Weight { get; set; }

    /// <summary>
    /// The package dimensions
    /// </summary>
    /// <value>The package dimensions</value>
    [JsonPropertyName("dimensions")]
    public Dimensions Dimensions { get; set; }

    /// <summary>
    /// The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. 
    /// </summary>
    /// <value>The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set. </value>
    [JsonPropertyName("insured_value")]
    public MonetaryValue InsuredValue { get; set; }

    /// <summary>
    /// The tracking number for the package.  The format depends on the carrier. 
    /// </summary>
    /// <value>The tracking number for the package.  The format depends on the carrier. </value>
    /// <example>
    /// 1Z932R800392060079
    /// </example>
    [JsonPropertyName("tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Gets or Sets LabelMessages
    /// </summary>
    [JsonPropertyName("label_messages")]
    public LabelMessages LabelMessages { get; set; }

    /// <summary>
    /// An external package id.
    /// </summary>
    /// <value>An external package id.</value>
    [JsonPropertyName("external_package_id")]
    public string ExternalPackageId { get; set; }

    /// <summary>
    /// The label download for the package
    /// </summary>
    /// <value>The label download for the package</value>
    [JsonPropertyName("label_download")]
    public LabelDownload LabelDownload { get; set; }

    /// <summary>
    /// The form download for any customs that are needed
    /// </summary>
    /// <value>The form download for any customs that are needed</value>
    [JsonPropertyName("form_download")]
    public OptionalLink FormDownload { get; set; }

    /// <summary>
    /// The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.
    /// </summary>
    /// <value>The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;.</value>
    [JsonPropertyName("paperless_download")]
    public PaperlessDownload PaperlessDownload { get; set; }

    /// <summary>
    /// Package sequence
    /// </summary>
    /// <value>Package sequence</value>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }

    /// <summary>
    /// Details about products inside packages (Information provided would be used on custom documentation)
    /// </summary>
    /// <value>Details about products inside packages (Information provided would be used on custom documentation)</value>
    [JsonPropertyName("products")]
    public List<Products> Products { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Package {\n");
        sb.Append("  PackageId: ").Append(PackageId).Append("\n");
        sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
        sb.Append("  ContentDescription: ").Append(ContentDescription).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
        sb.Append("  InsuredValue: ").Append(InsuredValue).Append("\n");
        sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
        sb.Append("  LabelMessages: ").Append(LabelMessages).Append("\n");
        sb.Append("  ExternalPackageId: ").Append(ExternalPackageId).Append("\n");
        sb.Append("  LabelDownload: ").Append(LabelDownload).Append("\n");
        sb.Append("  FormDownload: ").Append(FormDownload).Append("\n");
        sb.Append("  PaperlessDownload: ").Append(PaperlessDownload).Append("\n");
        sb.Append("  Sequence: ").Append(Sequence).Append("\n");
        sb.Append("  Products: ").Append(Products).Append("\n");
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
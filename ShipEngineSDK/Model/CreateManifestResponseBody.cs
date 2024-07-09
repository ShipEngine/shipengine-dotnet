/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// A create manifest response body
/// </summary>
//[DataContract(Name = "create_manifest_response_body")]
public partial class CreateManifestResponseBody
{

    /// <summary>
    /// Resulting Manifests
    /// </summary>
    /// <value>Resulting Manifests</value>
    [JsonPropertyName("manifests")]
    public List<Manifest> Manifests { get; set; }

    /// <summary>
    /// Resulting manifest requests with statuses
    /// </summary>
    /// <value>Resulting manifest requests with statuses</value>
    [JsonPropertyName("manifest_requests")]
    public List<ManifestRequest> ManifestRequests { get; set; }

    /// <summary>
    /// A string that uniquely identifies the manifest
    /// </summary>
    /// <value>A string that uniquely identifies the manifest</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("manifest_id")]
    [JsonRequired]
    [Obsolete]
    public string ManifestId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the form
    /// </summary>
    /// <value>A string that uniquely identifies the form</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("form_id")]
    [JsonRequired]
    [Obsolete]
    public string FormId { get; set; }

    /// <summary>
    /// The date-time that the manifest was created
    /// </summary>
    /// <value>The date-time that the manifest was created</value>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("created_at")]
    [JsonRequired]
    [Obsolete]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The date-time that the manifests shipments will be picked up
    /// </summary>
    /// <value>The date-time that the manifests shipments will be picked up</value>
    /// <example>
    /// 2019-07-12T13:37:39.050Z
    /// </example>
    [JsonPropertyName("ship_date")]
    [JsonRequired]
    [Obsolete]
    public DateTime ShipDate { get; set; }

    /// <summary>
    /// The number of shipments that are included in this manifest
    /// </summary>
    /// <value>The number of shipments that are included in this manifest</value>
    /// <example>
    /// 100
    /// </example>
    [JsonPropertyName("shipments")]
    [JsonRequired]
    [Obsolete]
    public int Shipments { get; set; }

    /// <summary>
    /// A string that uniquely identifies the warehouse
    /// </summary>
    /// <value>A string that uniquely identifies the warehouse</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id")]
    [JsonRequired]
    [Obsolete]
    public string WarehouseId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the submission
    /// </summary>
    /// <value>A string that uniquely identifies the submission</value>
    /// <example>
    /// 9475711899564878915476
    /// </example>
    [JsonPropertyName("submission_id")]
    [JsonRequired]
    [Obsolete]
    public string SubmissionId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    [JsonRequired]
    [Obsolete]
    public string CarrierId { get; set; }

    /// <summary>
    /// Gets or Sets ManifestDownload
    /// </summary>
    [JsonPropertyName("manifest_download")]
    [JsonRequired]
    [Obsolete]
    public ManifestDownload ManifestDownload { get; set; }

    /// <summary>
    /// An array of the label ids used in this manifest.
    /// </summary>
    /// <value>An array of the label ids used in this manifest.</value>
    [JsonPropertyName("label_ids")]
    [Obsolete]
    public List<string> LabelIds { get; private set; }

    /// <summary>
    /// A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur 
    /// </summary>
    /// <value>A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur </value>
    /// <example>
    /// aa3d8e8e-462b-4476-9618-72db7f7b7009
    /// </example>
    [JsonPropertyName("request_id")]
    [JsonRequired]
    public Guid RequestId { get; set; }

    /// <summary>
    /// The errors associated with the failed API call
    /// </summary>
    /// <value>The errors associated with the failed API call</value>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public List<Error> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateManifestResponseBody {\n");
        sb.Append("  Manifests: ").Append(Manifests).Append("\n");
        sb.Append("  ManifestRequests: ").Append(ManifestRequests).Append("\n");
        sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
        sb.Append("  FormId: ").Append(FormId).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  Shipments: ").Append(Shipments).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  SubmissionId: ").Append(SubmissionId).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ManifestDownload: ").Append(ManifestDownload).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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


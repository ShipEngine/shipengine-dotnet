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
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// A tracking information resource
/// </summary>
[DataContract(Name = "tracking_information")]
public partial class TrackingInformation
{

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [JsonPropertyName("status_code")]
    public string? StatusCode { get; set; }
    /// <summary>
    /// A tracking number for a package. The format depends on the carrier.
    /// </summary>
    /// <value>A tracking number for a package. The format depends on the carrier.</value>
    /// <example>
    /// 1Z932R800392060079
    /// </example>
    [JsonPropertyName("tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Carrier Tracking Url, if available
    /// </summary>
    /// <value>Carrier Tracking Url, if available</value>
    /// <example>
    /// https://www.fedex.com/fedextrack/?action&#x3D;track&amp;trackingnumber&#x3D;1234
    /// </example>
    [JsonPropertyName("tracking_url")]
    public string TrackingUrl { get; private set; }

    /// <summary>
    /// A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. 
    /// </summary>
    /// <value>A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. </value>
    /// <example>
    /// dhl_express
    /// </example>
    [JsonPropertyName("carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.
    /// </summary>
    /// <value>A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    public string CarrierId { get; set; }

    /// <summary>
    /// Status description
    /// </summary>
    /// <value>Status description</value>
    /// <example>
    /// Delivered
    /// </example>
    [JsonPropertyName("status_description")]
    public string StatusDescription { get; private set; }

    /// <summary>
    /// Carrier status code
    /// </summary>
    /// <value>Carrier status code</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("carrier_status_code")]
    public string CarrierStatusCode { get; private set; }

    /// <summary>
    /// Carrier detail code
    /// </summary>
    /// <value>Carrier detail code</value>
    /// <example>
    /// OT
    /// </example>
    [JsonPropertyName("carrier_detail_code")]
    public string CarrierDetailCode { get; private set; }

    /// <summary>
    /// carrier status description
    /// </summary>
    /// <value>carrier status description</value>
    /// <example>
    /// Your item was delivered in or at the mailbox at 9:10 am on March
    /// </example>
    [JsonPropertyName("carrier_status_description")]
    public string CarrierStatusDescription { get; private set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    public DateTime ShipDate { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("estimated_delivery_date")]
    public DateTime EstimatedDeliveryDate { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("actual_delivery_date")]
    public DateTime ActualDeliveryDate { get; set; }

    /// <summary>
    /// Exception description
    /// </summary>
    /// <value>Exception description</value>
    [JsonPropertyName("exception_description")]
    public string ExceptionDescription { get; private set; }

    /// <summary>
    /// The events that have occured during the lifetime of this tracking number.
    /// </summary>
    /// <value>The events that have occured during the lifetime of this tracking number.</value>
    [JsonPropertyName("events")]
    public List<TrackEvent> Events { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TrackingInformation {\n");
        sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
        sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
        sb.Append("  CarrierStatusCode: ").Append(CarrierStatusCode).Append("\n");
        sb.Append("  CarrierDetailCode: ").Append(CarrierDetailCode).Append("\n");
        sb.Append("  CarrierStatusDescription: ").Append(CarrierStatusDescription).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
        sb.Append("  ActualDeliveryDate: ").Append(ActualDeliveryDate).Append("\n");
        sb.Append("  ExceptionDescription: ").Append(ExceptionDescription).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
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


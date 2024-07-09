/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
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
/// A track event
/// </summary>
//[DataContract(Name = "track_event")]
public partial class TrackEvent
{

    /// <summary>
    /// Gets or Sets StatusCode  CLOVUS
    /// </summary>
    [JsonPropertyName("status_code")]
    [JsonRequired]
    public StatusCode StatusCode { get; set; } = new();


    /// <summary>
    /// Timestamp for carrier event
    /// </summary>
    /// <value>Timestamp for carrier event</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("occurred_at")]
    [JsonRequired]
    public DateTime OccurredAt { get; set; }

    /// <summary>
    /// Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
    /// </summary>
    /// <value>Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("carrier_occurred_at")]
    public DateTime CarrierOccurredAt { get; set; }

    /// <summary>
    /// Event description
    /// </summary>
    /// <value>Event description</value>
    /// <example>
    /// Delivered, In/At Mailbox
    /// </example>
    [JsonPropertyName("description")]
    public string Description { get; private set; }

    /// <summary>
    /// City locality
    /// </summary>
    /// <value>City locality</value>
    /// <example>
    /// AUSTIN
    /// </example>
    [JsonPropertyName("city_locality")]
    [JsonRequired]
    public string CityLocality { get; set; }

    /// <summary>
    /// State province
    /// </summary>
    /// <value>State province</value>
    /// <example>
    /// TX
    /// </example>
    [JsonPropertyName("state_province")]
    [JsonRequired]
    public string StateProvince { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    /// <example>
    /// 78756
    /// </example>
    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string PostalCode { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    /// <value>Company Name</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("company_name")]
    public string CompanyName { get; private set; }

    /// <summary>
    /// Signer information
    /// </summary>
    /// <value>Signer information</value>
    [JsonPropertyName("signer")]
    public string Signer { get; private set; }

    /// <summary>
    /// Event Code
    /// </summary>
    /// <value>Event Code</value>
    [JsonPropertyName("event_code")]
    public string EventCode { get; set; }

    /// <summary>
    /// Carrier detail code
    /// </summary>
    /// <value>Carrier detail code</value>
    /// <example>
    /// OT
    /// </example>
    [JsonPropertyName("carrier_detail_code")]
    [JsonRequired]
    public string CarrierDetailCode { get; set; }

    /// <summary>
    /// Event Status Description
    /// </summary>
    /// <value>Event Status Description</value>
    /// <example>
    /// In Transit
    /// </example>
    [JsonPropertyName("status_description")]
    [JsonRequired]
    public string StatusDescription { get; set; }

    /// <summary>
    /// Carrier status code
    /// </summary>
    /// <value>Carrier status code</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("carrier_status_code")]
    [JsonRequired]
    public string CarrierStatusCode { get; set; }

    /// <summary>
    /// carrier status description
    /// </summary>
    /// <value>carrier status description</value>
    /// <example>
    /// Your item was delivered in or at the mailbox at 9:10 am on March
    /// </example>
    [JsonPropertyName("carrier_status_description")]
    [JsonRequired]
    public string CarrierStatusDescription { get; set; }

    /// <summary>
    /// Latitude coordinate of tracking event.
    /// </summary>
    /// <value>Latitude coordinate of tracking event.</value>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate of tracking event.
    /// </summary>
    /// <value>Longitude coordinate of tracking event.</value>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TrackEvent {\n");
        sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
        sb.Append("  CarrierOccurredAt: ").Append(CarrierOccurredAt).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CityLocality: ").Append(CityLocality).Append("\n");
        sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  Signer: ").Append(Signer).Append("\n");
        sb.Append("  EventCode: ").Append(EventCode).Append("\n");
        sb.Append("  CarrierDetailCode: ").Append(CarrierDetailCode).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
        sb.Append("  CarrierStatusCode: ").Append(CarrierStatusCode).Append("\n");
        sb.Append("  CarrierStatusDescription: ").Append(CarrierStatusDescription).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
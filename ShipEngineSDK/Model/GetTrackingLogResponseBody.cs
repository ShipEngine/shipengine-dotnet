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
/// A get tracking log response body
/// </summary>
public partial class GetTrackingLogResponseBody
{

    /// <summary>
    /// Gets or Sets StatusCode  CLOVUS
    /// </summary>
    [JsonPropertyName("status_code")]
    [JsonRequired]
    public StatusCode StatusCode { get; set; } = new();


    /// <summary>
    /// A tracking number for a package. The format depends on the carrier.
    /// </summary>
    /// <value>A tracking number for a package. The format depends on the carrier.</value>
    /// <example>
    /// 1Z932R800392060079
    /// </example>
    [JsonPropertyName("tracking_number")]
    [JsonRequired]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Carrier Tracking Url, if available
    /// </summary>
    /// <value>Carrier Tracking Url, if available</value>
    /// <example>
    /// https://www.fedex.com/fedextrack/?action&#x3D;track&amp;trackingnumber&#x3D;1234
    /// </example>
    [JsonPropertyName("tracking_url")]
    [JsonRequired]
    public string TrackingUrl { get; set; }

    /// <summary>
    /// A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. 
    /// </summary>
    /// <value>A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. </value>
    /// <example>
    /// dhl_express
    /// </example>
    [JsonPropertyName("carrier_code")]
    [JsonRequired]
    public string CarrierCode { get; set; }

    /// <summary>
    /// A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.
    /// </summary>
    /// <value>A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    [JsonRequired]
    public string CarrierId { get; set; }

    /// <summary>
    /// Status description
    /// </summary>
    /// <value>Status description</value>
    /// <example>
    /// Delivered
    /// </example>
    [JsonPropertyName("status_description")]
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
    /// carrier status description
    /// </summary>
    /// <value>carrier status description</value>
    /// <example>
    /// Your item was delivered in or at the mailbox at 9:10 am on March
    /// </example>
    [JsonPropertyName("carrier_status_description")]
    public string CarrierStatusDescription { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    public DateTimeOffset ShipDate { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("estimated_delivery_date")]
    [JsonRequired]
    public DateTimeOffset EstimatedDeliveryDate { get; set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time. </value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("actual_delivery_date")]
    public DateTimeOffset ActualDeliveryDate { get; set; }

    /// <summary>
    /// Exception description
    /// </summary>
    /// <value>Exception description</value>
    [JsonPropertyName("exception_description")]
    public string ExceptionDescription { get; set; }

    /// <summary>
    /// The events that have occured during the lifetime of this tracking number.
    /// </summary>
    /// <value>The events that have occured during the lifetime of this tracking number.</value>
    [JsonPropertyName("events")]
    [JsonRequired]
    public List<TrackEvent> Events { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetTrackingLogResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
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
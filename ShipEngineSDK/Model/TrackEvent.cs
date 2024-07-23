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
/// A track event
/// </summary>
public partial class TrackEvent
{

    /// <summary>
    /// Carrier detail code
    /// </summary>
    /// <value>Carrier detail code</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// OT
    /// </example>
    [JsonPropertyName("carrier_detail_code"), JsonInclude]
    public string? CarrierDetailCode { get; set; }

    /// <summary>
    /// Carrier status code
    /// </summary>
    /// <value>Carrier status code</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("carrier_status_code"), JsonInclude]
    public string? CarrierStatusCode { get; set; }

    /// <summary>
    /// carrier status description
    /// </summary>
    /// <value>carrier status description</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// Your item was delivered in or at the mailbox at 9:10 am on March
    /// </example>
    [JsonPropertyName("carrier_status_description"), JsonInclude]
    public string? CarrierStatusDescription { get; set; }

    /// <summary>
    /// City locality
    /// </summary>
    /// <value>City locality</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// AUSTIN
    /// </example>
    [JsonPropertyName("city_locality"), JsonInclude]
    public string? CityLocality { get; set; }

    /// <summary>
    /// Timestamp for carrier event
    /// </summary>
    /// <value>Timestamp for carrier event</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("occurred_at"), JsonPropertyOrder(5)]
    public required DateTimeOffset OccurredAt { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 78756
    /// </example>
    [JsonPropertyName("postal_code"), JsonInclude]
    public string? PostalCode { get; set; }

    /// <summary>
    /// State province
    /// </summary>
    /// <value>State province</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// TX
    /// </example>
    [JsonPropertyName("state_province"), JsonInclude]
    public string? StateProvince { get; set; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [JsonPropertyName("status_code"), JsonPropertyOrder(8)]
    public required StatusCode StatusCode { get; set; }

    /// <summary>
    /// Event Status Description
    /// </summary>
    /// <value>Event Status Description</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// In Transit
    /// </example>
    [JsonPropertyName("status_description"), JsonInclude]
    public string? StatusDescription { get; set; }

    /// <summary>
    /// Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
    /// </summary>
    /// <value>Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("carrier_occurred_at"), JsonPropertyOrder(10)]
    public DateTimeOffset? CarrierOccurredAt { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    /// <value>Company Name</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("company_name"), JsonInclude]
    public string? CompanyName { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code"), JsonPropertyOrder(12)]
    public string? CountryCode { get; set; }

    /// <summary>
    /// Event description
    /// </summary>
    /// <value>Event description</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// Delivered, In/At Mailbox
    /// </example>
    [JsonPropertyName("description"), JsonInclude]
    public string? Description { get; set; }

    /// <summary>
    /// Event Code
    /// </summary>
    /// <value>Event Code</value>
    [JsonPropertyName("event_code"), JsonPropertyOrder(14)]
    public string? EventCode { get; set; }

    /// <summary>
    /// Latitude coordinate of tracking event.
    /// </summary>
    /// <value>Latitude coordinate of tracking event.</value>
    [JsonPropertyName("latitude"), JsonPropertyOrder(15)]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate of tracking event.
    /// </summary>
    /// <value>Longitude coordinate of tracking event.</value>
    [JsonPropertyName("longitude"), JsonPropertyOrder(16)]
    public double? Longitude { get; set; }

    /// <summary>
    /// Signer information
    /// </summary>
    /// <value>Signer information</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("signer"), JsonInclude]
    public string? Signer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrackEvent {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierDetailCode: ").Append(CarrierDetailCode).Append("\n");
        sb.Append("  CarrierStatusCode: ").Append(CarrierStatusCode).Append("\n");
        sb.Append("  CarrierStatusDescription: ").Append(CarrierStatusDescription).Append("\n");
        sb.Append("  CityLocality: ").Append(CityLocality).Append("\n");
        sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
        sb.Append("  CarrierOccurredAt: ").Append(CarrierOccurredAt).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  EventCode: ").Append(EventCode).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
        sb.Append("  Signer: ").Append(Signer).Append("\n");
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
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
/// A rate
/// </summary>
public partial class Rate
{

    /// <summary>
    /// carrier code
    /// </summary>
    /// <value>carrier code</value>
    [JsonPropertyName("carrier_code"), JsonInclude]
    public string? CarrierCode { get; private set; }

    /// <summary>
    /// carrier friendly name
    /// </summary>
    /// <value>carrier friendly name</value>
    [JsonPropertyName("carrier_friendly_name"), JsonInclude]
    public string? CarrierFriendlyName { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; private set; }

    /// <summary>
    /// carrier nickname
    /// </summary>
    /// <value>carrier nickname</value>
    [JsonPropertyName("carrier_nickname"), JsonInclude]
    public string? CarrierNickname { get; private set; }

    /// <summary>
    /// The confirmation amount.  Should be added with shipping_amount, insurance_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The confirmation amount.  Should be added with shipping_amount, insurance_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("confirmation_amount"), JsonInclude]
    public MonetaryValue? ConfirmationAmount { get; private set; }

    /// <summary>
    /// The error messages
    /// </summary>
    /// <value>The error messages</value>
    [JsonPropertyName("error_messages"), JsonInclude]
    public List<string>? ErrorMessages { get; private set; }

    /// <summary>
    /// Indicates if the rate is guaranteed.
    /// </summary>
    /// <value>Indicates if the rate is guaranteed.</value>
    [JsonPropertyName("guaranteed_service"), JsonInclude]
    public bool? GuaranteedService { get; private set; }

    /// <summary>
    /// The insurance amount.  Should be added with shipping_amount, confirmation_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The insurance amount.  Should be added with shipping_amount, confirmation_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("insurance_amount"), JsonInclude]
    public MonetaryValue? InsuranceAmount { get; private set; }

    /// <summary>
    /// Indicates if the rates been negotiated
    /// </summary>
    /// <value>Indicates if the rates been negotiated</value>
    [JsonPropertyName("negotiated_rate"), JsonInclude]
    public bool? NegotiatedRate { get; private set; }

    /// <summary>
    /// Any other charges associated with this rate.  Should be added with shipping_amount, insurance_amount and confirmation_amount to calculate the total purchase price.
    /// </summary>
    /// <value>Any other charges associated with this rate.  Should be added with shipping_amount, insurance_amount and confirmation_amount to calculate the total purchase price.</value>
    [JsonPropertyName("other_amount"), JsonInclude]
    public MonetaryValue? OtherAmount { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the rate
    /// </summary>
    /// <value>A string that uniquely identifies the rate</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("rate_id"), JsonInclude]
    public string? RateId { get; private set; }

    /// <summary>
    /// Gets or Sets RateType
    /// </summary>
    [JsonPropertyName("rate_type"), JsonInclude]
    public RateType? RateType { get; private set; }

    /// <summary>
    /// service code for the rate
    /// </summary>
    /// <value>service code for the rate</value>
    [JsonPropertyName("service_code"), JsonInclude]
    public string? ServiceCode { get; private set; }

    /// <summary>
    /// service type
    /// </summary>
    /// <value>service type</value>
    [JsonPropertyName("service_type"), JsonInclude]
    public string? ServiceType { get; private set; }

    /// <summary>
    /// The shipping amount. Should be added with confirmation_amount, insurance_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The shipping amount. Should be added with confirmation_amount, insurance_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("shipping_amount"), JsonInclude]
    public MonetaryValue? ShippingAmount { get; private set; }

    /// <summary>
    /// Indicates if rate is trackable
    /// </summary>
    /// <value>Indicates if rate is trackable</value>
    [JsonPropertyName("trackable"), JsonInclude]
    public bool? Trackable { get; private set; }

    /// <summary>
    /// Gets or Sets ValidationStatus
    /// </summary>
    [JsonPropertyName("validation_status"), JsonInclude]
    public ValidationStatus? ValidationStatus { get; private set; }

    /// <summary>
    /// The warning messages
    /// </summary>
    /// <value>The warning messages</value>
    [JsonPropertyName("warning_messages"), JsonInclude]
    public List<string>? WarningMessages { get; private set; }

    /// <summary>
    /// The carrier delivery days
    /// </summary>
    /// <value>The carrier delivery days</value>
    [JsonPropertyName("carrier_delivery_days"), JsonInclude]
    public string? CarrierDeliveryDays { get; private set; }

    /// <summary>
    /// The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday 
    /// </summary>
    /// <value>The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday </value>
    /// <example>
    /// 5
    /// </example>
    [JsonPropertyName("delivery_days"), JsonInclude]
    public int? DeliveryDays { get; private set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine. </value>
    /// <example>
    /// 2018-09-23T00:00Z
    /// </example>
    [JsonPropertyName("estimated_delivery_date"), JsonInclude]
    public DateTimeOffset? EstimatedDeliveryDate { get; private set; }

    /// <summary>
    /// package type that this rate was estimated for
    /// </summary>
    /// <value>package type that this rate was estimated for</value>
    /// <example>
    /// package
    /// </example>
    [JsonPropertyName("package_type"), JsonInclude]
    public string? PackageType { get; private set; }

    /// <summary>
    /// The total shipping cost for the specified comparison_rate_type.
    /// </summary>
    /// <value>The total shipping cost for the specified comparison_rate_type.</value>
    [JsonPropertyName("requested_comparison_amount"), JsonInclude]
    public MonetaryValue? RequestedComparisonAmount { get; private set; }

    /// <summary>
    /// ship date
    /// </summary>
    /// <value>ship date</value>
    [JsonPropertyName("ship_date"), JsonInclude]
    public DateTimeOffset? ShipDate { get; private set; }

    /// <summary>
    /// Tariff and additional taxes associated with an international shipment.
    /// </summary>
    /// <value>Tariff and additional taxes associated with an international shipment.</value>
    [JsonPropertyName("tax_amount"), JsonInclude]
    public MonetaryValue? TaxAmount { get; private set; }

    /// <summary>
    /// Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location 
    /// </summary>
    /// <value>Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location </value>
    /// <example>
    /// 6
    /// </example>
    [JsonPropertyName("zone"), JsonInclude]
    public int? Zone { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Rate {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  CarrierFriendlyName: ").Append(CarrierFriendlyName).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  CarrierNickname: ").Append(CarrierNickname).Append("\n");
        sb.Append("  ConfirmationAmount: ").Append(ConfirmationAmount).Append("\n");
        sb.Append("  ErrorMessages: ").Append(ErrorMessages).Append("\n");
        sb.Append("  GuaranteedService: ").Append(GuaranteedService).Append("\n");
        sb.Append("  InsuranceAmount: ").Append(InsuranceAmount).Append("\n");
        sb.Append("  NegotiatedRate: ").Append(NegotiatedRate).Append("\n");
        sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
        sb.Append("  RateId: ").Append(RateId).Append("\n");
        sb.Append("  RateType: ").Append(RateType).Append("\n");
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
        sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
        sb.Append("  ShippingAmount: ").Append(ShippingAmount).Append("\n");
        sb.Append("  Trackable: ").Append(Trackable).Append("\n");
        sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
        sb.Append("  WarningMessages: ").Append(WarningMessages).Append("\n");
        sb.Append("  CarrierDeliveryDays: ").Append(CarrierDeliveryDays).Append("\n");
        sb.Append("  DeliveryDays: ").Append(DeliveryDays).Append("\n");
        sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
        sb.Append("  PackageType: ").Append(PackageType).Append("\n");
        sb.Append("  RequestedComparisonAmount: ").Append(RequestedComparisonAmount).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
        sb.Append("  Zone: ").Append(Zone).Append("\n");
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
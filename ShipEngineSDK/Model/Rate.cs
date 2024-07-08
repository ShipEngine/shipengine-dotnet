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
/// A rate
/// </summary>
[DataContract(Name = "rate")]
public partial class Rate
{

    /// <summary>
    /// Gets or Sets RateType
    /// </summary>
    [JsonPropertyName("rate_type")]
    [JsonRequired]
    public string RateType { get; set; } = ShipEngineSDK.Model.RateType.DefaultValue;
    

    /// <summary>
    /// Gets or Sets ValidationStatus
    /// </summary>
    [JsonPropertyName("validation_status")]
    [JsonRequired]
    public string ValidationStatus { get; set; } = ShipEngineSDK.Model.ValidationStatus.DefaultValue;
    

    /// <summary>
    /// A string that uniquely identifies the rate
    /// </summary>
    /// <value>A string that uniquely identifies the rate</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("rate_id")]
    [JsonRequired]
    public string RateId { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the carrier
    /// </summary>
    /// <value>A string that uniquely identifies the carrier</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    [JsonRequired]
    public string CarrierId { get; private set; }

    /// <summary>
    /// The shipping amount. Should be added with confirmation_amount, insurance_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The shipping amount. Should be added with confirmation_amount, insurance_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("shipping_amount")]
    [JsonRequired]
    public MonetaryValue ShippingAmount { get; private set; }

    /// <summary>
    /// The insurance amount.  Should be added with shipping_amount, confirmation_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The insurance amount.  Should be added with shipping_amount, confirmation_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("insurance_amount")]
    [JsonRequired]
    public MonetaryValue InsuranceAmount { get; private set; }

    /// <summary>
    /// The confirmation amount.  Should be added with shipping_amount, insurance_amount and other_amount to calculate the total purchase price.
    /// </summary>
    /// <value>The confirmation amount.  Should be added with shipping_amount, insurance_amount and other_amount to calculate the total purchase price.</value>
    [JsonPropertyName("confirmation_amount")]
    [JsonRequired]
    public MonetaryValue ConfirmationAmount { get; private set; }

    /// <summary>
    /// Any other charges associated with this rate.  Should be added with shipping_amount, insurance_amount and confirmation_amount to calculate the total purchase price.
    /// </summary>
    /// <value>Any other charges associated with this rate.  Should be added with shipping_amount, insurance_amount and confirmation_amount to calculate the total purchase price.</value>
    [JsonPropertyName("other_amount")]
    [JsonRequired]
    public MonetaryValue OtherAmount { get; private set; }

    /// <summary>
    /// The total shipping cost for the specified comparison_rate_type.
    /// </summary>
    /// <value>The total shipping cost for the specified comparison_rate_type.</value>
    [JsonPropertyName("requested_comparison_amount")]
    public MonetaryValue RequestedComparisonAmount { get; private set; }

    /// <summary>
    /// Tariff and additional taxes associated with an international shipment.
    /// </summary>
    /// <value>Tariff and additional taxes associated with an international shipment.</value>
    [JsonPropertyName("tax_amount")]
    public MonetaryValue TaxAmount { get; private set; }

    /// <summary>
    /// Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location 
    /// </summary>
    /// <value>Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location </value>
    /// <example>
    /// 6
    /// </example>
    [JsonPropertyName("zone")]
    [JsonRequired]
    public int? Zone { get; private set; }

    /// <summary>
    /// package type that this rate was estimated for
    /// </summary>
    /// <value>package type that this rate was estimated for</value>
    /// <example>
    /// package
    /// </example>
    [JsonPropertyName("package_type")]
    [JsonRequired]
    public string PackageType { get; private set; }

    /// <summary>
    /// The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday 
    /// </summary>
    /// <value>The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday </value>
    /// <example>
    /// 5
    /// </example>
    [JsonPropertyName("delivery_days")]
    public int DeliveryDays { get; private set; }

    /// <summary>
    /// Indicates if the rate is guaranteed.
    /// </summary>
    /// <value>Indicates if the rate is guaranteed.</value>
    [JsonPropertyName("guaranteed_service")]
    [JsonRequired]
    public bool GuaranteedService { get; private set; }

    /// <summary>
    /// An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine. 
    /// </summary>
    /// <value>An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine. </value>
    /// <example>
    /// 2018-09-23T00:00Z
    /// </example>
    [JsonPropertyName("estimated_delivery_date")]
    public DateTime EstimatedDeliveryDate { get; private set; }

    /// <summary>
    /// The carrier delivery days
    /// </summary>
    /// <value>The carrier delivery days</value>
    [JsonPropertyName("carrier_delivery_days")]
    public string CarrierDeliveryDays { get; private set; }

    /// <summary>
    /// ship date
    /// </summary>
    /// <value>ship date</value>
    [JsonPropertyName("ship_date")]
    public DateTime ShipDate { get; private set; }

    /// <summary>
    /// Indicates if the rates been negotiated
    /// </summary>
    /// <value>Indicates if the rates been negotiated</value>
    [JsonPropertyName("negotiated_rate")]
    [JsonRequired]
    public bool NegotiatedRate { get; private set; }

    /// <summary>
    /// service type
    /// </summary>
    /// <value>service type</value>
    [JsonPropertyName("service_type")]
    [JsonRequired]
    public string ServiceType { get; private set; }

    /// <summary>
    /// service code for the rate
    /// </summary>
    /// <value>service code for the rate</value>
    [JsonPropertyName("service_code")]
    [JsonRequired]
    public string ServiceCode { get; private set; }

    /// <summary>
    /// Indicates if rate is trackable
    /// </summary>
    /// <value>Indicates if rate is trackable</value>
    [JsonPropertyName("trackable")]
    [JsonRequired]
    public bool Trackable { get; private set; }

    /// <summary>
    /// carrier code
    /// </summary>
    /// <value>carrier code</value>
    [JsonPropertyName("carrier_code")]
    [JsonRequired]
    public string CarrierCode { get; private set; }

    /// <summary>
    /// carrier nickname
    /// </summary>
    /// <value>carrier nickname</value>
    [JsonPropertyName("carrier_nickname")]
    [JsonRequired]
    public string CarrierNickname { get; private set; }

    /// <summary>
    /// carrier friendly name
    /// </summary>
    /// <value>carrier friendly name</value>
    [JsonPropertyName("carrier_friendly_name")]
    [JsonRequired]
    public string CarrierFriendlyName { get; private set; }

    /// <summary>
    /// The warning messages
    /// </summary>
    /// <value>The warning messages</value>
    [JsonPropertyName("warning_messages")]
    [JsonRequired]
    public List<string> WarningMessages { get; private set; }

    /// <summary>
    /// The error messages
    /// </summary>
    /// <value>The error messages</value>
    [JsonPropertyName("error_messages")]
    [JsonRequired]
    public List<string> ErrorMessages { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Rate {\n");
        sb.Append("  RateId: ").Append(RateId).Append("\n");
        sb.Append("  RateType: ").Append(RateType).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ShippingAmount: ").Append(ShippingAmount).Append("\n");
        sb.Append("  InsuranceAmount: ").Append(InsuranceAmount).Append("\n");
        sb.Append("  ConfirmationAmount: ").Append(ConfirmationAmount).Append("\n");
        sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
        sb.Append("  RequestedComparisonAmount: ").Append(RequestedComparisonAmount).Append("\n");
        sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
        sb.Append("  Zone: ").Append(Zone).Append("\n");
        sb.Append("  PackageType: ").Append(PackageType).Append("\n");
        sb.Append("  DeliveryDays: ").Append(DeliveryDays).Append("\n");
        sb.Append("  GuaranteedService: ").Append(GuaranteedService).Append("\n");
        sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
        sb.Append("  CarrierDeliveryDays: ").Append(CarrierDeliveryDays).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  NegotiatedRate: ").Append(NegotiatedRate).Append("\n");
        sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
        sb.Append("  Trackable: ").Append(Trackable).Append("\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  CarrierNickname: ").Append(CarrierNickname).Append("\n");
        sb.Append("  CarrierFriendlyName: ").Append(CarrierFriendlyName).Append("\n");
        sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
        sb.Append("  WarningMessages: ").Append(WarningMessages).Append("\n");
        sb.Append("  ErrorMessages: ").Append(ErrorMessages).Append("\n");
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


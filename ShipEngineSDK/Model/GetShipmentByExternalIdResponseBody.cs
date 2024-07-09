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
/// A get shipment by external id response body
/// </summary>
//[DataContract(Name = "get_shipment_by_external_id_response_body")]
public partial class GetShipmentByExternalIdResponseBody
{

    /// <summary>
    /// The current status of the shipment  CLOVUS
    /// </summary>
    /// <value>The current status of the shipment</value>
    [JsonPropertyName("shipment_status")]
    [JsonRequired]
    public ShipmentStatus ShipmentStatus { get; set; } = new();


    /// <summary>
    /// The type of delivery confirmation that is required for this shipment.  CLOVUS
    /// </summary>
    /// <value>The type of delivery confirmation that is required for this shipment.</value>
    [JsonPropertyName("confirmation")]
    [JsonRequired]
    public DeliveryConfirmation Confirmation { get; set; } = new();


    /// <summary>
    /// The insurance provider to use for any insured packages in the shipment.   CLOVUS
    /// </summary>
    /// <value>The insurance provider to use for any insured packages in the shipment. </value>
    [JsonPropertyName("insurance_provider")]
    [JsonRequired]
    public InsuranceProvider InsuranceProvider { get; set; } = new();


    /// <summary>
    /// Gets or Sets OrderSourceCode  CLOVUS
    /// </summary>
    [JsonPropertyName("order_source_code")]
    public OrderSourceName? OrderSourceCode { get; set; }
    /// <summary>
    /// A string that uniquely identifies the shipment
    /// </summary>
    /// <value>A string that uniquely identifies the shipment</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipment_id")]
    [JsonRequired]
    public string ShipmentId { get; set; }

    /// <summary>
    /// The carrier account that is billed for the shipping charges
    /// </summary>
    /// <value>The carrier account that is billed for the shipping charges</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    [JsonRequired]
    public string CarrierId { get; set; }

    /// <summary>
    /// The [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) used to ship the package, such as &#x60;fedex_ground&#x60;, &#x60;usps_first_class_mail&#x60;, &#x60;flat_rate_envelope&#x60;, etc. 
    /// </summary>
    /// <value>The [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) used to ship the package, such as &#x60;fedex_ground&#x60;, &#x60;usps_first_class_mail&#x60;, &#x60;flat_rate_envelope&#x60;, etc. </value>
    /// <example>
    /// usps_first_class_mail
    /// </example>
    [JsonPropertyName("service_code")]
    [JsonRequired]
    public string ServiceCode { get; set; }

    /// <summary>
    /// ID of the shipping rule, which you want to use to automate carrier/carrier service selection for the shipment 
    /// </summary>
    /// <value>ID of the shipping rule, which you want to use to automate carrier/carrier service selection for the shipment </value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("shipping_rule_id")]
    public string ShippingRuleId { get; set; }

    /// <summary>
    /// ID that the Order Source assigned
    /// </summary>
    /// <value>ID that the Order Source assigned</value>
    [JsonPropertyName("external_order_id")]
    public string ExternalOrderId { get; set; }

    /// <summary>
    /// Describe the packages included in this shipment as related to potential metadata that was imported from external order sources 
    /// </summary>
    /// <value>Describe the packages included in this shipment as related to potential metadata that was imported from external order sources </value>
    [JsonPropertyName("items")]
    public List<ShipmentItem> Items { get; set; }

    /// <summary>
    /// Gets or Sets TaxIdentifiers
    /// </summary>
    [JsonPropertyName("tax_identifiers")]
    public List<TaxIdentifier> TaxIdentifiers { get; set; }

    /// <summary>
    /// A unique user-defined key to identify a shipment.  This can be used to retrieve the shipment.  &gt; **Warning:** The &#x60;external_shipment_id&#x60; is limited to 50 characters. Any additional characters will be truncated. 
    /// </summary>
    /// <value>A unique user-defined key to identify a shipment.  This can be used to retrieve the shipment.  &gt; **Warning:** The &#x60;external_shipment_id&#x60; is limited to 50 characters. Any additional characters will be truncated. </value>
    [JsonPropertyName("external_shipment_id")]
    public string ExternalShipmentId { get; set; }

    /// <summary>
    /// A non-unique user-defined number used to identify a shipment.  If undefined, this will match the external_shipment_id of the shipment.  &gt; **Warning:** The &#x60;shipment_number&#x60; is limited to 50 characters. Any additional characters will be truncated. 
    /// </summary>
    /// <value>A non-unique user-defined number used to identify a shipment.  If undefined, this will match the external_shipment_id of the shipment.  &gt; **Warning:** The &#x60;shipment_number&#x60; is limited to 50 characters. Any additional characters will be truncated. </value>
    [JsonPropertyName("shipment_number")]
    public string ShipmentNumber { get; set; }

    /// <summary>
    /// The date that the shipment was (or will be) shippped.  ShipEngine will take the day of week into consideration. For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead. 
    /// </summary>
    /// <value>The date that the shipment was (or will be) shippped.  ShipEngine will take the day of week into consideration. For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead. </value>
    /// <example>
    /// 2018-09-23T00:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    [JsonRequired]
    public DateTime ShipDate { get; set; }

    /// <summary>
    /// The date and time that the shipment was created in ShipEngine.
    /// </summary>
    /// <value>The date and time that the shipment was created in ShipEngine.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at")]
    [JsonRequired]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The date and time that the shipment was created or last modified.
    /// </summary>
    /// <value>The date and time that the shipment was created or last modified.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("modified_at")]
    [JsonRequired]
    public DateTime ModifiedAt { get; set; }

    /// <summary>
    /// The recipient&#39;s mailing address
    /// </summary>
    /// <value>The recipient&#39;s mailing address</value>
    [JsonPropertyName("ship_to")]
    [JsonRequired]
    public ShippingAddressTo ShipTo { get; set; }

    /// <summary>
    /// The shipment&#39;s origin address. If you frequently ship from the same location, consider [creating a warehouse](https://www.shipengine.com/docs/reference/create-warehouse/).  Then you can simply specify the &#x60;warehouse_id&#x60; rather than the complete address each time. 
    /// </summary>
    /// <value>The shipment&#39;s origin address. If you frequently ship from the same location, consider [creating a warehouse](https://www.shipengine.com/docs/reference/create-warehouse/).  Then you can simply specify the &#x60;warehouse_id&#x60; rather than the complete address each time. </value>
    [JsonPropertyName("ship_from")]
    [JsonRequired]
    public ShippingAddress ShipFrom { get; set; }

    /// <summary>
    /// The [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) that the shipment is being shipped from.  Either &#x60;warehouse_id&#x60; or &#x60;ship_from&#x60; must be specified. 
    /// </summary>
    /// <value>The [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) that the shipment is being shipped from.  Either &#x60;warehouse_id&#x60; or &#x60;ship_from&#x60; must be specified. </value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id")]
    [JsonRequired]
    public string WarehouseId { get; set; }

    /// <summary>
    /// The return address for this shipment.  Defaults to the &#x60;ship_from&#x60; address. 
    /// </summary>
    /// <value>The return address for this shipment.  Defaults to the &#x60;ship_from&#x60; address. </value>
    [JsonPropertyName("return_to")]
    [JsonRequired]
    public ShippingAddress ReturnTo { get; set; }

    /// <summary>
    /// An optional indicator if the shipment is intended to be a return. Defaults to false if not provided. 
    /// </summary>
    /// <value>An optional indicator if the shipment is intended to be a return. Defaults to false if not provided. </value>
    [JsonPropertyName("is_return")]
    public bool? IsReturn { get; set; }

    /// <summary>
    /// Customs information.  This is usually only needed for international shipments. 
    /// </summary>
    /// <value>Customs information.  This is usually only needed for international shipments. </value>
    [JsonPropertyName("customs")]
    [JsonRequired]
    public InternationalShipmentOptions Customs { get; set; }

    /// <summary>
    /// Advanced shipment options.  These are entirely optional.
    /// </summary>
    /// <value>Advanced shipment options.  These are entirely optional.</value>
    [JsonPropertyName("advanced_options")]
    [JsonRequired]
    public AdvancedShipmentOptions AdvancedOptions { get; set; }

    /// <summary>
    /// Arbitrary tags associated with this shipment.  Tags can be used to categorize shipments, and shipments can be queried by their tags. 
    /// </summary>
    /// <value>Arbitrary tags associated with this shipment.  Tags can be used to categorize shipments, and shipments can be queried by their tags. </value>
    [JsonPropertyName("tags")]
    [JsonRequired]
    public List<Tag> Tags { get; set; }

    /// <summary>
    /// The packages in the shipment.  &gt; **Note:** Some carriers only allow one package per shipment.  If you attempt to create a multi-package shipment for a carrier that doesn&#39;t allow it, an error will be returned. 
    /// </summary>
    /// <value>The packages in the shipment.  &gt; **Note:** Some carriers only allow one package per shipment.  If you attempt to create a multi-package shipment for a carrier that doesn&#39;t allow it, an error will be returned. </value>
    [JsonPropertyName("packages")]
    [JsonRequired]
    public List<Package> Packages { get; set; }

    /// <summary>
    /// The combined weight of all packages in the shipment
    /// </summary>
    /// <value>The combined weight of all packages in the shipment</value>
    [JsonPropertyName("total_weight")]
    [JsonRequired]
    public Weight TotalWeight { get; set; }

    /// <summary>
    /// Calculate a rate for this shipment with the requested carrier using a ratecard that differs from the default.  Only supported for UPS and USPS.
    /// </summary>
    /// <value>Calculate a rate for this shipment with the requested carrier using a ratecard that differs from the default.  Only supported for UPS and USPS.</value>
    /// <example>
    /// retail
    /// </example>
    [JsonPropertyName("comparison_rate_type")]
    public string ComparisonRateType { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetShipmentByExternalIdResponseBody {\n");
        sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
        sb.Append("  ShippingRuleId: ").Append(ShippingRuleId).Append("\n");
        sb.Append("  ExternalOrderId: ").Append(ExternalOrderId).Append("\n");
        sb.Append("  Items: ").Append(Items).Append("\n");
        sb.Append("  TaxIdentifiers: ").Append(TaxIdentifiers).Append("\n");
        sb.Append("  ExternalShipmentId: ").Append(ExternalShipmentId).Append("\n");
        sb.Append("  ShipmentNumber: ").Append(ShipmentNumber).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
        sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
        sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
        sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  ReturnTo: ").Append(ReturnTo).Append("\n");
        sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
        sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
        sb.Append("  Customs: ").Append(Customs).Append("\n");
        sb.Append("  AdvancedOptions: ").Append(AdvancedOptions).Append("\n");
        sb.Append("  InsuranceProvider: ").Append(InsuranceProvider).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  OrderSourceCode: ").Append(OrderSourceCode).Append("\n");
        sb.Append("  Packages: ").Append(Packages).Append("\n");
        sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
        sb.Append("  ComparisonRateType: ").Append(ComparisonRateType).Append("\n");
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
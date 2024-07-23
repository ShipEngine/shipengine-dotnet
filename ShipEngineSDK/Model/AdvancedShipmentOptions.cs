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
/// Advanced shipment options
/// </summary>
public partial class AdvancedShipmentOptions
{

    /// <summary>
    /// Indicate to the carrier that this shipment requires additional handling. 
    /// </summary>
    /// <value>Indicate to the carrier that this shipment requires additional handling. </value>
    [JsonPropertyName("additional_handling"), JsonPropertyOrder(1)]
    public bool? AdditionalHandling { get; set; }

    /// <summary>
    /// This field is used to [bill shipping costs to a third party](https://www.shipengine.com/docs/shipping/bill-to-third-party/).  This field must be used in conjunction with the &#x60;bill_to_country_code&#x60;, &#x60;bill_to_party&#x60;, and &#x60;bill_to_postal_code&#x60; fields. 
    /// </summary>
    /// <value>This field is used to [bill shipping costs to a third party](https://www.shipengine.com/docs/shipping/bill-to-third-party/).  This field must be used in conjunction with the &#x60;bill_to_country_code&#x60;, &#x60;bill_to_party&#x60;, and &#x60;bill_to_postal_code&#x60; fields. </value>
    [JsonPropertyName("bill_to_account"), JsonPropertyOrder(2)]
    public string? BillToAccount { get; set; }

    /// <summary>
    /// The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the third-party that is responsible for shipping costs. 
    /// </summary>
    /// <value>The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the third-party that is responsible for shipping costs. </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("bill_to_country_code"), JsonPropertyOrder(3)]
    public string? BillToCountryCode { get; set; }

    /// <summary>
    /// Indicates whether to bill shipping costs to the recipient or to a third-party.  When billing to a third-party, the &#x60;bill_to_account&#x60;, &#x60;bill_to_country_code&#x60;, and &#x60;bill_to_postal_code&#x60; fields must also be set. 
    /// </summary>
    /// <value>Indicates whether to bill shipping costs to the recipient or to a third-party.  When billing to a third-party, the &#x60;bill_to_account&#x60;, &#x60;bill_to_country_code&#x60;, and &#x60;bill_to_postal_code&#x60; fields must also be set. </value>
    [JsonPropertyName("bill_to_party"), JsonPropertyOrder(4)]
    public BillToParty? BillToParty { get; set; }

    /// <summary>
    /// The postal code of the third-party that is responsible for shipping costs. 
    /// </summary>
    /// <value>The postal code of the third-party that is responsible for shipping costs. </value>
    [JsonPropertyName("bill_to_postal_code"), JsonPropertyOrder(5)]
    public string? BillToPostalCode { get; set; }

    /// <summary>
    /// Gets or Sets CollectOnDelivery
    /// </summary>
    [JsonPropertyName("collect_on_delivery"), JsonPropertyOrder(6)]
    public CollectOnDelivery? CollectOnDelivery { get; set; }

    /// <summary>
    /// Indicates that the shipment contains alcohol.
    /// </summary>
    /// <value>Indicates that the shipment contains alcohol.</value>
    [JsonPropertyName("contains_alcohol"), JsonPropertyOrder(7)]
    public bool? ContainsAlcohol { get; set; }

    /// <summary>
    /// An arbitrary field that can be used to store information about the shipment. 
    /// </summary>
    /// <value>An arbitrary field that can be used to store information about the shipment. </value>
    [JsonPropertyName("custom_field1"), JsonPropertyOrder(8)]
    public string? CustomField1 { get; set; }

    /// <summary>
    /// An arbitrary field that can be used to store information about the shipment. 
    /// </summary>
    /// <value>An arbitrary field that can be used to store information about the shipment. </value>
    [JsonPropertyName("custom_field2"), JsonPropertyOrder(9)]
    public string? CustomField2 { get; set; }

    /// <summary>
    /// An arbitrary field that can be used to store information about the shipment. 
    /// </summary>
    /// <value>An arbitrary field that can be used to store information about the shipment. </value>
    [JsonPropertyName("custom_field3"), JsonPropertyOrder(10)]
    public string? CustomField3 { get; set; }

    /// <summary>
    /// Indicates if the Dangerous goods are present in the shipment
    /// </summary>
    /// <value>Indicates if the Dangerous goods are present in the shipment</value>
    [JsonPropertyName("dangerous_goods"), JsonPropertyOrder(11)]
    public bool? DangerousGoods { get; set; }

    /// <summary>
    /// Gets or Sets DangerousGoodsContact
    /// </summary>
    [JsonPropertyName("dangerous_goods_contact"), JsonPropertyOrder(12)]
    public AdvancedShipmentOptionsDangerousGoodsContact? DangerousGoodsContact { get; set; }

    /// <summary>
    /// Indicates that the shipper is paying the international delivery duties for this shipment.  This option is supported by UPS, FedEx, and DHL Express. 
    /// </summary>
    /// <value>Indicates that the shipper is paying the international delivery duties for this shipment.  This option is supported by UPS, FedEx, and DHL Express. </value>
    [JsonPropertyName("delivered_duty_paid"), JsonPropertyOrder(13)]
    public bool? DeliveredDutyPaid { get; set; }

    /// <summary>
    /// Indicates if the shipment contain dry ice
    /// </summary>
    /// <value>Indicates if the shipment contain dry ice</value>
    [JsonPropertyName("dry_ice"), JsonPropertyOrder(14)]
    public bool? DryIce { get; set; }

    /// <summary>
    /// The weight of the dry ice in the shipment
    /// </summary>
    /// <value>The weight of the dry ice in the shipment</value>
    [JsonPropertyName("dry_ice_weight"), JsonPropertyOrder(15)]
    public Weight? DryIceWeight { get; set; }

    /// <summary>
    /// Gets or Sets FedexFreight
    /// </summary>
    [JsonPropertyName("fedex_freight"), JsonPropertyOrder(16)]
    public AdvancedShipmentOptionsFedexFreight? FedexFreight { get; set; }

    /// <summary>
    /// The National Motor Freight Traffic Association [freight class](http://www.nmfta.org/pages/nmfc?AspxAutoDetectCookieSupport&#x3D;1), such as \&quot;77.5\&quot;, \&quot;110\&quot;, or \&quot;250\&quot;. 
    /// </summary>
    /// <value>The National Motor Freight Traffic Association [freight class](http://www.nmfta.org/pages/nmfc?AspxAutoDetectCookieSupport&#x3D;1), such as \&quot;77.5\&quot;, \&quot;110\&quot;, or \&quot;250\&quot;. </value>
    /// <example>
    /// 77.5
    /// </example>
    [JsonPropertyName("freight_class"), JsonPropertyOrder(17)]
    public string? FreightClass { get; set; }

    /// <summary>
    /// Indicates that the package cannot be processed automatically because it is too large or irregularly shaped. This is primarily for USPS shipments.  See [Section 1.2 of the USPS parcel standards](https://pe.usps.com/text/dmm300/101.htm#ep1047495) for details. 
    /// </summary>
    /// <value>Indicates that the package cannot be processed automatically because it is too large or irregularly shaped. This is primarily for USPS shipments.  See [Section 1.2 of the USPS parcel standards](https://pe.usps.com/text/dmm300/101.htm#ep1047495) for details. </value>
    [JsonPropertyName("non_machinable"), JsonPropertyOrder(18)]
    public bool? NonMachinable { get; set; }

    /// <summary>
    /// Gets or Sets OriginType
    /// </summary>
    [JsonPropertyName("origin_type"), JsonPropertyOrder(19)]
    public OriginType? OriginType { get; set; }

    /// <summary>
    /// Enables Saturday delivery, if supported by the carrier.
    /// </summary>
    /// <value>Enables Saturday delivery, if supported by the carrier.</value>
    [JsonPropertyName("saturday_delivery"), JsonPropertyOrder(20)]
    public bool? SaturdayDelivery { get; set; }

    /// <summary>
    /// Gets or Sets ShipperRelease
    /// </summary>
    [JsonPropertyName("shipper_release"), JsonPropertyOrder(21)]
    public bool? ShipperRelease { get; set; }

    /// <summary>
    /// Third Party Consignee option is a value-added service that allows the shipper to supply goods without commercial invoices being attached
    /// </summary>
    /// <value>Third Party Consignee option is a value-added service that allows the shipper to supply goods without commercial invoices being attached</value>
    [JsonPropertyName("third_party_consignee"), JsonPropertyOrder(22)]
    public bool? ThirdPartyConsignee { get; set; }

    /// <summary>
    /// Whether to use [UPS Ground Freight pricing](https://www.shipengine.com/docs/shipping/ups-ground-freight/).  If enabled, then a &#x60;freight_class&#x60; must also be specified. 
    /// </summary>
    /// <value>Whether to use [UPS Ground Freight pricing](https://www.shipengine.com/docs/shipping/ups-ground-freight/).  If enabled, then a &#x60;freight_class&#x60; must also be specified. </value>
    [JsonPropertyName("use_ups_ground_freight_pricing"), JsonPropertyOrder(23)]
    public bool? UseUpsGroundFreightPricing { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdvancedShipmentOptions {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AdditionalHandling: ").Append(AdditionalHandling).Append("\n");
        sb.Append("  BillToAccount: ").Append(BillToAccount).Append("\n");
        sb.Append("  BillToCountryCode: ").Append(BillToCountryCode).Append("\n");
        sb.Append("  BillToParty: ").Append(BillToParty).Append("\n");
        sb.Append("  BillToPostalCode: ").Append(BillToPostalCode).Append("\n");
        sb.Append("  CollectOnDelivery: ").Append(CollectOnDelivery).Append("\n");
        sb.Append("  ContainsAlcohol: ").Append(ContainsAlcohol).Append("\n");
        sb.Append("  CustomField1: ").Append(CustomField1).Append("\n");
        sb.Append("  CustomField2: ").Append(CustomField2).Append("\n");
        sb.Append("  CustomField3: ").Append(CustomField3).Append("\n");
        sb.Append("  DangerousGoods: ").Append(DangerousGoods).Append("\n");
        sb.Append("  DangerousGoodsContact: ").Append(DangerousGoodsContact).Append("\n");
        sb.Append("  DeliveredDutyPaid: ").Append(DeliveredDutyPaid).Append("\n");
        sb.Append("  DryIce: ").Append(DryIce).Append("\n");
        sb.Append("  DryIceWeight: ").Append(DryIceWeight).Append("\n");
        sb.Append("  FedexFreight: ").Append(FedexFreight).Append("\n");
        sb.Append("  FreightClass: ").Append(FreightClass).Append("\n");
        sb.Append("  NonMachinable: ").Append(NonMachinable).Append("\n");
        sb.Append("  OriginType: ").Append(OriginType).Append("\n");
        sb.Append("  SaturdayDelivery: ").Append(SaturdayDelivery).Append("\n");
        sb.Append("  ShipperRelease: ").Append(ShipperRelease).Append("\n");
        sb.Append("  ThirdPartyConsignee: ").Append(ThirdPartyConsignee).Append("\n");
        sb.Append("  UseUpsGroundFreightPricing: ").Append(UseUpsGroundFreightPricing).Append("\n");
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
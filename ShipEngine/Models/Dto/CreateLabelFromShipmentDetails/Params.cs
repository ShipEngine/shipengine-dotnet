using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Params
{
    public class LabelParams
    {
        /**
         * The shipment information used to generate the label
         */
        [JsonPropertyName("shipment")]

        public Shipment? Shipment { get; set; }

        /**
         * Indicates whether this is a return label. You may also want to set the rmaNumber so you know what is being returned.
         */
        [JsonPropertyName("is_return_label")]

        public bool? IsReturnLabel { get; set; }

        /**
         * An optional Return Merchandise Authorization number. This field is useful for return labels. You can set it to any string value.
         */
        [JsonPropertyName("rma_number")]

        public string? RMANumber { get; set; }

        /**
         * Enum: "carrierDefault" "onCreation" "onCarrierAcceptance". The label charge event.
         */
        //TODO: Enum?
        [JsonPropertyName("charge_event")]

        public string? ChargeEvent { get; set; }

        /**
         * The labelId of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.
         */
        [JsonPropertyName("outbound_label_id")]

        public string? OutboundLabelId { get; set; }

        /**
         * Default: "validateAndClean"
         * Enum: "noValidation" "validateOnly" "validateAndClean"
         * The possible validate address values
         */
        [JsonPropertyName("validate_address")]

        public string? ValidateAddress { get; set; }

        /**
         * Default: "url"
         * Enum: "url" "inline"
         * There are two different ways to download a label:
         */
        // TODO: Enum?
        [JsonPropertyName("label_download_type")]

        public string? LabelDownloadType { get; set; }

        /**
         * The file format that you want the label to be in. We recommend pdf format because it is supported by all carriers, whereas some carriers do not support the png or zpl formats.
         */
        // TODO: Enum?
        [JsonPropertyName("label_format")]

        public string? LabelFormat { get; set; }
        /**
         * The display format that the label should be shown in.
         */
        //TODO: Enum?
        [JsonPropertyName("display_scheme")]

        public string? DisplayScheme { get; set; }

        /**
         * The layout (size) that you want the label to be in. The labelFormat determines which sizes are allowed. 4x6 is supported for all label formats, whereas letter (8.5" x 11") is only supported for pdf format.
         */
        //TODO: Enum?
        [JsonPropertyName("label_layout")]

        public string? LabelLayout { get; set; }

        /**
         * The label image resource that was used to create a custom label image.
         */
        [JsonPropertyName("label_image_id")]

        public string? LabelImageId { get; set; }
    }

    public class Shipment
    {
        /**
         * The carrier account that is billed for the shipping charges
         */
        [JsonPropertyName("carrier_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CarrierId { get; set; }

        /**
         * The carrier service used to ship the package, such as fedexGround, uspsFirstClassMail, flatRateEnvelope, etc.
         */
        [JsonPropertyName("service_code")]

        public string? ServiceCode { get; set; }

        /**
         * ID that the Order Source assigned
         */
        [JsonPropertyName("external_order_id")]
        public string? ExternalOrderId { get; set; }

        /**
         * Describe the packages included in this shipment as related to potential metadata that was imported from external order sources
         */
        [JsonPropertyName("items")]

        public List<ShipmentItem>? Items { get; set; }

        /**
         * Array of tax identifiers
         */
        [JsonPropertyName("tax_identifiers")]

        public List<TaxIdentifier>? TaxIdentifiers { get; set; }

        /**
         * You can optionally use this field to store your own identifier for this shipment.
         */
        [JsonPropertyName("external_shipment_id")]
        public string? ExternalShipmentId { get; set; }

        /**
         * The date that the shipment was(or will be) shipped. ShipEngine will take the day of week into consideration.For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
         */
        [JsonPropertyName("ship_date")]

        public string? ShipDate { get; set; }

        /**
         * The recipient's mailing address
         */
        [JsonPropertyName("ship_to")]

        public Address? ShipTo { get; set; }

        /**
         * The shipment's origin address. If you frequently ship from the same location, consider creating a warehouse. Then you can simply specify the warehouseId rather than the complete address each time.
         */
        [JsonPropertyName("ship_from")]

        public Address ShipFrom { get; set; }

        /**
         * The warehouse that the shipment is being shipped from. Either warehouseId or shipFrom must be specified.
         */
        [JsonPropertyName("warehouse_id")]

        public string? WarehouseId { get; set; }

        /**
         * The return address for this shipment. Defaults to the shipFrom address.
         */
        [JsonPropertyName("return_to")]

        public Address? ReturnTo { get; set; }

        /**
         * The type of delivery confirmation that is required for this shipment.
         */
        // TODO: Enum?

        [JsonPropertyName("confirmation")]
        public string? Confirmation { get; set; }

        /**
         * Customs information. This is usually only needed for international shipments.
         */
        [JsonPropertyName("customs")]

        public InternationalShipmentOptions? Customs { get; set; }

        /**
         * Advanced shipment options. These are entirely optional.
         */
        [JsonPropertyName("advanced_options")]

        public AdvancedShipmentOptions? AdvancedOptions { get; set; }

        /**
         * Indicates if the package will be picked up or dropped off by the carrier
         */
        //TODO: ENum?
        [JsonPropertyName("origin_type")]

        public string? OriginType { get; set; }

        /**
         * The insurance provider to use for any insured packages in the shipment
         */
        //TODO: ENum?
        [JsonPropertyName("insurance_provider")]

        public string? InsuranceProvider { get; set; }

        /**
         * The order sources that are supported by ShipEngine
         */
        // TODO: Enum?
        [JsonPropertyName("order_source_code")]

        public string? OrderSourceCode { get; set; }

        /**
        * The packages in the shipment.
*/
        [JsonPropertyName("packages")]

        public List<Package>? Packages { get; set; }
    }

    public class Package
    {
        [JsonPropertyName("package_code")]
        public string? PackageCode { get; set; }
        [JsonPropertyName("weight")]

        public Weight? Weight { get; set; }
        [JsonPropertyName("dimensions")]

        public Dimensions? Dimensions { get; set; }
        [JsonPropertyName("insured_value")]

        public MonetaryValue? InsuredValue { get; set; }
        [JsonPropertyName("label_messages")]

        public LabelMessages? LabelMessages { get; set; }
        [JsonPropertyName("external_package_id")]

        public string? ExternalPackageId { get; set; }
    }

    public class LabelMessages
    {
        [JsonPropertyName("reference1")]

        public string? Reference1 { get; set; }
        [JsonPropertyName("reference2")]

        public string? Reference2 { get; set; }
        [JsonPropertyName("reference3")]

        public string? Reference3 { get; set; }
    }

    public class Dimensions
    {
        // TODO: Enum?
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
        [JsonPropertyName("length")]

        public double? Length { get; set; }
        [JsonPropertyName("width")]

        public double? Width { get; set; }
        [JsonPropertyName("height")]

        public double? Height { get; set; }
    }

    public class ShipmentItem
    {
        [JsonPropertyName("name")]

        public string? Name { get; set; }
        [JsonPropertyName("sales_order_id")]

        public string? SalesOrderId { get; set; }
        [JsonPropertyName("sales_order_item_id")]

        public string? SalesOrderItemId { get; set; }
        [JsonPropertyName("quantity")]

        public double? Quantity { get; set; }
        [JsonPropertyName("sku")]

        public string? Sku { get; set; }
        [JsonPropertyName("external_order_id")]

        public string? ExternalOrderId { get; set; }
        [JsonPropertyName("external_order_item_id")]

        public string? ExternalOrderItemId { get; set; }
        [JsonPropertyName("asin")]

        public string? Asin { get; set; }

        //TODO: Enum?
        [JsonPropertyName("order_source_code")]

        public string? OrderSourceCode { get; set; }
    }
    public class TaxIdentifier
    {
        //TODO: Enum?
        [JsonPropertyName("taxable_entity_type")]

        public string? TaxableEntityType { get; set; }
        //TODO: Enum?
        [JsonPropertyName("identifier_type")]

        public string? IdentifierType { get; set; }
        [JsonPropertyName("issuing_authority")]

        public string? IssuingAuthority { get; set; }
        [JsonPropertyName("value")]

        public string? Value { get; set; }
    }
    public class Address
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("address_line1")]
        public string? AddressLine1 { get; set; }

        [JsonPropertyName("address_line2")]
        public string? AddressLine2 { get; set; }

        [JsonPropertyName("address_line3")]
        public string? AddressLine3 { get; set; }

        [JsonPropertyName("city_locality")]
        public string? CityLocality { get; set; }

        [JsonPropertyName("state_province")]
        public string? StateProvince { get; set; }

        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("address_residential_indicator")]
        public string? AddressResidentialIndicator { get; set; } = "unknown";
    }

    public class InternationalShipmentOptions
    {
        //TODO: Enum?
        [JsonPropertyName("contents")]
        public string? Contents { get; set; }

        //TODO: Enum?
        [JsonPropertyName("non_delivery")]
        public string? NonDelivery { get; set; }

        [JsonPropertyName("customs_items")]
        public List<CustomsItem>? CustomsItems { get; set; }
    }
    public class CustomsItem
    {
        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("value")]
        public MonetaryValue? Value { get; set; }

        [JsonPropertyName("harmonzied_tariff_code")]
        public string? HarmonizedTariffCode { get; set; }

        // TODO: Enum
        [JsonPropertyName("country_of_origin")]
        public string? CountryOfOrigin { get; set; }

        [JsonPropertyName("unit_of_measure")]
        public string? UnitOfMeasure { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("sku_description")]
        public string? SkuDescription { get; set; }
    }
    public class MonetaryValue
    {
        //TODO: enum?
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }
    }
    public class AdvancedShipmentOptions
    {
        [JsonPropertyName("bill_to_account")]
        public string? BillToAccount { get; set; }

        [JsonPropertyName("bill_to_country_code")]
        public string? BillToCountryCode { get; set; }

        // TODO: Enum?
        [JsonPropertyName("bill_to_party")]
        public string? BillToParty { get; set; }

        [JsonPropertyName("bill_to_postal_code")]
        public string? BillToPostalCode { get; set; }

        [JsonPropertyName("contains_alcohol")]
        public bool? ContainsAlcohol { get; set; }

        [JsonPropertyName("delivered_duty_paid")]
        public bool? DeliveredDutyPaid { get; set; }

        [JsonPropertyName("dry_ice")]
        public bool? DryIce { get; set; }

        [JsonPropertyName("dry_ice_weight")]
        public Weight? DryIceWeight { get; set; }

        [JsonPropertyName("non_machinable")]
        public bool? NonMachinable { get; set; }

        [JsonPropertyName("saturday_delivery")]
        public bool? SaturdayDelivery { get; set; }

        [JsonPropertyName("use_ups_ground_freight_pricing")]
        public bool? UseUpsGroundFreightPricing { get; set; }

        [JsonPropertyName("freight_class")]
        public string? FreightClass { get; set; }

        [JsonPropertyName("custom_field1")]
        public string? CustomField1 { get; set; }

        [JsonPropertyName("custom_field2")]
        public string? CustomField2 { get; set; }

        [JsonPropertyName("custom_field3")]
        public string? CustomField3 { get; set; }

        // TODO: enum?
        [JsonPropertyName("origin_type")]
        public string? OriginType { get; set; }

        [JsonPropertyName("shipper_release")]
        public bool? ShipperRelease { get; set; }

        [JsonPropertyName("collect_on_delivery")]
        public CollectOnDelivery? CollectOnDelivery { get; set; }
    }
    public class Weight
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }
        //TODO: Enum?

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }
    public class CollectOnDelivery
    {
        // TODO: Enum?
        [JsonPropertyName("payment_type")]
        public string? PaymentType { get; set; }

        [JsonPropertyName("payment_amount")]
        public PaymentAmount? PaymentAmount { get; set; }
    }

    public class PaymentAmount
    {
        // TODO: Enum?
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }
    }
}

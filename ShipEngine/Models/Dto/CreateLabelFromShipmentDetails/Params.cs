using System.Collections.Generic;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Params
{
    public class LabelParams
    {
        /**
         * The shipment information used to generate the label
         */

        public Shipment? Shipment { get; set; }

        /**
         * Indicates whether this is a return label. You may also want to set the rmaNumber so you know what is being returned.
         */

        public bool? IsReturnLabel { get; set; }

        /**
         * An optional Return Merchandise Authorization number. This field is useful for return labels. You can set it to any string value.
         */

        public string? RMANumber { get; set; }

        /**
         * Enum: "carrierDefault" "onCreation" "onCarrierAcceptance". The label charge event.
         */
        //TODO: Enum?

        public string? ChargeEvent { get; set; }

        /**
         * The labelId of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.
         */

        public string? OutboundLabelId { get; set; }

        /**
         * Default: "validateAndClean"
         * Enum: "noValidation" "validateOnly" "validateAndClean"
         * The possible validate address values
         */

        public string? ValidateAddress { get; set; }

        /**
         * Default: "url"
         * Enum: "url" "inline"
         * There are two different ways to download a label:
         */
        // TODO: Enum?

        public string? LabelDownloadType { get; set; }

        /**
         * The file format that you want the label to be in. We recommend pdf format because it is supported by all carriers, whereas some carriers do not support the png or zpl formats.
         */
        // TODO: Enum?

        public string? LabelFormat { get; set; }
        /**
         * The display format that the label should be shown in.
         */
        //TODO: Enum?

        public string? DisplayScheme { get; set; }

        /**
         * The layout (size) that you want the label to be in. The labelFormat determines which sizes are allowed. 4x6 is supported for all label formats, whereas letter (8.5" x 11") is only supported for pdf format.
         */
        //TODO: Enum?

        public string? LabelLayout { get; set; }

        /**
         * The label image resource that was used to create a custom label image.
         */

        public string? LabelImageId { get; set; }
    }

    public class Shipment
    {
        /**
         * The carrier account that is billed for the shipping charges
         */
        public string? CarrierId { get; set; }

        /**
         * The carrier service used to ship the package, such as fedexGround, uspsFirstClassMail, flatRateEnvelope, etc.
         */

        public string? ServiceCode { get; set; }

        /**
         * ID that the Order Source assigned
         */
        public string? ExternalOrderId { get; set; }

        /**
         * Describe the packages included in this shipment as related to potential metadata that was imported from external order sources
         */

        public List<ShipmentItem>? Items { get; set; }

        /**
         * Array of tax identifiers
         */

        public List<TaxIdentifier>? TaxIdentifiers { get; set; }

        /**
         * You can optionally use this field to store your own identifier for this shipment.
         */
        public string? ExternalShipmentId { get; set; }

        /**
         * The date that the shipment was(or will be) shipped. ShipEngine will take the day of week into consideration.For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
         */

        public string? ShipDate { get; set; }

        /**
         * The recipient's mailing address
         */

        public Address? ShipTo { get; set; }

        /**
         * The shipment's origin address. If you frequently ship from the same location, consider creating a warehouse. Then you can simply specify the warehouseId rather than the complete address each time.
         */

        public Address ShipFrom { get; set; }

        /**
         * The warehouse that the shipment is being shipped from. Either warehouseId or shipFrom must be specified.
         */

        public string? WarehouseId { get; set; }

        /**
         * The return address for this shipment. Defaults to the shipFrom address.
         */

        public Address? ReturnTo { get; set; }

        /**
         * The type of delivery confirmation that is required for this shipment.
         */
        // TODO: Enum?

        public string? Confirmation { get; set; }

        /**
         * Customs information. This is usually only needed for international shipments.
         */

        public InternationalShipmentOptions? Customs { get; set; }

        /**
         * Advanced shipment options. These are entirely optional.
         */

        public AdvancedShipmentOptions? AdvancedOptions { get; set; }

        /**
         * Indicates if the package will be picked up or dropped off by the carrier
         */
        //TODO: ENum?

        public string? OriginType { get; set; }

        /**
         * The insurance provider to use for any insured packages in the shipment
         */
        //TODO: ENum?

        public string? InsuranceProvider { get; set; }

        /**
         * The order sources that are supported by ShipEngine
         */
        // TODO: Enum?

        public string? OrderSourceCode { get; set; }

        /**
        * The packages in the shipment.
*/

        public List<Package>? Packages { get; set; }
    }

    public class Package
    {
        public string? PackageCode { get; set; }

        public Weight? Weight { get; set; }

        public Dimensions? Dimensions { get; set; }

        public MonetaryValue? InsuredValue { get; set; }

        public LabelMessages? LabelMessages { get; set; }

        public string? ExternalPackageId { get; set; }
    }

    public class LabelMessages
    {

        public string? Reference1 { get; set; }

        public string? Reference2 { get; set; }

        public string? Reference3 { get; set; }
    }

    public class Dimensions
    {
        // TODO: Enum?
        public string? Unit { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }
    }

    public class ShipmentItem
    {

        public string? Name { get; set; }

        public string? SalesOrderId { get; set; }

        public string? SalesOrderItemId { get; set; }

        public double? Quantity { get; set; }

        public string? Sku { get; set; }

        public string? ExternalOrderId { get; set; }

        public string? ExternalOrderItemId { get; set; }

        public string? Asin { get; set; }

        //TODO: Enum?

        public string? OrderSourceCode { get; set; }
    }
    public class TaxIdentifier
    {
        //TODO: Enum?

        public string? TaxableEntityType { get; set; }
        //TODO: Enum?

        public string? IdentifierType { get; set; }

        public string? IssuingAuthority { get; set; }

        public string? Value { get; set; }
    }
    public class Address
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? CompanyName { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? AddressLine3 { get; set; }

        public string? CityLocality { get; set; }

        public string? StateProvince { get; set; }

        public string? PostalCode { get; set; }

        public string? CountryCode { get; set; }

        public string? AddressResidentialIndicator { get; set; } = "unknown";
    }

    public class InternationalShipmentOptions
    {
        //TODO: Enum?
        public string? Contents { get; set; }

        //TODO: Enum?
        public string? NonDelivery { get; set; }

        public List<CustomsItem>? CustomsItems { get; set; }
    }
    public class CustomsItem
    {
        public double? Quantity { get; set; }

        public MonetaryValue? Value { get; set; }

        public string? HarmonizedTariffCode { get; set; }

        // TODO: Enum
        public string? CountryOfOrigin { get; set; }

        public string? UnitOfMeasure { get; set; }

        public string? Sku { get; set; }

        public string? SkuDescription { get; set; }
    }
    public class MonetaryValue
    {
        //TODO: enum?
        public string? Currency { get; set; }

        public double? Amount { get; set; }
    }
    public class AdvancedShipmentOptions
    {
        public string? BillToAccount { get; set; }

        public string? BillToCountryCode { get; set; }

        // TODO: Enum?
        public string? BillToParty { get; set; }

        public string? BillToPostalCode { get; set; }

        public bool? ContainsAlcohol { get; set; }

        public bool? DeliveredDutyPaid { get; set; }

        public bool? DryIce { get; set; }

        public Weight? DryIceWeight { get; set; }

        public bool? NonMachinable { get; set; }

        public bool? SaturdayDelivery { get; set; }

        public bool? UseUpsGroundFreightPricing { get; set; }

        public string? FreightClass { get; set; }

        public string? CustomField1 { get; set; }

        public string? CustomField2 { get; set; }

        public string? CustomField3 { get; set; }

        // TODO: enum?
        public string? OriginType { get; set; }

        public bool? ShipperRelease { get; set; }

        public CollectOnDelivery? CollectOnDelivery { get; set; }
    }
    public class Weight
    {
        public double? Value { get; set; }
        //TODO: Enum?

        public string? Unit { get; set; }
    }
    public class CollectOnDelivery
    {
        // TODO: Enum?
        public string? PaymentType { get; set; }

        public PaymentAmount? PaymentAmount { get; set; }
    }

    public class PaymentAmount
    {
        // TODO: Enum?
        public string? Currency { get; set; }

        public double? Amount { get; set; }
    }
}
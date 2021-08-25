using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Params
{
    public class LabelParams
    {
        /// <summary>
        /// The shipment information used to generate the label
        /// </summary>
        public Shipment? Shipment { get; set; }

        /// <summary>
        /// Indicates whether this is a return label. You may also want to set the rmaNumber so you know what is being returned.
        /// </summary>
        public bool? IsReturnLabel { get; set; }

        /// <summary>
        /// An optional Return Merchandise Authorization number. This field is useful for return labels. You can set it to any string value.
        /// </summary>
        public string? RMANumber { get; set; }

        /// <summary>
        /// The label charge event.
        /// </summary>
        public ChargeEvent? ChargeEvent { get; set; }

        /// <summary>
        /// The labelId of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.
        /// </summary>
        public string? OutboundLabelId { get; set; }

        /// <summary>
        /// The possible validate address values
        /// </summary>
        public ValidateAddress? ValidateAddress { get; set; }

        /// <summary>
        /// There are two different ways to download a label:
        /// </summary>
        public LabelDownloadType? LabelDownloadType { get; set; }

        /// <summary>
        /// The file format that you want the label to be in. We recommend pdf format because it is supported by all carriers, whereas some carriers do not support the png or zpl formats.
        /// </summary>
        public LabelFormat? LabelFormat { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        public DisplayScheme? DisplayScheme { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in. The labelFormat determines which sizes are allowed. 4x6 is supported for all label formats, whereas letter (8.5" x 11") is only supported for pdf format.
        /// </summary>
        public LabelLayout? LabelLayout { get; set; }

        /// <summary>
        /// The label image resource that was used to create a custom label image.
        /// </summary>
        public string? LabelImageId { get; set; }
    }

    public class Shipment
    {
        /// <summary>
        /// The carrier account that is billed for the shipping charges
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// The carrier service used to ship the package, such as fedexGround, uspsFirstClassMail, flatRateEnvelope, etc.
        /// </summary>
        public string? ServiceCode { get; set; }

        /// <summary>
        /// ID that the Order Source assigned
        /// </summary>
        public string? ExternalOrderId { get; set; }

        /// <summary>
        /// Describe the packages included in this shipment as related to potential metadata that was imported from external order sources
        /// </summary>
        public List<ShipmentItem>? Items { get; set; }

        /// <summary>
        /// Array of tax identifiers
        /// </summary>
        public List<TaxIdentifier>? TaxIdentifiers { get; set; }

        /// <summary>
        /// You can optionally use this field to store your own identifier for this shipment.
        /// </summary>
        public string? ExternalShipmentId { get; set; }

        /// <summary>
        /// The date that the shipment was(or will be) shipped. ShipEngine will take the day of week into consideration.For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
        /// </summary>
        public string? ShipDate { get; set; }

        /// <summary>
        /// The recipient's mailing address
        /// </summary>
        public Address? ShipTo { get; set; }

        /// <summary>
        /// The shipment's origin address. If you frequently ship from the same location, consider creating a warehouse. Then you can simply specify the warehouseId rather than the complete address each time.
        /// </summary>
        public Address ShipFrom { get; set; }

        /// <summary>
        /// The warehouse that the shipment is being shipped from. Either warehouseId or shipFrom must be specified.
        /// </summary>
        public string? WarehouseId { get; set; }

        /// <summary>
        /// The return address for this shipment. Defaults to the shipFrom address.
        /// </summary>
        public Address? ReturnTo { get; set; }

        /// <summary>
        /// The type of delivery confirmation that is required for this shipment.
        /// </summary>
        public DeliveryConfirmation? Confirmation { get; set; }

        /// <summary>
        /// Customs information. This is usually only needed for international shipments.
        /// </summary>
        public InternationalShipmentOptions? Customs { get; set; }

        /// <summary>
        /// Advanced shipment options. These are entirely optional.
        /// </summary>
        public AdvancedShipmentOptions? AdvancedOptions { get; set; }

        /// <summary>
        /// Indicates if the package will be picked up or dropped off by the carrier
        /// </summary>
        public OriginType? OriginType { get; set; }

        /// <summary>
        /// The insurance provider to use for any insured packages in the shipment
        /// </summary>
        public InsuranceProvider? InsuranceProvider { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        public OrderSourceCode? OrderSourceCode { get; set; }

        /// <summary>
        /// The packages in the shipment.
        /// </summary>
        public List<Package>? Packages { get; set; }
    }

    public class Package
    {
        /// <summary>
        /// The package type, such as thick_envelope, small_flat_rate_box, large_package, etc. The code package indicates a custom or unknown package type
        /// </summary>
        public string? PackageCode { get; set; }

        /// <summary>
        /// The package weight
        /// </summary>
        public Weight? Weight { get; set; }

        /// <summary>
        /// The package dimensions
        /// </summary>
        public Dimensions? Dimensions { get; set; }

        /// <summary>
        /// The insured value of the package. Requires the InsuranceProvider property of the shipment to be set.
        /// </summary>
        public MonetaryValue? InsuredValue { get; set; }

        /// <summary>
        /// Custom messages to print on the shipping label for the package.
        /// These are typically used to print invoice numbers, product numbers, or other internal reference numbers.
        /// Not all carriers support label messages. The number of lines and the maximum length of each line also varies by carrier.
        /// </summary>
        public LabelMessages? LabelMessages { get; set; }

        /// <summary>
        /// An external package id.
        /// </summary>
        public string? ExternalPackageId { get; set; }
    }

    public class LabelMessages
    {

        /// <summary>
        /// The first line of the custom label message.
        /// Some carriers may prefix this line with something like "REF", "Reference", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference1 { get; set; }

        /// <summary>
        /// The second line of the custom label message.
        /// Some carriers may prefix this line with something like "INV", "Reference 2", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference2 { get; set; }

        /// <summary>
        /// The third line of the custom label message.
        /// Some carriers may prefix this line with something like "INV", "Reference 2", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference3 { get; set; }
    }

    public class Dimensions
    {
        /// <summary>
        /// The dimension units that are supported by ShipEngine.
        /// </summary>
        public DimensionUnit? Unit { get; set; }

        /// <summary>
        /// The length of the package, in the specified unit
        /// </summary>
        public double? Length { get; set; }

        /// <summary>
        /// The width of the package, in the specified unit
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// The length of the package, in the specified unit
        /// </summary>
        public double? Height { get; set; }
    }

    public class ShipmentItem
    {

        /// <summary>
        /// Item name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Sales order id
        /// </summary>
        public string? SalesOrderId { get; set; }

        /// <summary>
        /// Sales order item id
        /// </summary>
        public string? SalesOrderItemId { get; set; }

        /// <summary>
        /// The quantity of this item included in a shipment
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The item stock keeping unit
        /// </summary>
        public string? Sku { get; set; }

        /// <summary>
        /// External order id
        /// </summary>
        public string? ExternalOrderId { get; set; }

        /// <summary>
        /// External order item id
        /// </summary>
        public string? ExternalOrderItemId { get; set; }

        /// <summary>
        /// Amazon Standard Identification Number
        /// </summary>
        public string? Asin { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        public OrderSourceCode? OrderSourceCode { get; set; }
    }
    public class TaxIdentifier
    {
        /// <summary>
        /// The taxable entity type for this tax item. Valid values include the following
        /// </summary>
        public TaxableEntityType? TaxableEntityType { get; set; }

        /// <summary>
        /// Determines how FedEx will pickup your packages
        /// </summary>
        public IdentifierType? IdentifierType { get; set; }

        /// <summary>
        /// The authority that issued this tax. This must be a valid 2 character ISO 3166 Alpha 2 country code.
        /// </summary>
        public string? IssuingAuthority { get; set; }

        /// <summary>
        /// The value of the identifier
        /// </summary>
        public string? Value { get; set; }
    }
    public class Address
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// The <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">ISO 3166 country code</see>
        /// </summary>
        public Country? CountryCode { get; set; }

        /// <summary>
        /// The name of the sender or recipient at the address, if applicable.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The company name, if this is a business address.
        /// </summary>
        public string? CompanyName { get; set; }

        /// <summary>
        /// The phone number associated with this address, if any.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// The city or locality
        /// </summary>
        public string? CityLocality { get; set; }

        /// <summary>
        /// The state or province
        /// </summary>
        public string? StateProvince { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Indicates whether the address is residential or commercial, if known.
        /// </summary>
        public AddressResidentialIndicator? AddressResidentialIndicator { get; set; }
    }

    public class InternationalShipmentOptions
    {
        /// <summary>
        /// The type of contents in this shipment. This may impact import duties or customs treatment.
        /// </summary>
        public PackageContents? Contents { get; set; }

        /// <summary>
        /// Indicates what to do if a package is unable to be delivered.
        /// </summary>
        public NonDelivery? NonDelivery { get; set; }

        /// <summary>
        /// Customs declarations for each item in the shipment.
        /// </summary>
        public List<CustomsItem>? CustomsItems { get; set; }
    }
    public class CustomsItem
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The quantity of this item in the shipment.
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The declared customs value of each item
        /// </summary>
        public MonetaryValue? Value { get; set; }

        /// <summary>
        /// The Harmonized Tariff Code of this item.
        /// </summary>
        public string? HarmonizedTariffCode { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-1 country code where this item originated
        /// </summary>
        public Country? CountryOfOrigin { get; set; }

        public string? UnitOfMeasure { get; set; }

        /// <summary>
        /// The SKU (Stock Keeping Unit) of the customs item
        /// </summary>
        public string? Sku { get; set; }

        /// <summary>
        /// Description of the Custom Item's SKU
        /// </summary>
        public string? SkuDescription { get; set; }
    }
    public class MonetaryValue
    {
        /// <summary>
        /// The currencies that are supported by ShipEngine.
        /// </summary>
        public Currency? Currency { get; set; }

        /// <summary>
        /// The monetary amount, in the specified currency.
        /// </summary>
        public double? Amount { get; set; }
    }
    public class AdvancedShipmentOptions
    {
        /// <summary>
        /// This field is used to bill shipping costs to a third party.
        /// This field must be used in conjunction with the bill_to_country_code, bill_to_party, and bill_to_postal_code fields.
        /// </summary>
        public string? BillToAccount { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-1 country code of the third-party that is responsible for shipping costs.
        /// </summary>
        public string? BillToCountryCode { get; set; }

        /// <summary>
        /// Indicates whether to bill shipping costs to the recipient or to a third-party.
        /// When billing to a third-party, the bill_to_account, bill_to_country_code, and bill_to_postal_code fields must also be set.
        /// </summary>
        public BillToParty? BillToParty { get; set; }

        /// <summary>
        /// The postal code of the third-party that is responsible for shipping costs.
        /// </summary>
        public string? BillToPostalCode { get; set; }

        /// <summary>
        /// Indicates that the shipment contains alcohol.
        /// </summary>
        public bool? ContainsAlcohol { get; set; }

        /// <summary>
        /// Indicates that the shipper is paying the international delivery duties for this shipment.
        /// This option is supported by UPS, FedEx, and DHL Express.
        /// </summary>
        public bool? DeliveredDutyPaid { get; set; }

        /// <summary>
        /// Indicates if the shipment contain dry ice
        /// </summary>
        public bool? DryIce { get; set; }

        /// <summary>
        /// The weight of the dry ice in the shipment
        /// </summary>
        public Weight? DryIceWeight { get; set; }

        /// <summary>
        /// Indicates that the package cannot be processed automatically because it is too large or irregularly shaped.
        /// This is primarily for USPS shipments. See Section 1.2 of the USPS parcel standards for details.
        /// </summary>
        public bool? NonMachinable { get; set; }

        /// <summary>
        /// Enables Saturday delivery, if supported by the carrier.
        /// </summary>
        public bool? SaturdayDelivery { get; set; }

        /// <summary>
        /// Whether to use UPS Ground Freight pricing. If enabled, then a freight_class must also be specified.
        /// </summary>
        public bool? UseUpsGroundFreightPricing { get; set; }

        /// <summary>
        /// The National Motor Freight Traffic Association freight class, such as "77.5", "110", or "250".
        /// </summary>
        public string? FreightClass { get; set; }

        /// <summary>
        /// An arbitrary field that can be used to store information about the shipment.
        /// </summary>
        public string? CustomField1 { get; set; }

        /// <summary>
        /// An arbitrary field that can be used to store information about the shipment.
        /// </summary>
        public string? CustomField2 { get; set; }

        /// <summary>
        /// An arbitrary field that can be used to store information about the shipment.
        /// </summary>
        public string? CustomField3 { get; set; }

        /// <summary>
        /// Indicates if the package will be picked up or dropped off by the carrier
        /// </summary>
        public OriginType? OriginType { get; set; }

        public bool? ShipperRelease { get; set; }

        /// <summary>
        /// Defer payment until package is delivered, instead of when it is ordered.
        /// </summary>
        public CollectOnDelivery? CollectOnDelivery { get; set; }
    }
    public class Weight
    {
        /// <summary>
        /// The weight, in the specified unit
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// The possible weight unit values
        /// </summary>
        public WeightUnit? Unit { get; set; }
    }
    public class CollectOnDelivery
    {
        /// <summary>
        /// Types of payment that are supported
        /// </summary>
        public PaymentType? PaymentType { get; set; }

        public PaymentAmount? PaymentAmount { get; set; }
    }

    public class PaymentAmount
    {
        /// <summary>
        /// The currencies that are supported by ShipEngine.
        /// </summary>
        public Currency? Currency { get; set; }

        public double? Amount { get; set; }
    }
}
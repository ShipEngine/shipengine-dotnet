#nullable disable

using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails
{
    /// <summary>
    /// Paramters needed for purchasing a label.
    /// </summary>
    public class Params
    {
        /// <summary>
        /// The shipment information used to generate the label
        /// </summary>
        public Shipment Shipment { get; set; }

        /// <summary>
        /// Indicates whether this is a return label. You may also want to set the rmaNumber so you know what is being returned.
        /// </summary>
        public bool IsReturnLabel { get; set; }

        /// <summary>
        /// An optional Return Merchandise Authorization number. This field is useful for return labels. You can set it to any string value.
        /// </summary>
        public string RMANumber { get; set; }

        /// <summary>
        /// The label charge event.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ChargeEvent? ChargeEvent { get; set; }

        /// <summary>
        /// The labelId of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.
        /// </summary>
#nullable enable
        public string? OutboundLabelId { get; set; }
#nullable disable

        /// <summary>
        /// The possible validate address values
        /// </summary>
        public StringEnum<ValidateAddress> ValidateAddress { get; set; }

        /// <summary>
        /// There are two different ways to download a label:
        /// </summary>
        public StringEnum<LabelDownloadType> LabelDownloadType { get; set; }

        /// <summary>
        /// The file format that you want the label to be in. We recommend pdf format because it is supported by all carriers, whereas some carriers do not support the png or zpl formats.
        /// </summary>
        public StringEnum<LabelFormat> LabelFormat { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        public StringEnum<DisplayScheme> DisplayScheme { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in. The labelFormat determines which sizes are allowed. 4x6 is supported for all label formats, whereas letter (8.5" x 11") is only supported for pdf format.
        /// </summary>
        public StringEnum<LabelLayout> LabelLayout { get; set; }

        /// <summary>
        /// The label image resource that was used to create a custom label image.
        /// </summary>
        public string LabelImageId { get; set; }
    }

    /// <summary>
    /// Shipment information
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// The carrier account that is billed for the shipping charges
        /// </summary>
        public string CarrierId { get; set; }

        /// <summary>
        /// The carrier service used to ship the package, such as fedexGround, uspsFirstClassMail, flatRateEnvelope, etc.
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// ID that the Order Source assigned
        /// </summary>
        public string ExternalOrderId { get; set; }

        /// <summary>
        /// Describe the packages included in this shipment as related to potential metadata that was imported from external order sources
        /// </summary>
        public List<ShipmentItem> Items { get; set; }

        /// <summary>
        /// Array of tax identifiers
        /// </summary>
        public List<TaxIdentifier> TaxIdentifiers { get; set; }

        /// <summary>
        /// You can optionally use this field to store your own identifier for this shipment.
        /// </summary>
        public string ExternalShipmentId { get; set; }

        /// <summary>
        /// The date that the shipment was(or will be) shipped. ShipEngine will take the day of week into consideration.For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
        /// </summary>
        public string ShipDate { get; set; }

        /// <summary>
        /// The recipient's mailing address
        /// </summary>
        public Address ShipTo { get; set; }

        /// <summary>
        /// The shipment's origin address. If you frequently ship from the same location, consider creating a warehouse. Then you can simply specify the warehouseId rather than the complete address each time.
        /// </summary>
        public Address ShipFrom { get; set; }

        /// <summary>
        /// The warehouse that the shipment is being shipped from. Either warehouseId or shipFrom must be specified.
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// The return address for this shipment. Defaults to the shipFrom address.
        /// </summary>
        public Address ReturnTo { get; set; }

        /// <summary>
        /// The type of delivery confirmation that is required for this shipment.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public DeliveryConfirmation Confirmation { get; set; }

        /// <summary>
        /// Customs information. This is usually only needed for international shipments.
        /// </summary>
        public InternationalShipmentOptions Customs { get; set; }

        /// <summary>
        /// Advanced shipment options. These are entirely optional.
        /// </summary>
        public AdvancedShipmentOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Indicates if the package will be picked up or dropped off by the carrier
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public OriginType OriginType { get; set; }

        /// <summary>
        /// The insurance provider to use for any insured packages in the shipment
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public InsuranceProvider InsuranceProvider { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public OrderSourceCode? OrderSourceCode { get; set; }

        /// <summary>
        /// The packages in the shipment.
        /// </summary>
        public List<Package> Packages { get; set; }
    }

    /// <summary>
    /// Package information
    /// </summary>
    public class Package
    {
        /// <summary>
        /// The package type, such as thick_envelope, small_flat_rate_box, large_package, etc. The code package indicates a custom or unknown package type
        /// </summary>
        public string PackageCode { get; set; }

        /// <summary>
        /// The package weight
        /// </summary>
        public Weight Weight { get; set; }

        /// <summary>
        /// The package dimensions
        /// </summary>
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// The insured value of the package. Requires the InsuranceProvider property of the shipment to be set.
        /// </summary>
        public MonetaryValue InsuredValue { get; set; }

        /// <summary>
        /// Custom messages to print on the shipping label for the package.
        /// These are typically used to print invoice numbers, product numbers, or other internal reference numbers.
        /// Not all carriers support label messages. The number of lines and the maximum length of each line also varies by carrier.
        /// </summary>
        public LabelMessages LabelMessages { get; set; }

        /// <summary>
        /// An external package id.
        /// </summary>
        public string ExternalPackageId { get; set; }
    }

    /// <summary>
    /// Options associated with international shipments
    /// </summary>
    public class InternationalShipmentOptions
    {
        /// <summary>
        /// The type of contents in this shipment. This may impact import duties or customs treatment.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public PackageContents Contents { get; set; }

        /// <summary>
        /// Indicates what to do if a package is unable to be delivered.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public NonDelivery NonDelivery { get; set; }

        /// <summary>
        /// Customs declarations for each item in the shipment.
        /// </summary>
        public List<CustomsItem> CustomsItems { get; set; }
    }

    /// <summary>
    /// A Customs Item
    /// </summary>
    public class CustomsItem
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The quantity of this item in the shipment.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The declared customs value of each item
        /// </summary>
        public MonetaryValue Value { get; set; }

        /// <summary>
        /// The Harmonized Tariff Code of this item.
        /// </summary>
        public string HarmonizedTariffCode { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-1 country code where this item originated
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Country CountryOfOrigin { get; set; }

        /// <summary>
        /// The unit that was used to measure the dimensions of this item.
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The SKU (Stock Keeping Unit) of the customs item
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Description of the Custom Item's SKU
        /// </summary>
        public string SkuDescription { get; set; }
    }
}
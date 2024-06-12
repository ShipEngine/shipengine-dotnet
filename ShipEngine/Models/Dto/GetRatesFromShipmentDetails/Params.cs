#nullable disable

using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.GetRatesWithShipmentDetails
{
    /// <summary>
    /// Params for retrieving rates for your shipments.
    /// Must specify either the ShipmentId or Shipment property.
    /// </summary>
    public class Params
    {
        /// <summary>
        /// A string that uniquely identifies the shipment
        /// </summary>
        public string ShipmentId { get; set; }

        /// <summary>
        /// The shipment information
        /// </summary>
        public Shipment Shipment { get; set; }

        /// <summary>
        /// Options for your rate estimates
        /// </summary>
        public RateOptions RateOptions { get; set; }
    }

    /// <summary>
    /// Shipment information
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// The possible validate address values
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ValidateAddress ValidateAddress { get; set; }

        /// <summary>
        /// The carrier account that is billed for the shipping charges
        /// </summary>
        public string CarrierId { get; set; }

        /// <summary>
        /// The carrier service used to ship the package
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
        /// Tax identifiers
        /// </summary>
        public List<TaxIdentifier> TaxIdentifiers { get; set; }

        /// <summary>
        /// You can optionally use this field to store your own identifier for this shipment.
        /// </summary>
        public string ExternalShipmentId { get; set; }

        /// <summary>
        /// The date that the shipment was (or will be) shippped. ShipEngine will take the day of week into consideration.
        /// For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
        /// </summary>
        public string ShipDate { get; set; }

        /// <summary>
        /// The recipient's mailing address
        /// </summary>
        public Address ShipTo { get; set; }

        /// <summary>
        /// The shipment's origin address. If you frequently ship from the same location, consider creating a warehouse.
        /// Then you can simply specify the warehouse_id rather than the complete address each time.
        /// </summary>
        public Address ShipFrom { get; set; }

        /// <summary>
        /// The warehouse that the shipment is being shipped from. Either warehouse_id or ship_from must be specified.
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// The return address for this shipment. Defaults to the ship_from address.
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
        public Customs Customs { get; set; }

        /// <summary>
        /// Advanced shipment options. These are entirely optional.
        /// </summary>
        public AdvancedShipmentOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Indicates if the package will be picked up or dropped off by the carrier
        /// </summary>
        public OriginType OriginType { get; set; }

        /// <summary>
        /// The insurance provider to use for any insured packages in the shipment.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public InsuranceProvider InsuranceProvider { get; set; }

        /// <summary>
        /// Arbitrary tags associated with this shipment. Tags can be used to categorize shipments, and shipments can be queried by their tags.
        /// </summary>
        public List<string> Tags { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public OrderSourceCode OrderSourceCode { get; set; }

        /// <summary>
        /// The packages in the shipment.
        /// </summary>
        public List<ShipmentPackage> Packages { get; set; }

        /// <summary>
        /// The combined weight of all packages in the shipment
        /// </summary>
        public Weight Weight { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ComparisonRateType? ComparisonRateType { get; set; }

    }

    /// <summary>
    /// Rate options for specifying the type of rate estimates
    /// </summary>
    public class RateOptions
    {
        /// <summary>
        /// Array of carrier ids to get rates for
        /// </summary>
        public List<string> CarrierIds { get; set; }

        /// <summary>
        /// Filter rate response by package types
        /// </summary>
        public List<string> PackageTypes { get; set; }

        /// <summary>
        /// Filter rate response by service codes
        /// </summary>
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// Calculate the duties and tariffs for cross border shipments.
        /// </summary>
        public bool CalculateTaxAmount { get; set; }

        /// <summary>
        /// The currencies that are supported by ShipEngine.
        /// </summary>

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Currency PreferredCurrency { get; set; }
    }
}
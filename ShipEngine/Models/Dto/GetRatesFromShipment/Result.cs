using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.GetRatesFromShipment.Result
{
    public class ShipmentRates
    {
        /// <summary>
        /// A string that uniquely identifies the shipment
        /// </summary>
        public string? ShipmentId { get; set; }

        /// <summary>
        /// The carrier account that is billed for the shipping charges
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// The carrier service used to ship the package
        /// </summary>
        public string? ServiceCode { get; set; }

        /// <summary>
        /// ID that the Order Source assigned
        /// </summary>
        public string? ExternalOrderId { get; set; }

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
        public string? ExternalShipmentId { get; set; }

        /// <summary>
        /// The date that the shipment was (or will be) shippped. ShipEngine will take the day of week into consideration.
        /// For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
        /// </summary>
        public string? ShipDate { get; set; }

        /// <summary>
        /// The date and time that the shipment was created in ShipEngine.
        /// </summary>
        public string? CreatedAt { get; set; }
        /// <summary>
        /// The date and time that the shipment was created or last modified.
        /// </summary>
        public string? ModifiedAt { get; set; }

        /// <summary>
        /// The current status of the shipment
        /// </summary>
        public ShipmentStatus ShipmentStatus { get; set; }

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
        public string? WarehouseId { get; set; }

        /// <summary>
        /// The return address for this shipment. Defaults to the ship_from address.
        /// </summary>
        public Address ReturnTo { get; set; }

        /// <summary>
        /// The type of delivery confirmation that is required for this shipment.
        /// </summary>
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
        public InsuranceProvider InsuranceProvider { get; set; }

        /// <summary>
        /// Arbitrary tags associated with this shipment. Tags can be used to categorize shipments, and shipments can be queried by their tags.
        /// </summary>
        public List<string> Tags { get; set; }


        /// <summary>
        /// Total Weight of the Shipment
        /// </summary>
        public Weight TotalWeight { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        public OrderSourceCode? OrderSourceCode { get; set; }

        /// <summary>
        /// The packages in the shipment.
        /// </summary>
        public List<ShipmentPackage> Packages { get; set; }

        /// <summary>
        /// The combined weight of all packages in the shipment
        /// </summary>
        public Weight Weight { get; set; }

        /// <summary>
        /// The rate responses
        /// </summary>
        public RateResponse RateResponse { get; set; }
    }

    public class RateResponse
    {
        /// <summary>
        /// A list of shipment rates
        /// </summary>
        public List<Rate> Rates { get; set; }

        /// <summary>
        /// A list of invalid shipment rates
        /// </summary>
        public List<Rate> InvalidRates { get; set; }

        /// <summary>
        /// A string that uniquely identifies the rate request
        /// </summary>
        public string? RateRequestId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the shipment
        /// </summary>
        public string? ShipmentId { get; set; }

        /// <summary>
        /// When the rate was created
        /// </summary>
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Rate response status values
        /// </summary>
        public RateStatus Status { get; set; }

        /// <summary>
        /// Any errors associated with the rate request
        /// </summary>
        public List<ShipEngineException> Errors { get; set; }
    }

    public class Rate
    {
        /// <summary>
        /// A string that uniquely identifies the rate
        /// </summary>
        public string? RateId { get; set; }

        /// <summary>
        /// The possible rate type values
        /// </summary>
        public RateType RateType { get; set; }

        /// <summary>
        /// A string that uniquely identifies the carrier
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// The shipping amount
        /// </summary>
        public MonetaryValue ShippingAmount { get; set; }

        /// <summary>
        /// The insurance amount
        /// </summary>
        public MonetaryValue InsuranceAmount { get; set; }

        /// <summary>
        /// The confirmation amount
        /// </summary>
        public MonetaryValue ConfirmationAmount { get; set; }

        /// <summary>
        /// Any other charges associated with this rate
        /// </summary>
        public MonetaryValue OtherAmount { get; set; }
        /// <summary>
        /// Tariff and additional taxes associated with an international shipment.
        /// </summary>
        public MonetaryValue TaxAmount { get; set; }

        /// <summary>
        /// Certain carriers base their rates off of custom zones that vary depending upon
        /// the ship_to and ship_from location
        /// </summary>
        public int? Zone { get; set; }

        /// <summary>
        /// package type that this rate was estimated for
        /// </summary>
        public string? PackageType { get; set; }

        /// <summary>
        /// The number of days estimated for delivery, this will show the actual delivery time if for example,
        /// the package gets shipped on a Friday
        /// </summary>
        public int DeliveryDays { get; set; }

        /// <summary>
        /// Indicates if the rate is guaranteed.
        /// </summary>
        public bool GuaranteedService { get; set; }

        /// <summary>
        /// An ISO 8601 string that represents a date, but not a specific time.
        /// The value may contain a time component, but it will be set to 00:00:00 UTC by ShipEngine.
        /// </summary>/
        public string? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The carrier delivery days
        /// </summary>
        public string? CarrierDeliveryDays { get; set; }

        /// <summary>
        /// Ship date
        /// </summary>
        public string? ShipDate { get; set; }

        /// <summary>
        /// Indicates if the rates been negotiated
        /// </summary>
        public bool NegotiatedRate { get; set; }

        /// <summary>
        /// Service type
        /// </summary>
        public string? ServiceType { get; set; }

        /// <summary>
        /// Service code for the rate
        /// </summary>
        public string? ServiceCode { get; set; }

        /// <summary>
        /// Indicates if rate is trackable
        /// </summary>
        public bool Trackable { get; set; }

        /// <summary>
        /// Carrier code
        /// </summary>
        public string? CarrierCode { get; set; }

        /// <summary>
        /// Carrier_nickname
        /// </summary>
        public string? CarrierNickname { get; set; }

        /// <summary>
        /// Carrier friendly name
        /// </summary>
        public string? CarrierFriendlyName { get; set; }

        /// <summary>
        /// The possible validation status values
        /// </summary>
        public ValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// The warning messages
        /// </summary>
        public List<string> WarningMessages { get; set; }

        /// <summary>
        /// The error messages
        /// </summary>
        public List<string> ErrorMessages { get; set; }
    }
}
using ShipEngineSDK.Common.Enums;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Advanced shipment options. These are entirely optional.
    /// </summary>
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
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// FedEx Freight Option
        /// </summary>
        public string? FedexFreight { get; set; }

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
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OriginType? OriginType { get; set; }

        /// <summary>
        /// Indicates if this is a shipper relesae
        /// </summary>
        public bool? ShipperRelease { get; set; }

        /// <summary>
        /// Defer payment until package is delivered, instead of when it is ordered.
        /// </summary>
        public CollectOnDelivery? CollectOnDelivery { get; set; }
    }
}
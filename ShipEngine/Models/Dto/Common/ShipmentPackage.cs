namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Package details associated with a shipment
    /// </summary>
    public class ShipmentPackage
    {
        /// <summary>
        /// A recent regulation in Mexico requires a content description when shipping to this country
        /// and when creating a bill of lading.
        /// See: https://www.shipengine.com/docs/shipping/international/#bill-of-lading-for-shipments-to-and-from-mexico-carta-porte
        /// </summary>
        public string? ContentDescription { get; set; }

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
}
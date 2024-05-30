using ShipEngineSDK.Common.Enums;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// <see href="https://www.shipengine.com/docs/shipping/international/#the-tax-identifiers-object" />
    /// </summary>
    public class TaxIdentifier
    {
        /// <summary>
        /// The taxable entity type for this tax item. Valid values include the following
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TaxableEntityType? TaxableEntityType { get; set; }

        /// <summary>
        /// Determines how FedEx will pickup your packages
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
}
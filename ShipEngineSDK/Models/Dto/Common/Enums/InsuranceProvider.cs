using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The insurance provider to use for any insured packages in the shipment.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum InsuranceProvider
    {
        /// <summary>
        /// No insurance will be provided.
        /// </summary>
        None,

        /// <summary>
        /// Purchase insurance from Shipsurance
        /// <see href="https://www.shipsurance.com/"/>
        /// </summary>
        Shipsurance,

        /// <summary>
        /// Get increased reimbursement coverage from the carrier based on the declared value of the package.
        /// </summary>
        Carrier,

        /// <summary>
        /// The package is insured by a third-party insurance service, outside of ShipEngine.
        /// </summary>
        [EnumMember(Value = "third_party")]
        ThirdParty,

        /// <summary>
        /// This option will assign the insurance provider available with ShipEngine Carriers to the shipment (currently ParcelGuard). The response will auto-populate the insurance_provider field with parcelguard.
        /// </summary>
        [EnumMember(Value = "funding_source")]
        FundingSource,

        /// <summary>
        /// This option will assign ParcelGuard as the insurance provider for the shipment. Using this value is functionally the same as using the 'funding_source' value.
        /// </summary>
        [EnumMember(Value = "parcelguard")]
        ParcelGuard
    }
}
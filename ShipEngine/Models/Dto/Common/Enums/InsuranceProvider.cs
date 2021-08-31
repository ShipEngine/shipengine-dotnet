using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The insurance provider to use for any insured packages in the shipment.
    /// </summary>
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
        ThirdParty
    }
}
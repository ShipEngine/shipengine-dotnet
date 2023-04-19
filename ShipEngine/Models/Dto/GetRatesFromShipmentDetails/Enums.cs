#pragma warning disable 1591
using System.Runtime.Serialization;

namespace ShipEngineSDK.GetRatesWithShipmentDetails
{
    /// <summary>
    /// The possible rate type values
    /// </summary>
    public enum RateType
    {
        Check,
        Shipment
    }

    /// <summary>
    /// The possible validation status values
    /// </summary>
    public enum ValidationStatus
    {
        Valid,
        Invalid,

        [EnumMember(Value = "has_warnings")]
        HasWarnings,
        Unknown
    }

    public enum RateStatus
    {
        Working,
        Completed,
        Partial,
        Error
    }
}
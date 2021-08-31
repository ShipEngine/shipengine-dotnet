#pragma warning disable 1591
using System.Runtime.Serialization;

namespace ShipEngineSDK.GetRatesFromShipment
{
    /// <summary>
    /// The possible shipment status values
    /// </summary>
    public enum ShipmentStatus
    {
        Pending,
        Processing,

        [EnumMember(Value = "label_purchased")]
        LabelPurchased,
        Cancelled
    }

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
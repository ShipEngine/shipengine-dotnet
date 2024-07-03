#pragma warning disable 1591
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.GetRatesWithShipmentDetails
{
    /// <summary>
    /// The possible shipment status values
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
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
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
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

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ComparisonRateType
    {
        [EnumMember(Value = "retail")]
        Retail,
    }

}
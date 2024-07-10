#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Tracking status description.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TrackingStatusDescription
    {
        [EnumMember(Value = "Accepted")]
        Accepted,

        [EnumMember(Value = "Attempted Delivery")]
        AttemptedDelivery,

        [EnumMember(Value = "Delivered")]
        Delivered,

        [EnumMember(Value = "Exception")]
        Exception,

        [EnumMember(Value = "In Transit")]
        InTransit,

        [EnumMember(Value = "Unknown")]
        Unknown,

        [EnumMember(Value = "Not Yet In System")]
        NotYetInSystem
    }
}
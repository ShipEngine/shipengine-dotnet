#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Tracking status code.
    /// <see href="https://www.shipengine.com/docs/tracking/"/>
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TrackingStatusCode
    {
        /// <summary>
        /// Accepted
        /// </summary>
        [EnumMember(Value = "AC")]
        AC,

        /// <summary>
        /// In Transit
        /// </summary>
        [EnumMember(Value = "IT")]
        IT,

        /// <summary>
        /// Delivered
        /// </summary>
        [EnumMember(Value = "DE")]
        DE,

        /// <summary>
        /// Exception
        /// </summary>
        [EnumMember(Value = "EX")]
        EX,

        /// <summary>
        /// Delivery Attempt
        /// </summary>
        [EnumMember(Value = "AT")]
        AT,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "UN")]
        UN,

        /// <summary>
        /// Not Yet In System
        /// </summary>
        [EnumMember(Value = "NY")]
        NY

    }
}
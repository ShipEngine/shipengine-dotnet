#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails
{
    /// <summary>
    /// The label charge event.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ChargeEvent
    {
        [EnumMember(Value = "carrier_default")]
        CarrierDefault,

        [EnumMember(Value = "on_creation")]
        OnCreation,

        [EnumMember(Value = "on_carrier_acceptance")]
        OnCarrierAcceptance
    }

    /// <summary>
    /// The possible statuses that a shipping label can be in.
    /// </summary>
    public enum LabelStatus
    {
        Processing,
        Completed,
        Error,
        Voided
    }

    /// <summary>
    /// The current status of the package.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TrackingStatus
    {
        Unknown,

        [EnumMember(Value = "in_transit")]
        InTransit,
        Error,
        Delivered
    }

    /// <summary>
    /// The available label download types.
    /// </summary>
    public enum LabelDownloadType
    {
        /// <summary>
        /// You will receive a URL, which you can use to download the label in a separate request.
        /// The URL will remain valid for 90 days.
        /// </summary>
        Url,

        /// <summary>
        /// You will receive the Base64-encoded label as part of the response.
        /// No need for a second request to download the label.
        /// </summary>
        Inline,
    }
}
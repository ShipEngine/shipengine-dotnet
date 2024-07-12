#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.CreateLabelFromRate
{
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

    public enum LabelStatus
    {
        Processing,
        Completed,
        Error,
        Voided
    }



    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TrackingStatus
    {
        Unknown,

        [EnumMember(Value = "in_transit")]
        InTransit,
        Error,
        Delivered
    }

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LabelDownloadType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "inline")]
        Inline,
    }

}
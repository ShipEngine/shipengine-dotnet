#pragma warning disable 1591

using System.Runtime.Serialization;

namespace ShipEngineSDK.CreateLabelFromRate
{
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



    public enum TrackingStatus
    {
        Unknown,

        [EnumMember(Value = "in_transit")]
        InTransit,
        Error,
        Delivered
    }

    public enum LabelDownloadType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "inline")]
        Inline,
    }

}
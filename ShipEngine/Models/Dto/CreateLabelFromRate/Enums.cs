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

    public enum DisplayScheme
    {
        Label,

        [EnumMember(Value = "qr_code")]
        QRCode
    }

    public enum LabelLayout
    {
        Letter,

        [EnumMember(Value = "4x6")]
        FourBySix
    }

    public enum LabelFormat
    {
        PDF,
        PNG,
        ZPL
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
        Url,
        Inline,
    }

    public enum DeliveryConfirmation
    {
        None,
        Delivery,
        Signature,

        [EnumMember(Value = "adult_signature")]
        AdultSignature,

        [EnumMember(Value = "direct_signature")]
        DirectSignature,

        [EnumMember(Value = "delivery_mailed")]
        DeliveryMailed
    }
}
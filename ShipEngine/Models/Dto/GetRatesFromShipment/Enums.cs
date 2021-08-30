using System.Runtime.Serialization;

namespace ShipEngineSDK.GetRatesFromShipment
{
    public enum ShipmentStatus
    {
        Pending,
        Processing,

        [EnumMember(Value = "label_purchased")]
        LabelPurchased,
        Cancelled
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

    public enum RateType
    {
        Check,
        Shipment
    }

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
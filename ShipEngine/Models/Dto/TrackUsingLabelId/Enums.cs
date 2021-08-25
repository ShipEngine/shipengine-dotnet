using System.Runtime.Serialization;

namespace ShipEngineSDK.TrackUsingLabelId
{
    public enum StatusCode
    {
        [EnumMember(Value = "AC")]
        AC,

        [EnumMember(Value = "IT")]
        IT,

        [EnumMember(Value = "DE")]
        DE,

        [EnumMember(Value = "EX")]
        EX,

        [EnumMember(Value = "AT")]
        AT,

        [EnumMember(Value = "UN")]
        UN
    }

    public enum StatusDescription
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
        Unknown
    }
}
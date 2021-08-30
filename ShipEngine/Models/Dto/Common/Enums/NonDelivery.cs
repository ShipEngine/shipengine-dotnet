using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum NonDelivery
    {
        [EnumMember(Value = "return_to_sender")]
        ReturnToSender,

        [EnumMember(Value = "treat_as_abandoned")]
        TreatAsAbandoned
    }
}
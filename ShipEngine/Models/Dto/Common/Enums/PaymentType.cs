using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum PaymentType
    {
        Any,
        Cash,

        [EnumMember(Value = "cash_equivalent")]
        CashEquivalent,
        None
    }
}
#pragma warning disable 1591

using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Types of payment that are supported
    /// </summary>
    public enum PaymentType
    {
        Any,
        Cash,

        [EnumMember(Value = "cash_equivalent")]
        CashEquivalent,
        None
    }
}
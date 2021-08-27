using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum AddressResidentialIndicator
    {
        [EnumMember(Value = "unknown")]
        Unknown,

        [EnumMember(Value = "yes")]
        Yes,

        [EnumMember(Value = "no")]
        No,
    }
}

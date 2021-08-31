#pragma warning disable 1591

using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates whether an address is residential.
    /// </summary>
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
#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates whether an address is residential.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
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
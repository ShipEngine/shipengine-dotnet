#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates the type of address validation to perform.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ValidateAddress
    {
        [EnumMember(Value = "no_validation")]
        NoValidation,

        [EnumMember(Value = "validate_only")]
        ValidateOnly,

        [EnumMember(Value = "validate_and_clean")]
        ValidateAndClean,
    }
}
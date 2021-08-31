#pragma warning disable 1591

using System.Runtime.Serialization;
namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates the type of address validation to perform.
    /// </summary>
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
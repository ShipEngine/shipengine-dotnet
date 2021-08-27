using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
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
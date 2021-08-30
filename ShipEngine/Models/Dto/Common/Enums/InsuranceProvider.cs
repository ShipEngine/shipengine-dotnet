using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum InsuranceProvider
    {
        None,
        Shipsurance,
        Carrier,

        [EnumMember(Value = "third_party")]
        ThirdParty
    }
}
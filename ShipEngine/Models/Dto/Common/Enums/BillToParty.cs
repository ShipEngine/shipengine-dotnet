using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum BillToParty
    {
        Recipient,

        [EnumMember(Value = "third_party")]
        ThirdParty
    }
}
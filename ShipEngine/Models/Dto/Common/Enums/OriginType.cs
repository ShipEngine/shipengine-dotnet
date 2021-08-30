using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    public enum OriginType
    {
        Pickup,

        [EnumMember(Value = "drop_off")]
        DropOff
    }
}
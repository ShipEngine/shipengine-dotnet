#pragma warning disable 1591
using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates if the package will be picked up or dropped off by the carrier
    /// </summary>
    public enum OriginType
    {
        Pickup,

        [EnumMember(Value = "drop_off")]
        DropOff
    }
}
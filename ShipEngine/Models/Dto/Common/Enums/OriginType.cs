#pragma warning disable 1591
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates if the package will be picked up or dropped off by the carrier
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OriginType
    {
        Pickup,

        [EnumMember(Value = "drop_off")]
        DropOff
    }
}
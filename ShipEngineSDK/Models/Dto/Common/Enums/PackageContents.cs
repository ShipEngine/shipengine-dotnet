#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The type of contents in this shipment. This may impact import duties or customs treatment.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum PackageContents
    {
        Merchandise,
        Documents,
        Gift,

        [EnumMember(Value = "returned_goods")]
        ReturnedGoods,
        Sample
    }
}
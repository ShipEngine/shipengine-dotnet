using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
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
#pragma warning disable 1591

using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{

    /// <summary>
    /// The possible shipment status values
    /// </summary>
    public enum ShipmentStatus
    {
        Pending,
        Processing,

        [EnumMember(Value = "label_purchased")]
        LabelPurchased,
        Cancelled
    }
}

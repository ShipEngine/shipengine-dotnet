#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Label format for the shipment.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LabelFormat
    {
        [EnumMember(Value = "pdf")]
        PDF,
        [EnumMember(Value = "png")]
        PNG,
        [EnumMember(Value = "zpl")]
        ZPL
    }

}
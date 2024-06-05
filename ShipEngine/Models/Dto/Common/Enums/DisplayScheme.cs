#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{

    /// <summary>
    /// The display format that the label should be shown in.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum DisplayScheme
    {
        Label,

        [EnumMember(Value = "qr_code")]
        QRCode
    }
}
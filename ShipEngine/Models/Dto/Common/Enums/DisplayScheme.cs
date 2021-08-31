#pragma warning disable 1591

using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The display format that the label should be shown in.
    /// </summary>
    public enum DisplayScheme
    {
        Label,

        [EnumMember(Value = "qr_code")]
        QRCode
    }
}
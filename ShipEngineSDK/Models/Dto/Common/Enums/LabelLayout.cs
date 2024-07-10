using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The available layouts (sizes) in which shipping labels can be downloaded.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LabelLayout
    {
        /// <summary>
        /// Letter (8.5" x 11"), only supported for the PDF format.
        /// </summary>
        [EnumMember(Value = "letter")]
        Letter,

        /// <summary>
        /// Supported for all label formats.
        /// </summary>
        [EnumMember(Value = "4x6")]
        FourBySix
    }
}
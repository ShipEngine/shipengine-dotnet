#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{

    /// <summary>
    /// Indicates what to do if a package is unable to be delivered.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum NonDelivery
    {
        [EnumMember(Value = "return_to_sender")]
        ReturnToSender,

        [EnumMember(Value = "treat_as_abandoned")]
        TreatAsAbandoned
    }
}
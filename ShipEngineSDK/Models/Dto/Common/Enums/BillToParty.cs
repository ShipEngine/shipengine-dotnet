#pragma warning disable 1591

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Indicates whether to bill shipping costs to the recipient or to a third-party.
    /// When billing to a third-party, the bill_to_account, bill_to_country_code, and bill_to_postal_code fields must also be set.
    /// </summary>

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum BillToParty
    {
        Recipient,

        [EnumMember(Value = "third_party")]
        ThirdParty
    }
}
using ShipEngineSDK.Common.Enums;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{

    /// <summary>
    /// Payment information needed for a collect on delivery shipment
    /// </summary>
    public class CollectOnDelivery
    {
        /// <summary>
        /// Types of payment that are supported
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// Payment amount needed for the collect on delivery shipment
        /// </summary>
        public MonetaryValue? PaymentAmount { get; set; }
    }
}
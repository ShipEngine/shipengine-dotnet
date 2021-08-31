using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

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
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// Payment amount needed for the collect on delivery shipment
        /// </summary>
        public MonetaryValue? PaymentAmount { get; set; }
    }
}
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    public class CollectOnDelivery
    {
        /// <summary>
        /// Types of payment that are supported
        /// </summary>
        public PaymentType? PaymentType { get; set; }

        public MonetaryValue? PaymentAmount { get; set; }
    }
}
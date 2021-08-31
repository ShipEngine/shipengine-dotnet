using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Details associated with a shipment item.
    /// </summary>
    public class ShipmentItem
    {
        /// <summary>
        /// Item name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Sales order id
        /// </summary>
        public string? SalesOrderId { get; set; }

        /// <summary>
        /// Sales order item id
        /// </summary>
        public string? SalesOrderItemId { get; set; }

        /// <summary>
        /// The quantity of this item included in a shipment
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The item stock keeping unit
        /// </summary>
        public string? Sku { get; set; }

        /// <summary>
        /// External order id
        /// </summary>
        public string? ExternalOrderId { get; set; }

        /// <summary>
        /// External order item id
        /// </summary>
        public string? ExternalOrderItemId { get; set; }

        /// <summary>
        /// Amazon Standard Identification Number
        /// </summary>
        public string? Asin { get; set; }

        /// <summary>
        /// The order sources that are supported by ShipEngine
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSourceCode? OrderSourceCode { get; set; }
    }
}
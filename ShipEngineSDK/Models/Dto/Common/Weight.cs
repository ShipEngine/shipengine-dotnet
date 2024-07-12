using ShipEngineSDK.Common.Enums;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Used to indicate the weight of a package or shipment.
    /// </summary>
    public class Weight
    {
        /// <summary>
        /// The weight, in the specified unit
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// The possible weight unit values
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WeightUnit? Unit { get; set; }
    }
}
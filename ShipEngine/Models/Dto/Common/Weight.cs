using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

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
        [JsonConverter(typeof(StringEnumConverter))]
        public WeightUnit? Unit { get; set; }
    }
}
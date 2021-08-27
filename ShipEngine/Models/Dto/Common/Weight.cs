using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    public class Weight
    {
        /// <summary>
        /// The weight, in the specified unit
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// The possible weight unit values
        /// </summary>
        public WeightUnit? Unit { get; set; }
    }
}
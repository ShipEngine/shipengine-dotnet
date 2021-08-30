using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    public class Dimensions
    {
        /// <summary>
        /// The dimension units that are supported by ShipEngine.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DimensionUnit? Unit { get; set; }

        /// <summary>
        /// The length of the package, in the specified unit
        /// </summary>
        public double? Length { get; set; }

        /// <summary>
        /// The width of the package, in the specified unit
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// The length of the package, in the specified unit
        /// </summary>
        public double? Height { get; set; }
    }
}
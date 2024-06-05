using ShipEngineSDK.Common.Enums;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Dimensions associated with a shipment package
    /// </summary>
    public class Dimensions
    {
        /// <summary>
        /// The dimension units that are supported by ShipEngine.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
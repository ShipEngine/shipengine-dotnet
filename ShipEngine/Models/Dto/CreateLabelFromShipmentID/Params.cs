#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.CreateLabelFromShipmentID
{
    /// <summary>
    /// Params for creating a label from a rate id.
    /// </summary>/
    public class Params
    {
        /// <summary>
        /// The Shipment ID used to purchase the label.
        /// </summary>
        public string ShipmentID { get; set; }

        /// <summary>
        /// Address validation to perform while purchasing the label.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ValidateAddress ValidateAddress { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LabelLayout LabelLayout { get; set; }

        /// <summary>
        /// The file format that you want the label to be in.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LabelFormat LabelFormat { get; set; }

        /// <summary>
        /// Download the label via url or a base64 encoded string.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LabelDownloadType LabelDownloadType { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DisplayScheme DisplayScheme { get; set; }
    }
}
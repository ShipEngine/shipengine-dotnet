#nullable disable
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.CreateLabelFromRate
{
    /// <summary>
    /// Params for creating a label from a rate id.
    /// </summary>/
    public class Params
    {
        /// <summary>
        /// The Rate ID used to purchase the label.
        /// </summary>
        public string RateId { get; set; }

        /// <summary>
        /// Address validation to perform while purchasing the label.
        /// </summary>
        public ValidateAddress ValidateAddress { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in.
        /// </summary>
        public LabelLayout LabelLayout { get; set; }

        /// <summary>
        /// The file format that you want the label to be in.
        /// </summary>
        public LabelFormat LabelFormat { get; set; }

        /// <summary>
        /// Download the label via url or a base64 encoded string.
        /// </summary>
        public LabelDownloadType LabelDownloadType { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        public DisplayScheme DisplayScheme { get; set; }
    }
}
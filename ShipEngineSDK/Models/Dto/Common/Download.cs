namespace ShipEngineSDK.Common
{
    using System;

    /// <summary>
    /// Reference to the various downloadable file formats for the generated label
    /// </summary>
    [Obsolete("Deprecated Object.  Use ShipEnginSDK.Common.Download")]
    public class LabelDownload : Download
    {

    }
    /// <summary>
    /// Reference to the various downloadable file formats
    /// </summary>
    public class Download
    {
        /// <summary>
        /// The URL of the linked resource, if any
        /// </summary>
        public string? Href { get; set; }

        /// <summary>
        /// The URL for the pdf generated label
        /// </summary>
        public string? Pdf { get; set; }

        /// <summary>
        /// The URL for the png generated label
        /// </summary>
        public string? Png { get; set; }

        /// <summary>
        /// The URL for the zpl generated label
        /// </summary>
        public string? Zpl { get; set; }
    }
}
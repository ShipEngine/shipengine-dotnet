namespace ShipEngineSDK.Manifests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Params for creating a manifest.
    /// </summary>
    public class Params
    {
        /// <summary>
        /// A string that uniquely identifies the carrier
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the warehouse
        /// </summary>
        public string? WarehouseId { get; set; }

        /// <summary>
        /// The ship date that the shipment will be sent out on
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Optional: The list of label ids to include for the manifest
        /// </summary>
        public IEnumerable<string>? LabelIds { get; set; }

        /// <summary>
        /// Optional: The list of label ids to exclude from the manifest
        /// </summary>
        public IEnumerable<string>? ExcludedLabelIds { get; set; }
    }
}
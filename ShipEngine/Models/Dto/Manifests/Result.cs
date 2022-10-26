namespace ShipEngineSDK.Manifests
{
    using ShipEngineSDK.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Result of a Manifest request
    /// </summary>
    public class Result
    {

        /// <summary>
        /// Resulting Manifests
        /// </summary>
        public List<Manifest>? Manifests { get; set; }

        /// <summary>
        /// A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// The errors associated with the failed API call
        /// </summary>
        public List<Error>? Errors { get; set; }

        /// <summary>
        /// Resulting manifest requests with statuses
        /// </summary>
        public List<ManifestRequest>? ManifestRequests { get; set; }

        /// <summary>
        /// DEPRECATED: A string that uniquely identifies the manifest
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public string? ManifestId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the form
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public string? FormId { get; set; }

        /// <summary>
        /// The date-time that the manifest was created
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date-time that the manifests shipments will be picked up
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// The number of shipments that are included in this manifest
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public int? Shipments { get; set; }

        /// <summary>
        /// An array of the label ids used in this manifest.
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public List<string>? LabelIds { get; set; }

        /// <summary>
        /// A string that uniquely identifies the warehouse
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public string? WarehouseId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the submission
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public string? SubmissionId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the carrier
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public string? CarrierId { get; set; }

        /// <summary>
        /// Object containing the href link to download the manifest file
        /// </summary>
        [Obsolete("Deprecated. Use value on individual manifest.")]
        public LabelDownload? ManifestDownload { get; set; }
    }

    /// <summary>
    /// Object representing the manifest files.
    /// </summary>
    public class Manifest
    {
        /// <summary>
        /// A string that uniquely identifies the manifest
        /// </summary>
        public string? ManifestId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the form
        /// </summary>
        public string? FormId { get; set; }

        /// <summary>
        /// The date-time that the manifest was created
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date-time that the manifests shipments will be picked up
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// The number of shipments that are included in this manifest
        /// </summary>
        public int? Shipments { get; set; }

        /// <summary>
        /// An array of the label ids used in this manifest.
        /// </summary>
        public List<string>? LabelIds { get; set; }

        /// <summary>
        /// A string that uniquely identifies the warehouse
        /// </summary>
        public string? WarehouseId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the submission
        /// </summary>
        public string? SubmissionId { get; set; }

        /// <summary>
        /// A string that uniquely identifies the carrier
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// Object containing the href link to download the manifest file
        /// </summary>
        public LabelDownload? ManifestDownload { get; set; }
    }

    /// <summary>
    /// Object representing the manifest request.
    /// </summary>
    public class ManifestRequest
    {
        /// <summary>
        /// A string that uniquely identifies a manifest request
        /// </summary>
        public string? ManifestRequestId { get; set; }

        /// <summary>
        /// The possible statuses of a manifest request
        /// </summary>
        public string? Status { get; set; }
    }
}

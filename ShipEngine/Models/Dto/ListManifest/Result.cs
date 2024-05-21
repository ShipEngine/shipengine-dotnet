#nullable disable

using ShipEngineSDK.Manifests;
using System.Collections.Generic;

namespace ShipEngineSDK.ListManifest
{
    /// <summary>
    /// List Carrier Results
    /// </summary>
    public class Result
    {
        /// <summary>
        /// List of carriers associated with the account
        /// </summary>
        public List<Manifest> Manifests { get; set; }
    }
}
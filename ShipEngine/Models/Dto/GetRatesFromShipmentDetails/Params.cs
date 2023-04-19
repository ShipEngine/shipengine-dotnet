#nullable disable

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.GetRatesWithShipmentDetails
{
    /// <summary>
    /// Params for retrieving rates for your shipments.
    /// Must specify either the ShipmentId or Shipment property.
    /// </summary>
    public class Params
    {
        /// <summary>
        /// A string that uniquely identifies the shipment
        /// </summary>
        public string ShipmentId { get; set; }

        /// <summary>
        /// The shipment information
        /// </summary>
        public Shipment Shipment { get; set; }

        /// <summary>
        /// Options for your rate estimates
        /// </summary>
        public RateOptions RateOptions { get; set; }
    }
    /// <summary>
    /// Rate options for specifying the type of rate estimates
    /// </summary>
    public class RateOptions
    {
        /// <summary>
        /// Array of carrier ids to get rates for
        /// </summary>
        public List<string> CarrierIds { get; set; }

        /// <summary>
        /// Filter rate response by package types
        /// </summary>
        public List<string> PackageTypes { get; set; }

        /// <summary>
        /// Filter rate response by service codes
        /// </summary>
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// Calculate the duties and tariffs for cross border shipments.
        /// </summary>
        public bool CalculateTaxAmount { get; set; }

        /// <summary>
        /// The currencies that are supported by ShipEngine.
        /// </summary>

        [JsonConverter(typeof(StringEnumConverter))]
        public Currency PreferredCurrency { get; set; }
    }
}
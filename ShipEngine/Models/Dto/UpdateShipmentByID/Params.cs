#nullable disable

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.UpdateShipmentByID
{

    /// <summary>
    /// Paramters needed for updating a shipment.
    /// </summary>
    public class Params
    {
        /// <summary>
        /// The shipment information used to update a shipment
        /// </summary>
        public Shipment Shipment { get; set; }
    }
}

#nullable disable

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.CreateShipments
{


    public class Params
    {
        /// <summary>
        /// An array of shipments to be created
        /// </summary>
        public List<Shipment> Shipments { get; set; }
    }
}

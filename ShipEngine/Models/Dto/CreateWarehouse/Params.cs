namespace ShipEngineSDK.CreateWarehouse
{
    using ShipEngineSDK.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Params
    {
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public Address OriginAddress { get; set; }
        public Address ReturnAddress { get; set; }
        public string WarehouseId { get; set; }
    }
}

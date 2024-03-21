namespace ShipEngineSDK.ImportOrders
{
    using ShipEngineSDK.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Params
    {
        public string OrderSourceId { get; set; }
        public string OrderSourceNickname { get; set; }
        public string OrderSourceCode { get; set; }
        public string OrderSourceFriendlyName { get; set; }
        public bool Active { get; set; }
        public RefreshInfo RefreshInfo { get; set; }
    }

    public class RefreshInfo
    {
        public string Status { get; set; }
        public string LastRefreshAttempt { get; set; }
        public string RefreshDate { get; set; }
    }
}

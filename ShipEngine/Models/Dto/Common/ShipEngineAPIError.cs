using System.Collections.Generic;

namespace ShipEngineSDK.Common
{
    public class ShipEngineAPIError
    {
        public string? RequestId { get; set; }

        public List<Error> Errors { get; set; }

    }

    public class Error
    {
        public string? ErrorSource { get; set; }

        public string? ErrorType { get; set; }

        public string? ErrorCode { get; set; }

        public string? Message { get; set; }
    }
}
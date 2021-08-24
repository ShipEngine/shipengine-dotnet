using System.Collections.Generic;

namespace ShipEngineSDK.Common
{
    public class ShipEngineAPIError
    {
        public string RequestId { get; set; }

        public List<Error> Errors { get; set; }

    }

    public class Error
    {
        public ErrorSource ErrorSource { get; set; }

        public ErrorType ErrorType { get; set; }

        public ErrorCode ErrorCode { get; set; }

        public string Message { get; set; }
    }
}
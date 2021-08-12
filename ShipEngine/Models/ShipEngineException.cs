using System;

namespace ShipEngineSDK
{
    public class ShipEngineException : Exception
    {
        public string? RequestId { get; }

        public string? ErrorSource { get; set; }

        public string? ErrorType { get; set; }

        public string? ErrorCode { get; set; }


        public ShipEngineException(string message, string errorSource = "shipengine", string errorType = "system", string errorCode = "unspecified", string requestID = null) : base(message)
        {
            ErrorSource = errorSource;
            ErrorType = errorType;
            ErrorCode = errorCode;
            RequestId = requestID;
        }
    }
}
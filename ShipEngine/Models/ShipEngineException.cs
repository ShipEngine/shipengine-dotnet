using System;

namespace ShipEngineSDK
{
    public class ShipEngineException : Exception
    {
        public string? RequestId { get; }

        public ErrorSource ErrorSource { get; set; }

        public ErrorType ErrorType { get; set; }

        public ErrorCode ErrorCode { get; set; }


        public ShipEngineException(
            string message,
            ErrorSource errorSource = ErrorSource.Shipengine,
            ErrorType errorType = ErrorType.System,
            ErrorCode errorCode = ErrorCode.Unspecified,
            string requestID = null) : base(message)
        {
            ErrorSource = errorSource;
            ErrorType = errorType;
            ErrorCode = errorCode;
            RequestId = requestID;
        }
    }
}
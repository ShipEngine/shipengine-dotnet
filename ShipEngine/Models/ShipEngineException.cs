#pragma warning disable 1591

using System;

namespace ShipEngineSDK
{
    /// <summary>
    /// Error object returned from failed method calls
    /// </summary>
    public class ShipEngineException : Exception
    {
        /// <summary>
        /// A UUID that uniquely identifies the request id.
        /// This can be given to the support team to help debug non-trivial issues that may occur
        /// </summary>

        public string? RequestId { get; }

        /// <summary>
        /// The source of the error, as indicated by the name this informs us if the API call failed
        /// because of the carrier, the order source, or the ShipEngine API itself.
        /// </summary>
        public ErrorSource ErrorSource { get; set; }

        /// <summary>
        /// The type of error
        /// </summary>
        public ErrorType ErrorType { get; set; }

        /// <summary>
        /// The error code specified for the failed API Call
        /// </summary>
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
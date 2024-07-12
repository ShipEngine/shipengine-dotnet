#pragma warning disable 1591

using ShipEngineSDK.Enums;
using System;
using System.Net.Http;

namespace ShipEngineSDK
{
    /// <summary>
    /// Error object returned from failed method calls
    /// </summary>
    public class ShipEngineException(
        string message,
        ErrorSource errorSource = ErrorSource.Shipengine,
        ErrorType errorType = ErrorType.System,
        ErrorCode errorCode = ErrorCode.Unspecified,
        string? requestID = null,
        HttpResponseMessage? responseMessage = null)
        : Exception(message)
    {
        /// <summary>
        /// A UUID that uniquely identifies the request id.
        /// This can be given to the support team to help debug non-trivial issues that may occur
        /// </summary>

        public string? RequestId { get; } = requestID;

        /// <summary>
        /// The source of the error, as indicated by the name this informs us if the API call failed
        /// because of the carrier, the order source, or the ShipEngine API itself.
        /// </summary>
        public ErrorSource ErrorSource { get; set; } = errorSource;

        /// <summary>
        /// The type of error
        /// </summary>
        public ErrorType ErrorType { get; set; } = errorType;

        /// <summary>
        /// The error code specified for the failed API Call
        /// </summary>
        public ErrorCode ErrorCode { get; set; } = errorCode;

        /// <summary>
        /// The http response message returned from the failed API call
        /// </summary>
        public HttpResponseMessage? ResponseMessage { get; set; } = responseMessage;
    }
}
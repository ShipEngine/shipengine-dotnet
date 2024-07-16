#nullable disable

using ShipEngineSDK;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Error object returned by the ShipEngine API when an error occurs.
    /// <see href="https://www.shipengine.com/docs/errors/"/>
    /// </summary>
    public class ShipEngineAPIError
    {
        /// <summary>
        /// A UUID that uniquely identifies the request id.
        /// This can be given to the support team to help debug non-trivial issues that may occur
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// The errors associated with the failed API call
        /// </summary>
        public List<Error> Errors { get; set; }

    }

    /// <summary>
    /// Error returned from the ShipEngine API
    /// </summary>
    public class Error
    {
        /// <summary>
        /// The source of the error, as indicated by the name this informs us if the API call failed
        /// because of the carrier, the order source, or the ShipEngine API itself.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ErrorSource ErrorSource { get; set; }

        /// <summary>
        /// The type of error
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ErrorType ErrorType { get; set; }

        /// <summary>
        /// The error code specified for the failed API Call
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// An error message associated with the failed API call
        /// </summary>
        public string Message { get; set; }
    }
}
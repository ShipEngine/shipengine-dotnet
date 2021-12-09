#nullable disable

using Newtonsoft.Json;
using ShipEngineSDK.Common;
using System.Collections.Generic;

namespace ShipEngineSDK.ValidateAddresses
{
    /// <summary>
    /// Addresss validation result
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Indicates whether the address has been verified
        /// </summary>
        public AddressValidationResult Status { get; set; }

        /// <summary>
        /// The address given to be validated
        /// </summary>
        public Address OriginalAddress { get; set; }

        /// <summary>
        /// The normalized form of the address. This will only be populated if the
        /// address was valid(i.e. `isValid` is `true`).
        ///
        /// Addresses are normalized according to the normalization rules of the
        /// country they're in.
        /// </summary>
        [JsonProperty("matched_address")]
        public Address NormalizedAddress { get; set; }

        /// <summary>
        /// Messages about the address validation, such as corrections or invalid fields.
        /// </summary>
        public List<Messages> Messages { get; set; }
    }

    /// <summary>
    /// Messages associated with the address validation
    /// </summary>
    public class Messages
    {
        /// <summary>
        /// The error codes that can be returned by the address validation API
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Message explaining the address validation error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The different types of messages that can be returned by the address validation API
        /// </summary>
        public ValidationMessageType Type { get; set; }

        /// <summary>
        /// The detailed error codes that can be returned by the address validation API
        /// </summary>
        public ValidationMessageDetailCode? DetailCode { get; set; }
    }
}
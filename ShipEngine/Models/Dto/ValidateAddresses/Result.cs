using Newtonsoft.Json;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.ValidateAddresses.Result
{
    public class ValidateAddressResult
    {
        /// <summary>
        /// Indicates whether the address has been verified
        /// </summary>
        public AddressValidationResult? Status { get; set; }

        /// <summary>
        /// The address given to be validated
        /// </summary>
        public AddressResult? OriginalAddress { get; set; }

        /// <summary>
        /// The normalized form of the address. This will only be populated if the
        /// address was valid(i.e. `isValid` is `true`).
        ///
        /// Addresses are normalized according to the normalization rules of the
        /// country they're in.
        /// </summary>
        [JsonProperty("matched_address")]
        public AddressResult? NormalizedAddress { get; set; }

        /// <summary>
        /// Messages about the address validation, such as corrections or invalid fields.
        /// </summary>
        public List<Messages>? Messages { get; set; }
    }

    public class Messages
    {
        /// <summary>
        /// The error codes that can be returned by the address validation API
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Message explaining the address validation error
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// The different types of messages that can be returned by the address validation API
        /// </summary>
        public ValidationMessageType? Type { get; set; }

        /// <summary>
        /// The detailed error codes that can be returned by the address validation API
        /// </summary>
        public ValidationMessageDetailCode? DetailCode { get; set; }
    }

    public class AddressResult
    {
        /// <summary>
        /// The name of the sender or recipient at the address, if applicable.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The phone number associated with this address, if any.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// The company name, if this is a business address.
        /// </summary>
        public string? CompanyName { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// The city or locality of the address.
        /// </summary>
        public string? CityLocality { get; set; }

        /// <summary>
        /// The state or province
        /// </summary>
        public string? StateProvince { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The ISO 3166 <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">country code</see>
        /// </summary>
        public Country? CountryCode { get; set; }

        /// <summary>
        /// Indicates whether the address is residential or commercial, if known.
        /// </summary>
        public AddressResidentialIndicator? AddressResidentialIndicator { get; set; }
    }
}
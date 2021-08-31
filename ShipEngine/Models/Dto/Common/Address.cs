using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// A physical address for a person or company.
    /// </summary>
    public class Address
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
        /// The city or locality
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
        /// The <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">ISO 3166 country code</see>
        /// </summary>
        public Country? CountryCode { get; set; }

        /// <summary>
        /// Indicates whether the address is residential or commercial, if known.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressResidentialIndicator? AddressResidentialIndicator { get; set; }
    }
}
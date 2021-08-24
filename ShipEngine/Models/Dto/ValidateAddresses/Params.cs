
namespace ShipEngineSDK.ValidateAddresses.Params
{
    public class Address
    {
        /**
       * The first line of the address.
       */
        public string? AddressLine1 { get; set; }

        /**
         * The second line of the address.
         */
        public string? AddressLine2 { get; set; }

        /**
         * The third line of the address.
         */
        public string? AddressLine3 { get; set; }

        /**
         * The ISO 3166 country code
         *
         * @see https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
         */
        // TODO: Replace string? with enum?
        public string? CountryCode { get; set; }

        /**
         * The name of the sender or recipient at the address, if applicable.
         */
        public string? Name { get; set; }

        /**
         * The company name, if this is a business address.
         */
        public string? CompanyName { get; set; }

        /**
         * The phone number associated with this address, if any.
         */
        public string? Phone { get; set; }

        /**
         * The city or locality
         */
        public string? CityLocality { get; set; }

        /**
         * The state or province
         */
        public string? StateProvince { get; set; }

        /**
         * The postal code
         */
        public string? PostalCode { get; set; }

        /**
         * Indicates whether the address is residential or commercial, if known.
         */
        //TODO: Turn into Enum of "unknown", "yes", "no" ??
        public string? AddressResidentialIndicator { get; set; } = "unknown";

    }
}
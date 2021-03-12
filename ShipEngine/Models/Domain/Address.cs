
using System.Collections.Generic;

namespace ShipEngine.Models.Domain
{
    public class Address
    {
        public Address(List<string> street, string cityLocality, string stateProvince, string postalCode, string countryCode, bool? residential)
        {
            CountryCode = countryCode;
            PostalCode = postalCode;
            Residential = residential;
            StateProvince = stateProvince;
            CityLocality = cityLocality;
            Street = street;
        }

        public string CountryCode { get; set; }

        public string PostalCode { get; set; }

        public bool? Residential { get; set; }

        public string StateProvince { get; set; }

        public string CityLocality { get; set; }

        public List<string> Street { get; set; }

    }
}
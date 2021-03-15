using ShipEngine.Models;
using ShipEngine.Models.Address.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipEngine.ConvenienceMethods
{
    public static class AddressExtensions
    {
        public async static Task<Address> ValidateAddress(this ShipEngine shipEngine, string cityLocality, string countryCode, string postalCode, string stateProvince, IEnumerable<string> street)
        {
            var addressValidationParams = new AddressValidationParams
            {
                CityLocality = cityLocality,
                CountryCode = countryCode,
                PostalCode = postalCode,
                StateProvince = stateProvince,
                Street = street.ToList()
            };

            var response = await shipEngine.Address.Validate(addressValidationParams);

            var result = response.UnwrapResultOrThrow();

            return result.Address;
        }
    };
};
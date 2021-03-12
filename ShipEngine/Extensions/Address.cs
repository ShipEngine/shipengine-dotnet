using ShipEngine.Models;
using ShipEngine.Models.Address.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipEngine.Extensions
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

            AddressValidationResult result = await shipEngine.Address.Validate(addressValidationParams);

            result.Messages.AssertNoErrorMessages();

            return new Address(
                street: result.Address.Street,
                cityLocality: result.Address.CityLocality,
                stateProvince: result.Address.StateProvince,
                postalCode: result.Address.PostalCode,
                countryCode: result.Address.CountryCode,
                residential: result.Address.Residential
            );
        }
    };
};
using ShipEngine.Models.Package.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShipEngine.Extensions
{
    public static class PackageExtensions
    {
        public async static Task<TrackPackageResult> TrackPackage(this ShipEngine shipEngine, string cityLocality, string countryCode, string postalCode, string stateProvince, List<string> street)
        {
            var packageValidationParams = new PackageValidationParams
            {
                CityLocality = cityLocality,
                CountryCode = countryCode,
                PostalCode = postalCode,
                StateProvince = stateProvince,
                Street = street
            };

            PackageValidationResult result = await shipEngine.TrackPackage.Track(packageValidationParams);
            var packageDomain = new Package(
                street: result.Package.Street,
                cityLocality: result.Package.CityLocality,
                stateProvince: result.Package.StateProvince,
                postalCode: result.Package.PostalCode,
                countryCode: result.Package.CountryCode,
                residential: result.Package.Residential
            );
            return packageDomain;
        }
    };
};
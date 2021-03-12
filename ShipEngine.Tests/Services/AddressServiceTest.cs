using NUnit.Framework;
using ShipEngine.Extensions;
using ShipEngine.Models.Address.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShipEngine.Tests
{
    public class AddressService : BaseShipEngineServiceTest
    {

        [Test]
        public async Task AddressValidationConvenienceTest()
        {
            AddressValidationParams p = new()
            {
                Street = new List<string> { "100 Fake Street" },
                CityLocality = "Chicago",
                CountryCode = "US",
                PostalCode = "60613",
                StateProvince = "IL",
            };
            // throw new IgnoreException("This should work, but simengine only returns lists right now.");
            Address validationResult = await MockShipEngineClient.ValidateAddress(
                street: p.Street, cityLocality: p.CityLocality, countryCode: p.CityLocality,
                postalCode: p.PostalCode, stateProvince: p.StateProvince
            );
            Assert.That(validationResult.Residential, Is.InstanceOf<bool>());
            Assert.That(validationResult.PostalCode, Is.InstanceOf<string>());
            Assert.That(validationResult.CountryCode, Is.EqualTo("US"));
            Assert.That(validationResult.Residential, Is.InstanceOf<bool>());
            Assert.That(validationResult.Street, Is.InstanceOf<List<string>>());
        }
        [Test]
        public async Task AddressValidationBulkTest()
        {
            List<AddressValidationParams> paramsList = new()
            {
                new()
                {
                    Street = new List<string> { "validate-batch" }, // magic string triggers hoverfly batch
                    CityLocality = "Chicago",
                    CountryCode = "US",
                    PostalCode = "60613",
                    StateProvince = "IL",
                }
            };

            var results = await MockShipEngineClient.Address.Validate(paramsList);
            results.ForEach((validationResult) =>
            {
                var r = validationResult.Result;
                Assert.That(r.Address.CountryCode, Is.EqualTo("US"));
                Assert.That(r.Valid, Is.InstanceOf<bool>());
                Assert.That(r.Messages.Errors, Is.InstanceOf<List<string>>());
                Assert.That(r.Messages.Info, Is.InstanceOf<List<string>>());
                Assert.That(r.Messages.Warnings, Is.InstanceOf<List<string>>());
            });
        }

    }
}
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
        readonly AddressValidationParams AddressValidationParamsFixture = new()
        {
            Street = new List<string> { "One", "Two", "Three" },
            CityLocality = "Chicago",
            CountryCode = "US",
            PostalCode = "60613",
            StateProvince = "IL",
        };

        [Test]
        public async Task AddressValidationHighLevelTest()
        {
            List<AddressValidationResult> results = await MockShipEngineClient.Address.Validate(new List<AddressValidationParams> { AddressValidationParamsFixture });
            results.ForEach((validationResult) =>
            {
                Assert.That(validationResult.Address.CountryCode, Is.EqualTo("US"));
                Assert.That(validationResult.Valid, Is.InstanceOf<bool>());
                Assert.That(validationResult.Messages.Errors, Is.InstanceOf<List<string>>());
                Assert.That(validationResult.Messages.Info, Is.InstanceOf<List<string>>());
                Assert.That(validationResult.Messages.Warnings, Is.InstanceOf<List<string>>());
            });
        }

        [Test]
        public async Task AddressValidationConvenienceTest()
        {
            throw new IgnoreException("This should work, but simengine only returns lists right now.");
            var p = AddressValidationParamsFixture;
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
    }
}
using NUnit.Framework;
using ShipEngine.Extensions;
using ShipEngine.Models.Address.Dto;
using ShipEngine.Models.Domain;
using ShipEngine.Models.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShipEngine.Tests
{
    public class Fixtures
    {
        public static AddressValidationParams AddressValidationParams(bool shouldError = true)
        {
            return new AddressValidationParams()
            {
                Street = new List<string> { shouldError ? "100 Fake Street" : "with-error" },
                CityLocality = "Chicago",
                CountryCode = "US",
                PostalCode = "60613",
                StateProvince = "IL",
            };
        }
    }

    public class AddressService : BaseShipEngineServiceTest
    {

        [Test]
        public async Task AddressValidationConvenienceTest()
        {
            var p = Fixtures.AddressValidationParams();
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
        public async Task AddressValidationConvenienceTestError()
        {
            var p = Fixtures.AddressValidationParams(shouldError: true);
            try
            {

                await MockShipEngineClient.ValidateAddress(
                    street: p.Street, cityLocality: p.CityLocality, countryCode: "with-error",
                    postalCode: p.PostalCode, stateProvince: p.StateProvince
                );
                Assert.Fail("should throw");
            }
            catch (ShipEngineException e)
            {
                Assert.That(e.Message, Is.EqualTo("Invalid City, State, or Zip"));
            }
        }

        [Test]
        public async Task AddressValidationBulkTest()
        {
            List<AddressValidationParams> paramsList = new() { Fixtures.AddressValidationParams() };

            var results = await MockShipEngineClient.Address.Validate(paramsList);
            results.ForEach((validationResult) =>
            {
                var r = validationResult.Result;
                Assert.That(r.Address.CountryCode, Has.Length.EqualTo(2));
                Assert.That(r.Valid, Is.InstanceOf<bool>());
                Assert.That(r.Messages.Errors, Is.InstanceOf<List<string>>());
                Assert.That(r.Messages.Info, Is.InstanceOf<List<string>>());
                Assert.That(r.Messages.Warnings, Is.InstanceOf<List<string>>());
            });
        }

    }
}
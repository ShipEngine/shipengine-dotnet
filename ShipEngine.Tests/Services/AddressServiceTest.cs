using NUnit.Framework;
using ShipEngine.ConvenienceMethods;
using ShipEngine.Models.Address.Dto;
using ShipEngine.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipEngine.Tests
{
    public class Fixtures
    {
        public static AddressValidationParams AddressValidationParams(bool shouldError = false)
        {
            return new AddressValidationParams()
            {
                Street = new List<string> { shouldError ? "with-error" : "100 Fake street" },
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
            Address address = await MockShipEngineClient.ValidateAddress(
                street: p.Street, cityLocality: p.CityLocality, countryCode: p.CityLocality,
                postalCode: p.PostalCode, stateProvince: p.StateProvince
            );
            Assert.That(address.Residential, Is.InstanceOf<bool>());
            Assert.That(address.PostalCode, Is.InstanceOf<string>());
            Assert.That(address.CountryCode, Is.EqualTo("US"));
            Assert.That(address.Residential, Is.InstanceOf<bool>());
            Assert.That(address.Street, Is.InstanceOf<IEnumerable<string>>());
        }

        [Test]
        public async Task AddressValidationConvenienceTestError()
        {
            var p = Fixtures.AddressValidationParams(shouldError: true);
            try
            {

                var result = await MockShipEngineClient.ValidateAddress(
                     street: p.Street, cityLocality: p.CityLocality, countryCode: p.CountryCode,
                     postalCode: p.PostalCode, stateProvince: p.StateProvince
                 );
                Assert.Fail("should throw");
            }
            catch (ShipEngineException e)
            {
                Assert.That("Invalid City, State, or Zip", Is.EqualTo(e.Message));
            }
        }

        [Test]
        public async Task AddressValidationBulkTest()
        {
            List<AddressValidationParams> paramsList = new() { Fixtures.AddressValidationParams(), Fixtures.AddressValidationParams() };

            var responses = await MockShipEngineClient.Address.Validate(paramsList);
            responses.ToList().ForEach((response) =>
            {
                var r = response.Result;
                Assert.That(r.Address.CountryCode, Has.Length.EqualTo(2));
                Assert.That(r.Valid, Is.InstanceOf<bool>());
                Assert.That(r.Messages.Errors, Is.InstanceOf<IEnumerable<string>>());
                Assert.That(r.Messages.Info, Is.InstanceOf<IEnumerable<string>>());
                Assert.That(r.Messages.Warnings, Is.InstanceOf<IEnumerable<string>>());
            });
        }

        [Test]
        public async Task AddressValidationBulkErrorTest()
        {
            List<AddressValidationParams> p = new() { Fixtures.AddressValidationParams(shouldError: true) };

            var responses = await MockShipEngineClient.Address.Validate(p);
            bool hasErrorResponse = false;
            responses.ToList().ForEach((response) =>
            {
                AddressValidationResult r = response.Result;
                if (!r.Valid)
                {
                    Assert.That(r.Address, Is.Null);
                    Assert.That(r.Valid, Is.InstanceOf<bool>());
                    Assert.That(r.Messages.Errors, Is.InstanceOf<IEnumerable<string>>());
                    Assert.That(r.Messages.Info, Is.InstanceOf<IEnumerable<string>>());
                    Assert.That(r.Messages.Warnings, Is.InstanceOf<IEnumerable<string>>());
                    hasErrorResponse = true;
                }
                else
                {
                    Assert.That(r.Address.CountryCode.Length, Is.EqualTo(2));
                }
            });
            if (!hasErrorResponse)
            {
                throw new AssertionException("should have an errror response");
            }
        }
    }
}
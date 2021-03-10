using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine.Models;
using ShipEngine.Extensions;
using ShipEngine.Models.Address.Dto;
using System.Collections.Generic;

namespace ShipEngine.Tests
{
    public class AddressService : BaseShipEngineServiceTest
    {
        [SetUp]

        [Test]
        public async Task AddressValidationHighLevelTest()
        {
            AddressValidationParams p = new AddressValidationParams
            {
                Street = new List<string> { "One", "Two", "Three" },
                CityLocality = "Chicago",
                CountryCode = "US",
                PostalCode = "60613",
                StateProvince = "IL",
            };

            var validationResult = await MockShipEngineClient.Address.Validate(p);
            Assert.AreEqual(validationResult.Address.CountryCode, "US");
        }
    }
}
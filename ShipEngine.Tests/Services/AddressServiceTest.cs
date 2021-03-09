using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine.Models;
using ShipEngine.Extensions;

namespace ShipEngine.Tests
{
    public class AddressService : BaseShipEngineServiceTest
    {
        [SetUp]

        [Test]
        public async Task TestServicesAndExtensions()
        {
            var shipEngine = this.MockShipEngineClient;
            string one = await shipEngine.CreateTag("foo");
            Assert.AreEqual("foo", one);

            CreateTagParams createTagParams = new CreateTagParams
            {
                Name = "foo"
            };
            CreateTagResult two = await shipEngine.Tags.Create(createTagParams);
            Assert.AreEqual("foo", two.Name);
        }
    }
}
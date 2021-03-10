using NUnit.Framework;
using ShipEngine.Extensions;
using ShipEngine.Models;
using System;
using System.Threading.Tasks;

namespace ShipEngine.Tests
{
    public class TagsService : BaseShipEngineServiceTest
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
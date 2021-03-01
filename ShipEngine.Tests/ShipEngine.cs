using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine.Models;
using ShipEngine.Extensions;

namespace ShipEngine.Tests
{
    public class ShipEngineTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task TestServicesAndExtensions()
        {
            ShipEngineConfig config = new ShipEngineConfig("API_KEY", "http://localhost:8500");
            ShipEngine shipEngine = new ShipEngine(config);
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
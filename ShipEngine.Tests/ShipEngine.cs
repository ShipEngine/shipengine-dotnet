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
            ShipEngineConfig config = new ShipEngineConfig("API_KEY");
            config.BaseUri = new Uri("http://localhost:8500");

            ShipEngine shipEngine = new ShipEngine(config);

            var one = await shipEngine.CreateTag("foo");
            Assert.AreEqual("foo", one.Name);

            var two = await shipEngine.Tags.Create(new CreateTagParams
            {
                Name = "foo"
            });

            Assert.AreEqual("foo", two.Name);
        }
    }
}
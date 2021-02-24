using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine.Entities;
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
            config.BaseUri = new Uri("http://localhost:9999");

            ShipEngine shipEngine = new ShipEngine(config);

            Tag one = await shipEngine.CreateTag("foo");
            Assert.AreEqual("foo", one.Name);

            Tag two = await shipEngine.Tags.Create("foo");
            Assert.AreEqual("foo", two.Name);
        }
    }
}
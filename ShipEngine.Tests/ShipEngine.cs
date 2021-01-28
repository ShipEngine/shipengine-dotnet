using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine;
using ShipEngine.Extensions;

namespace ShipEngine.Tests
{
    public class Tests
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
            
            var first = await shipEngine.CreateTag("foo");
            Assert.AreEqual("foo", first.Name);

            var second = await shipEngine.Tags.Create("bar");
            Assert.AreEqual("bar", second.Name);
        }
    }
}
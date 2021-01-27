using NUnit.Framework;

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
        public void TestServicesAndExtensions()
        {
            var shipEngine = new ShipEngine();
            Assert.AreEqual(shipEngine.CreateTag("bar"), shipEngine.Tags.Create("bar"));
        }
    }
}
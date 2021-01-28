using NUnit.Framework;
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
            var shipEngine = new ShipEngine();
            
            var first = await shipEngine.CreateTag("foo");
            Assert.AreEqual("foo", first.Name);

            var second = await shipEngine.Tags.Create("bar");
            Assert.AreEqual("bar", second.Name);
        }
    }
}
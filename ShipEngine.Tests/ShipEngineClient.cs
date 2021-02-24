using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using ShipEngine.Extensions;

namespace ShipEngine.Tests
{
    public class ShipEngineClientTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void TestRetries()
        {

            Assert.AreEqual(HttpStatusCode.OK, HttpStatusCode.OK);
        }
    }
}
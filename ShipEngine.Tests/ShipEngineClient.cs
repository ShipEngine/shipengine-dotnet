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
        public async Task TestRetries()
        {
            ShipEngineConfig config = new ShipEngineConfig("API_KEY");
            config.BaseUri = new Uri("http://localhost:8500");
            config.Retries = 1;
            config.UserAgent = "TEST";

            ShipEngineClient client = new ShipEngineClient(config);
            
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/retries");
            HttpResponseMessage response = await client.SendAsync(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
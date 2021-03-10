using NUnit.Framework;
using ShipEngine.Extensions;
using ShipEngine.Models;
using System;
using System.Threading.Tasks;

namespace ShipEngine.Tests
{
    public abstract class BaseShipEngineServiceTest
    {
        public ShipEngine MockShipEngineClient;
        public BaseShipEngineServiceTest()
        {
            ShipEngineConfig config = new ShipEngineConfig("API_KEY", "http://localhost:8500");
            MockShipEngineClient = new ShipEngine(config);
        }

    }
}

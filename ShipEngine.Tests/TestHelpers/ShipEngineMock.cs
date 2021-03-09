using NUnit.Framework;
using System;
using System.Threading.Tasks;

using ShipEngine.Models;
using ShipEngine.Extensions;

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



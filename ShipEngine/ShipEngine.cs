using ShipEngine.Services;

namespace ShipEngine
{
    sealed public class ShipEngine
    {
        // SERVICES
        public AddressService Address;
        public PackageService Package;

        public ShipEngine(string apiKey)
        {
            var config = new ShipEngineConfig(apiKey);
            Build(config);
        }

        public ShipEngine(ShipEngineConfig config)
        {
            Build(config);
        }

        private void Build(ShipEngineConfig config)
        {
            var client = new ShipEngineClient(config);
            Address = new AddressService(client);
            Package = new PackageService(client);
        }


    }
}
using ShipEngine.Services;
using System;
using System.Runtime.InteropServices;

namespace ShipEngine
{
    sealed public class ShipEngine
    {
        // SERVICES
        public TagsService Tags;
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
            Tags = new TagsService(client);
            Address = new AddressService(client);
            Package = new PackageService(client);
        }


    }
}
using System;
using System.Runtime.InteropServices;


using ShipEngine.Services;

namespace ShipEngine
{
    sealed public class ShipEngine
    {
        private readonly string Version = "0.0.1";

        // SERVICES
        public TagsService? Tags;

        public ShipEngine(string apiKey)
        {
            ShipEngineConfig config = new ShipEngineConfig(apiKey);
            Build(config);
        }

        public ShipEngine(ShipEngineConfig config)
        {
            Build(config);
        }

        private void Build(ShipEngineConfig config)
        {
            ShipEngineClient client = new ShipEngineClient(config);

            this.Tags = new TagsService(client);
        }


    }
}

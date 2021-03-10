using ShipEngine;

namespace ShipEngine.Services
{
    public abstract class AbstractService
    {
        protected ShipEngineClient Client;
        public AbstractService(ShipEngineClient client)
        {
            Client = client;
        }
    }
}

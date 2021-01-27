using ShipEngine;

namespace ShipEngine.Services
{
  public abstract class AbstractService
  {
    private ShipEngineClient Client;
    public AbstractService(ShipEngineClient client)
    {
      this.Client = client;
    }
  }
}
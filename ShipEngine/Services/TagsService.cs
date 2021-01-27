using ShipEngine;

namespace ShipEngine.Services
{
  
  public class TagsService : AbstractService
  {
    public TagsService(ShipEngineClient client) : base(client)
    {
    }

    public string Create(string bar)
    {
      return "foo" + bar;
    }
  }
}
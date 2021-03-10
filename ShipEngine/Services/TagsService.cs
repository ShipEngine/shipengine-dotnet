using ShipEngine.Models;
using System.Threading.Tasks;
namespace ShipEngine.Services
{

    public class TagsService : AbstractService
    {
        public TagsService(ShipEngineClient client) : base(client)
        {
        }

        public Task<Models.CreateTagResult> Create(CreateTagParams tag)
        {
            return this.Client.Exec<CreateTagParams, CreateTagResult>("tag/create", tag);
        }
    }
}
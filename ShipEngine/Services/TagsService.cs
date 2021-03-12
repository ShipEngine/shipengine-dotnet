using ShipEngine.Models;
using System.Threading.Tasks;
namespace ShipEngine.Services
{

    public class TagsService : AbstractService
    {
        public TagsService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<CreateTagResult> Create(CreateTagParams tag)
        {
            var result = await Client.Exec<CreateTagParams, CreateTagResult>("tag/create", tag);
            return result.UnwrapResultOrThrow();
        }
    }
}
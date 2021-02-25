using System.Threading.Tasks;
using System.Collections.Generic;
using ShipEngine.Models;
namespace ShipEngine.Services
{

    public class TagsService : AbstractService
    {
        public TagsService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<Models.CreateTagResult?> Create(CreateTagParams tag)
        {


            var parameters = new CreateTagParams
            {
                Name = tag.Name
            };

            var createTagResult = await this.Client.exec<CreateTagParams, CreateTagResult>("tag/create", parameters);

            // Put stuff like "coercing to date", turning messages -> info, etc into CreateTagResult
            return createTagResult;
        }
    }
}

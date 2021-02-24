using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShipEngine.Entities;

namespace ShipEngine.Services
{

    public class TagsService : AbstractService
    {
        public TagsService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<Entities.Tag?> Create(string tag)
        {

            var parameters = new Dictionary<string, object>();
            parameters.Add("name", tag);
            var response = await this.Client.exec<Tag, Tag>("tag/create", parameters);

            return response;
        }
    }
}

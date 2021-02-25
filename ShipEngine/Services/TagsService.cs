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

        public async Task<CreateTagResult?> Create(string tagName)
        {

            var parameters = new Dictionary<string, object>();
            parameters.Add("name", tagName);
            var response = await this.Client.exec<CreateTagParams, CreateTagResult>("tag/create", parameters);

            return response;
        }
    }
}

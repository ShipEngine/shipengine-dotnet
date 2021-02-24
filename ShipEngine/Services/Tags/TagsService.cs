using System.Threading.Tasks;
using System.Collections.Generic;
using ShipEngine.Domain;
using ShipEngine.Dtos;
namespace ShipEngine.Services
{

    public class TagsService : AbstractService
    {
        public TagsService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<Domain.Tag?> Create(string tag)
        {

            var parameters = new Dictionary<string, object>();
            parameters.Add("name", tag);
            var response = await this.Client.exec<CreateTagParams, CreateTagResult>("tag/create", parameters);

            var domainTag = new Tag
            {
                Name = response.Name
            };
            return domainTag;
        }
    }
}

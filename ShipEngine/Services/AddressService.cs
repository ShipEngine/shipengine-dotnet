using System.Threading.Tasks;
using ShipEngine.Models;
namespace ShipEngine.Services
{

    public class AddressService : AbstractService
    {
        public AddressService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<Models.CreateTagResult> Create(CreateTagParams tag)
        {
            var createTagResult = await this.Client.exec<CreateTagParams, CreateTagResult>("tag/create", tag);
            return createTagResult;
        }
    }
}

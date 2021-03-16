using ShipEngine.Models.Address.Dto;
using ShipEngine.Models.JsonRpc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipEngine.Services
{

    public class AddressService : AbstractService
    {
        public AddressService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<JsonRpcResponse<AddressValidationResult>> Validate(AddressValidationParams address)
        {
            var responses = await Validate(new List<AddressValidationParams> { address });
            return responses.First();
        }

        public async Task<IEnumerable<JsonRpcResponse<AddressValidationResult>>> Validate(IEnumerable<AddressValidationParams> addresses)
        {
            var responses = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
            return responses;
        }
    }
}
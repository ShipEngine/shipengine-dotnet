using ShipEngine.Models.Address.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.Models.JsonRpc;
using System.Linq;
using ShipEngine.ConvenienceMethods;

namespace ShipEngine.Services
{

    public class AddressService : AbstractService
    {
        public AddressService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<JsonRpcResponse<AddressValidationResult>> Validate(AddressValidationParams address)
        {
            var responses = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", new List<AddressValidationParams> { address });
            return responses.First();
        }

        public async Task<IEnumerable<JsonRpcResponse<AddressValidationResult>>> Validate(IEnumerable<AddressValidationParams> addresses)
        {
            var result = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
            return result;
        }
    }
}
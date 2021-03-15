using ShipEngine.Models.Address.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.Models.JsonRpc;
using System.Linq;
using ShipEngine.Extensions;

namespace ShipEngine.Services
{

    public class AddressService : AbstractService
    {
        public AddressService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<AddressValidationResult> Validate(AddressValidationParams address)
        {
            var result = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", address);
            return result.UnwrapResultOrThrow();
        }

        public async Task<IEnumerable<JsonRpcResponse<AddressValidationResult>>> Validate(IEnumerable<AddressValidationParams> addresses)
        {
            var result = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
            return result;
        }
    }
}
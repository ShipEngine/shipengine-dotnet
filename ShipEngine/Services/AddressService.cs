using ShipEngine.Models.Address.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.Models.JsonRpc;
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

        public async Task<List<JsonRpcResponse<AddressValidationResult>>> Validate(List<AddressValidationParams> addresses)
        {
            var result = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
            return result;
        }
    }
}
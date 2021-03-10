using ShipEngine.Models.Address.Dto;
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

        public async Task<AddressValidationResult> Validate(AddressValidationParams address)
        {
            var result = await Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", address);
            return result.UnwrapResultOrThrow();
        }

        // public Task<List<AddressValidationResult>> Validate(List<AddressValidationParams> addresses)
        // {
        //     var result = Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
        // }
    }
}
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

        public Task<AddressValidationResult> Validate(AddressValidationParams address)
        {
            return Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", address);
        }

        public Task<List<AddressValidationResult>> Validate(List<AddressValidationParams> addresses)
        {
            return Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addresses);
        }
    }
}
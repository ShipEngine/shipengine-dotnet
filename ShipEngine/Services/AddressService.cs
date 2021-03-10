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
            var addressList = new List<AddressValidationParams>() { address };
            // Address is capable of bulk, so just putting this here in case we want to change it later. Currently, simengine alwa returns a list.
            var response = await this.Client.Exec<AddressValidationParams, AddressValidationResult>("address/validate", addressList);
            return response.First();
        }
    }
}
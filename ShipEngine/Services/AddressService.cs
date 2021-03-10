using System.Threading.Tasks;
using ShipEngine.Models.Address.Dto;


namespace ShipEngine.Services

{

    public class AddressService : AbstractService
    {
        public AddressService(ShipEngineClient client) : base(client)
        {
        }

        public Task<AddressValidationResult> Validate(AddressValidationParams address)
        {
            return this.Client.exec<AddressValidationParams, AddressValidationResult>("address/validate", address);
        }
    }
}

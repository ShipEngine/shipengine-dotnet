using ShipEngine.Models.Package.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShipEngine.Models.JsonRpc;

namespace ShipEngine.Services

{

    public class PackageService : AbstractService
    {
        public PackageService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<JsonRpcResponse<TrackPackageResult>> Track(TrackPackageParams package)
        {
            var response = await Track(new List<TrackPackageParams> { package });
            return response.First();
        }

        public async Task<IEnumerable<JsonRpcResponse<TrackPackageResult>>> Track(IEnumerable<TrackPackageParams> Packages)
        {
            var result = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", Packages);
            return result;
        }
    }
}
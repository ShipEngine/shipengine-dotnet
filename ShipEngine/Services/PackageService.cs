using ShipEngine.Models.JsonRpc;
using ShipEngine.Models.Package.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipEngine.Services

{

    public class PackageService : AbstractService
    {
        public PackageService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<JsonRpcResponse<TrackPackageResult>> Track(TrackPackageParams package)
        {
            var responses = await Track(new List<TrackPackageParams> { package });
            return responses.First();
        }

        public async Task<IEnumerable<JsonRpcResponse<TrackPackageResult>>> Track(IEnumerable<TrackPackageParams> Packages)
        {
            var response = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", Packages);
            return response;
        }
    }
}
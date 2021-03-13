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

        public async Task<TrackPackageResult> Track(TrackPackageParams package)
        {
            var result = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", package);
            return result.UnwrapResultOrThrow();
        }

        public async Task<IEnumerable<JsonRpcResponse<TrackPackageResult>>> Track(IEnumerable<TrackPackageParams> Packages)
        {
            var result = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", Packages);
            return result;
        }
    }
}
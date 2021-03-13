using ShipEngine.Models.Package.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShipEngine.Models.JsonRpc;
using ShipEngine.Extensions;
using System.Diagnostics.CodeAnalysis;
using System;

namespace ShipEngine.Services

{

    public class PackageService : AbstractService
    {
        public PackageService(ShipEngineClient client) : base(client)
        {
        }

        public async Task<TrackPackageResult> Track(TrackPackageParams package)
        {
            var response = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", package);
            return response.UnwrapResultOrThrow();
        }

        public async Task<IEnumerable<JsonRpcResponse<TrackPackageResult>>> Track(IEnumerable<TrackPackageParams> Packages)
        {
            var result = await Client.Exec<TrackPackageParams, TrackPackageResult>("package/track", Packages);
            return result;
        }
    }
}
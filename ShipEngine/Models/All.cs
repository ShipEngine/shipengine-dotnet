using System.Threading.Tasks;
using Anemonis.JsonRpc.ServiceClient;
namespace ShipEngine.Models
{
    public interface ShipEngineRpcService
    {
        [JsonRpcMethod("get/tags", "tag")]
        Task<CreateTagResult> CreateTag(CreateTagParams c);
    }
}
using System.Threading.Tasks;

using ShipEngine.Models;

namespace ShipEngine.Extensions
{
    public static class TagExtensions
    {
        public static Task<CreateTagResult> CreateTag(this ShipEngine shipEngine, string tag)
        {
            return shipEngine.Tags.Create(tag);
        }
    }
}
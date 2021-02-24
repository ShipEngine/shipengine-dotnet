using System.Threading.Tasks;

using ShipEngine.Entities;

namespace ShipEngine.Extensions
{
    public static class TagExtensions
    {
        public static Task<Tag> CreateTag(this ShipEngine shipEngine, string tag)
        {
            return shipEngine.Tags?.Create(tag);
        }
    }
}
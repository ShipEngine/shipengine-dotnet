using System.Threading.Tasks;

using ShipEngine.Models;

namespace ShipEngine.Extensions
{
    public static class TagExtensions
    {
        public static Task<CreateTagResult> CreateTag(this ShipEngine shipEngine, string tag)
        {
            var tagParams = new CreateTagParams
            {
                Name = tag,
            };

            return shipEngine.Tags.Create(tagParams);

        }
    }
}
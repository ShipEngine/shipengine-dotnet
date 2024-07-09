using ShipEngineSDK;
using Xunit;

namespace ShipEngineTest
{
    public class RequestOptionsTests
    {
        [Fact]
        public void FullPathReturnsPathWhenThereAreNoParameters()
        {
            var result = new RequestOptions("/v1/foo");
            Assert.Equal("/v1/foo", result.FullPath());
        }

        [Fact]
        public void FullPathReturnsPathWithParametersReplaced()
        {
            var result = new RequestOptions("/v1/foo/{id}");
            result.PathParameters.Add("id", "se-12345");
            Assert.Equal("/v1/foo/se-12345", result.FullPath());
        }
    }
}
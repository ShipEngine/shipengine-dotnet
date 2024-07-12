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

        [Fact]
        public void FullPathReturnsPathWithParametersReplacedAndEscaped()
        {
            var result = new RequestOptions("/v1/foo/{id}");
            result.PathParameters.Add("id", "foo bar");
            Assert.Equal("/v1/foo/foo%20bar", result.FullPath());
        }

        [Fact]
        public void FullPathReturnsQueryParameters()
        {
            var result = new RequestOptions("/v1/foo");
            result.QueryParameters.Add("bar", "test-value");
            result.QueryParameters.Add("other", "1");
            Assert.Equal("/v1/foo?bar=test-value&other=1", result.FullPath());
        }

        [Fact]
        public void FullPathReturnsEscapedQueryParameters()
        {
            var result = new RequestOptions("/v1/foo");
            result.QueryParameters.Add("bar", "1&2");
            result.QueryParameters.Add("other", "1");
            Assert.Equal("/v1/foo?bar=1%262&other=1", result.FullPath());
        }
    }
}
using ShipEngineSDK;
using ShipEngineSDK.Enums;
using Xunit;

namespace ShipEngineTest
{
    public class ShipEngineTests
    {

        [Fact]
        public void NullAPIKeyStringThrowsError()
        {
            var ex = Assert.Throws<ShipEngineException>(() => new ShipEngine(apiKey: null));
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.FieldValueRequired, ex.ErrorCode);
            Assert.Equal("A ShipEngine API key must be specified.", ex.Message);
            Assert.Null(ex.RequestId);
        }

        [Fact]
        public void EmptyAPIKeyStringThrowsError()
        {
            var ex = Assert.Throws<ShipEngineException>(() => new ShipEngine(""));
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.FieldValueRequired, ex.ErrorCode);
            Assert.Equal("A ShipEngine API key must be specified.", ex.Message);
            Assert.Null(ex.RequestId);
        }

        [Fact]
        public void InvalidTimeoutAtInstantiation()
        {
            var ex = Assert.Throws<ShipEngineException>(
                () => new ShipEngine(
                    new Config(apiKey: "TEST_1234", timeout: System.TimeSpan.FromSeconds(-1))
                )
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Timeout must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }

        [Fact]
        public void InvalidRetriesAtInstantiation()
        {
            var ex = Assert.Throws<ShipEngineException>(
                () => new ShipEngine(
                    new Config(apiKey: "TEST_1234", retries: -1)
                )
            );
            Assert.Equal(ErrorSource.Shipengine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.InvalidFieldValue, ex.ErrorCode);
            Assert.Equal("Retries must be greater than zero.", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
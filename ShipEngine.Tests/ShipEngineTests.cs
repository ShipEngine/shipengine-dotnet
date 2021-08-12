using ShipEngineSDK;
using ShipEngineSDK.CreateLabelFromShipmentDetails.Params;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Xunit;

namespace ShipEngineTest
{
    public class ShipEngineTests
    {

        [Fact]
        public void EmptyAPIKeyThrowsError()
        {
            var ex = Assert.Throws<ShipEngineException>(() => new ShipEngine(""));
            Assert.Equal(ErrorSource.ShipEngine, ex.ErrorSource);
            Assert.Equal(ErrorType.Validation, ex.ErrorType);
            Assert.Equal(ErrorCode.FieldValueRequired, ex.ErrorCode);
            Assert.Equal("A ShipEngine API key must be specified", ex.Message);
            Assert.Null(ex.RequestId);
        }
    }
}
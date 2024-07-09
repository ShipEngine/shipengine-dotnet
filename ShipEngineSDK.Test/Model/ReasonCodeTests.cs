/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using ShipEngineSDK.Client;
using ShipEngineSDK.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Xunit;

namespace ShipEngineSDK.Test.Model
{
    /// <summary>
    ///  Class for testing ReasonCode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReasonCodeTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new ReasonCode();
            Assert.Equal("unknown", testModel.ToString());
        }

        [Fact]
        public void UnknownTest()
        {
            var testModel = ReasonCode.Unknown;
            Assert.Equal("unknown", testModel.ToString());
        }

        [Fact]
        public void UnspecifiedTest()
        {
            var testModel = ReasonCode.Unspecified;
            Assert.Equal("unspecified", testModel.ToString());
        }

        [Fact]
        public void ValidationFailedTest()
        {
            var testModel = ReasonCode.ValidationFailed;
            Assert.Equal("validation_failed", testModel.ToString());
        }

        [Fact]
        public void LabelNotFoundWithinVoidPeriodTest()
        {
            var testModel = ReasonCode.LabelNotFoundWithinVoidPeriod;
            Assert.Equal("label_not_found_within_void_period", testModel.ToString());
        }

        [Fact]
        public void LabelAlreadyUsedTest()
        {
            var testModel = ReasonCode.LabelAlreadyUsed;
            Assert.Equal("label_already_used", testModel.ToString());
        }

        [Fact]
        public void LabelAlreadyVoidedTest()
        {
            var testModel = ReasonCode.LabelAlreadyVoided;
            Assert.Equal("label_already_voided", testModel.ToString());
        }

        [Fact]
        public void ContactCarrierTest()
        {
            var testModel = ReasonCode.ContactCarrier;
            Assert.Equal("contact_carrier", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new ReasonCode("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a ReasonCode from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<ReasonCode>("\"a custom value\"");
            Assert.IsType<ReasonCode>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
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
    ///  Class for testing ValidateAddress
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ValidateAddressTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new ValidateAddress();
            Assert.Equal("no_validation", testModel.ToString());
        }

        [Fact]
        public void NoValidationTest()
        {
            var testModel = ValidateAddress.NoValidation;
            Assert.Equal("no_validation", testModel.ToString());
        }

        [Fact]
        public void ValidateOnlyTest()
        {
            var testModel = ValidateAddress.ValidateOnly;
            Assert.Equal("validate_only", testModel.ToString());
        }

        [Fact]
        public void ValidateAndCleanTest()
        {
            var testModel = ValidateAddress.ValidateAndClean;
            Assert.Equal("validate_and_clean", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new ValidateAddress("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a ValidateAddress from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<ValidateAddress>("\"a custom value\"");
            Assert.IsType<ValidateAddress>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
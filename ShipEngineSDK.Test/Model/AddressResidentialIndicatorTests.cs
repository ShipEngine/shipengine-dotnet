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
    ///  Class for testing AddressResidentialIndicator
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AddressResidentialIndicatorTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new AddressResidentialIndicator();
            Assert.Equal("unknown", testModel.ToString());
        }

        [Fact]
        public void UnknownTest()
        {
            var testModel = AddressResidentialIndicator.Unknown;
            Assert.Equal("unknown", testModel.ToString());
        }

        [Fact]
        public void YesTest()
        {
            var testModel = AddressResidentialIndicator.Yes;
            Assert.Equal("yes", testModel.ToString());
        }

        [Fact]
        public void NoTest()
        {
            var testModel = AddressResidentialIndicator.No;
            Assert.Equal("no", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new AddressResidentialIndicator("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a AddressResidentialIndicator from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<AddressResidentialIndicator>("\"a custom value\"");
            Assert.IsType<AddressResidentialIndicator>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
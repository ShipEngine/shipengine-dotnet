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
    ///  Class for testing DimensionUnit
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DimensionUnitTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new DimensionUnit();
            Assert.Equal("inch", testModel.ToString());
        }

        [Fact]
        public void InchTest()
        {
            var testModel = DimensionUnit.Inch;
            Assert.Equal("inch", testModel.ToString());
        }

        [Fact]
        public void CentimeterTest()
        {
            var testModel = DimensionUnit.Centimeter;
            Assert.Equal("centimeter", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new DimensionUnit("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a DimensionUnit from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<DimensionUnit>("\"a custom value\"");
            Assert.IsType<DimensionUnit>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
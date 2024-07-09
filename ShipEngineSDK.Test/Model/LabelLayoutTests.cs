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
    ///  Class for testing LabelLayout
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LabelLayoutTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new LabelLayout();
            Assert.Equal("4x6", testModel.ToString());
        }

        [Fact]
        public void _4x6Test()
        {
            var testModel = LabelLayout._4x6;
            Assert.Equal("4x6", testModel.ToString());
        }

        [Fact]
        public void LetterTest()
        {
            var testModel = LabelLayout.Letter;
            Assert.Equal("letter", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new LabelLayout("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a LabelLayout from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<LabelLayout>("\"a custom value\"");
            Assert.IsType<LabelLayout>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
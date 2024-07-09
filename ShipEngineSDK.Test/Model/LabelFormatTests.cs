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
    ///  Class for testing LabelFormat
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LabelFormatTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new LabelFormat();
            Assert.Equal("pdf", testModel.ToString());
        }

        [Fact]
        public void PdfTest()
        {
            var testModel = LabelFormat.Pdf;
            Assert.Equal("pdf", testModel.ToString());
        }

        [Fact]
        public void PngTest()
        {
            var testModel = LabelFormat.Png;
            Assert.Equal("png", testModel.ToString());
        }

        [Fact]
        public void ZplTest()
        {
            var testModel = LabelFormat.Zpl;
            Assert.Equal("zpl", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new LabelFormat("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a LabelFormat from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<LabelFormat>("\"a custom value\"");
            Assert.IsType<LabelFormat>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
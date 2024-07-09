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
    ///  Class for testing FedexPickupType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FedexPickupTypeTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new FedexPickupType();
            Assert.Equal("none", testModel.ToString());
        }

        [Fact]
        public void NoneTest()
        {
            var testModel = FedexPickupType.None;
            Assert.Equal("none", testModel.ToString());
        }

        [Fact]
        public void RegularPickupTest()
        {
            var testModel = FedexPickupType.RegularPickup;
            Assert.Equal("regular_pickup", testModel.ToString());
        }

        [Fact]
        public void RequestCourierTest()
        {
            var testModel = FedexPickupType.RequestCourier;
            Assert.Equal("request_courier", testModel.ToString());
        }

        [Fact]
        public void DropBoxTest()
        {
            var testModel = FedexPickupType.DropBox;
            Assert.Equal("drop_box", testModel.ToString());
        }

        [Fact]
        public void BusinessServiceCenterTest()
        {
            var testModel = FedexPickupType.BusinessServiceCenter;
            Assert.Equal("business_service_center", testModel.ToString());
        }

        [Fact]
        public void StationTest()
        {
            var testModel = FedexPickupType.Station;
            Assert.Equal("station", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new FedexPickupType("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a FedexPickupType from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<FedexPickupType>("\"a custom value\"");
            Assert.IsType<FedexPickupType>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
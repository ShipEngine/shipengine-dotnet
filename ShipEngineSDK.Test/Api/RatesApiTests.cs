/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using ShipEngineSDK.Client;
// uncomment below to import models
using ShipEngineSDK.Model;
using ShipEngineTest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace ShipEngineSDK.Test.Api
{
    /// <summary>
    ///  Class for testing RatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RatesApiTests : IDisposable
    {
        private ShipEngine instance;

        public RatesApiTests()
        {
            var config = new Config("test-key");
            var mockShipEngineFixture = new MockShipEngineFixture(config);
            instance = mockShipEngineFixture.ShipEngine;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RatesApi
            //Assert.IsType<RatesApi>(instance);
        }

        /// <summary>
        /// Test CalculateRates
        /// </summary>
        [Fact]
        public void CalculateRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CalculateRatesRequestBody calculateRatesRequestBody = null;
            //var response = instance.CalculateRates(calculateRatesRequestBody);
            //Assert.IsType<CalculateRatesResponseBody>(response);
        }

        /// <summary>
        /// Test CompareBulkRates
        /// </summary>
        [Fact]
        public void CompareBulkRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompareBulkRatesRequestBody compareBulkRatesRequestBody = null;
            //var response = instance.CompareBulkRates(compareBulkRatesRequestBody);
            //Assert.IsType<List<BulkRate>>(response);
        }

        /// <summary>
        /// Test EstimateRates
        /// </summary>
        [Fact]
        public void EstimateRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EstimateRatesRequestBody estimateRatesRequestBody = null;
            //var response = instance.EstimateRates(estimateRatesRequestBody);
            //Assert.IsType<List<RateEstimate>>(response);
        }

        /// <summary>
        /// Test GetRateById
        /// </summary>
        [Fact]
        public void GetRateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rateId = null;
            //var response = instance.GetRateById(rateId);
            //Assert.IsType<GetRateByIdResponseBody>(response);
        }
    }
}
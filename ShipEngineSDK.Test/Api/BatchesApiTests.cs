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
    ///  Class for testing BatchesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BatchesApiTests : IDisposable
    {
        private ShipEngine instance;

        public BatchesApiTests()
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
        /// Test an instance of BatchesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BatchesApi
            //Assert.IsType<BatchesApi>(instance);
        }

        /// <summary>
        /// Test AddToBatch
        /// </summary>
        [Fact]
        public void AddToBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //AddToBatchRequestBody addToBatchRequestBody = null;
            //var response = instance.AddToBatch(batchId, addToBatchRequestBody);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test CreateBatch
        /// </summary>
        [Fact]
        public void CreateBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBatchRequest createBatchRequest = null;
            //var response = instance.CreateBatch(createBatchRequest);
            //Assert.IsType<CreateBatchResponseBody>(response);
        }

        /// <summary>
        /// Test DeleteBatch
        /// </summary>
        [Fact]
        public void DeleteBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //var response = instance.DeleteBatch(batchId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetBatchByExternalId
        /// </summary>
        [Fact]
        public void GetBatchByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalBatchId = null;
            //var response = instance.GetBatchByExternalId(externalBatchId);
            //Assert.IsType<GetBatchByExternalIdResponseBody>(response);
        }

        /// <summary>
        /// Test GetBatchById
        /// </summary>
        [Fact]
        public void GetBatchByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //var response = instance.GetBatchById(batchId);
            //Assert.IsType<GetBatchByIdResponseBody>(response);
        }

        /// <summary>
        /// Test ListBatchErrors
        /// </summary>
        [Fact]
        public void ListBatchErrorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //int? page = null;
            //int? pagesize = null;
            //var response = instance.ListBatchErrors(batchId, page, pagesize);
            //Assert.IsType<ListBatchErrorsResponseBody>(response);
        }

        /// <summary>
        /// Test ListBatches
        /// </summary>
        [Fact]
        public void ListBatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchStatus? status = null;
            //int? page = null;
            //int? pageSize = null;
            //SortDir? sortDir = null;
            //string batchNumber = null;
            //BatchesSortBy? sortBy = null;
            //var response = instance.ListBatches(status, page, pageSize, sortDir, batchNumber, sortBy);
            //Assert.IsType<ListBatchesResponseBody>(response);
        }

        /// <summary>
        /// Test ProcessBatch
        /// </summary>
        [Fact]
        public void ProcessBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //ProcessBatchRequestBody processBatchRequestBody = null;
            //var response = instance.ProcessBatch(batchId, processBatchRequestBody);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test RemoveFromBatch
        /// </summary>
        [Fact]
        public void RemoveFromBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //RemoveFromBatchRequestBody removeFromBatchRequestBody = null;
            //var response = instance.RemoveFromBatch(batchId, removeFromBatchRequestBody);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UpdateBatch
        /// </summary>
        [Fact]
        public void UpdateBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //var response = instance.UpdateBatch(batchId);
            //Assert.IsType<string>(response);
        }
    }
}
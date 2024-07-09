/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
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
    ///  Class for testing ShipmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShipmentsApiTests : IDisposable
    {
        private ShipEngine instance;

        public ShipmentsApiTests()
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
        /// Test an instance of ShipmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ShipmentsApi
            //Assert.IsType<ShipmentsApi>(instance);
        }

        /// <summary>
        /// Test CancelShipments
        /// </summary>
        [Fact]
        public void CancelShipmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //var response = instance.CancelShipments(shipmentId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test CreateShipments
        /// </summary>
        [Fact]
        public void CreateShipmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateShipmentsRequestBody createShipmentsRequestBody = null;
            //var response = instance.CreateShipments(createShipmentsRequestBody);
            //Assert.IsType<CreateShipmentsResponseBody>(response);
        }

        /// <summary>
        /// Test GetShipmentByExternalId
        /// </summary>
        [Fact]
        public void GetShipmentByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalShipmentId = null;
            //var response = instance.GetShipmentByExternalId(externalShipmentId);
            //Assert.IsType<GetShipmentByExternalIdResponseBody>(response);
        }

        /// <summary>
        /// Test GetShipmentById
        /// </summary>
        [Fact]
        public void GetShipmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //var response = instance.GetShipmentById(shipmentId);
            //Assert.IsType<GetShipmentByIdResponseBody>(response);
        }

        /// <summary>
        /// Test ListShipmentRates
        /// </summary>
        [Fact]
        public void ListShipmentRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //DateTime? createdAtStart = null;
            //var response = instance.ListShipmentRates(shipmentId, createdAtStart);
            //Assert.IsType<ListShipmentRatesResponseBody>(response);
        }

        /// <summary>
        /// Test ListShipments
        /// </summary>
        [Fact]
        public void ListShipmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShipmentStatus? shipmentStatus = null;
            //string batchId = null;
            //string tag = null;
            //DateTime? createdAtStart = null;
            //DateTime? createdAtEnd = null;
            //DateTime? modifiedAtStart = null;
            //DateTime? modifiedAtEnd = null;
            //int? page = null;
            //int? pageSize = null;
            //string salesOrderId = null;
            //SortDir? sortDir = null;
            //ShipmentsSortBy? sortBy = null;
            //var response = instance.ListShipments(shipmentStatus, batchId, tag, createdAtStart, createdAtEnd, modifiedAtStart, modifiedAtEnd, page, pageSize, salesOrderId, sortDir, sortBy);
            //Assert.IsType<ListShipmentsResponseBody>(response);
        }

        /// <summary>
        /// Test ParseShipment
        /// </summary>
        [Fact]
        public void ParseShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParseShipmentRequestBody parseShipmentRequestBody = null;
            //var response = instance.ParseShipment(parseShipmentRequestBody);
            //Assert.IsType<ParseShipmentResponseBody>(response);
        }

        /// <summary>
        /// Test ShipmentsListTags
        /// </summary>
        [Fact]
        public void ShipmentsListTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //var response = instance.ShipmentsListTags(shipmentId);
            //Assert.IsType<TagShipmentResponseBody>(response);
        }

        /// <summary>
        /// Test ShipmentsUpdateTags
        /// </summary>
        [Fact]
        public void ShipmentsUpdateTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateShipmentsTagsRequestBody updateShipmentsTagsRequestBody = null;
            //instance.ShipmentsUpdateTags(updateShipmentsTagsRequestBody);
        }

        /// <summary>
        /// Test TagShipment
        /// </summary>
        [Fact]
        public void TagShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //string tagName = null;
            //var response = instance.TagShipment(shipmentId, tagName);
            //Assert.IsType<TagShipmentResponseBody>(response);
        }

        /// <summary>
        /// Test UntagShipment
        /// </summary>
        [Fact]
        public void UntagShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //string tagName = null;
            //var response = instance.UntagShipment(shipmentId, tagName);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UpdateShipment
        /// </summary>
        [Fact]
        public void UpdateShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //UpdateShipmentRequestBody updateShipmentRequestBody = null;
            //var response = instance.UpdateShipment(shipmentId, updateShipmentRequestBody);
            //Assert.IsType<UpdateShipmentResponseBody>(response);
        }
    }
}
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
    ///  Class for testing CarriersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CarriersApiTests : IDisposable
    {
        private ShipEngine instance;

        public CarriersApiTests()
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
        /// Test an instance of CarriersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CarriersApi
            //Assert.IsType<CarriersApi>(instance);
        }

        /// <summary>
        /// Test AddFundsToCarrier
        /// </summary>
        [Fact]
        public void AddFundsToCarrierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //AddFundsToCarrierRequestBody addFundsToCarrierRequestBody = null;
            //var response = instance.AddFundsToCarrier(carrierId, addFundsToCarrierRequestBody);
            //Assert.IsType<AddFundsToCarrierResponseBody>(response);
        }

        /// <summary>
        /// Test DisconnectCarrierById
        /// </summary>
        [Fact]
        public void DisconnectCarrierByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //var response = instance.DisconnectCarrierById(carrierId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetCarrierById
        /// </summary>
        [Fact]
        public void GetCarrierByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //var response = instance.GetCarrierById(carrierId);
            //Assert.IsType<GetCarrierByIdResponseBody>(response);
        }

        /// <summary>
        /// Test GetCarrierOptions
        /// </summary>
        [Fact]
        public void GetCarrierOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //var response = instance.GetCarrierOptions(carrierId);
            //Assert.IsType<GetCarrierOptionsResponseBody>(response);
        }

        /// <summary>
        /// Test ListCarrierPackageTypes
        /// </summary>
        [Fact]
        public void ListCarrierPackageTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //var response = instance.ListCarrierPackageTypes(carrierId);
            //Assert.IsType<ListCarrierPackageTypesResponseBody>(response);
        }

        /// <summary>
        /// Test ListCarrierServices
        /// </summary>
        [Fact]
        public void ListCarrierServicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierId = null;
            //var response = instance.ListCarrierServices(carrierId);
            //Assert.IsType<ListCarrierServicesResponseBody>(response);
        }

        /// <summary>
        /// Test ListCarriers
        /// </summary>
        [Fact]
        public void ListCarriersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListCarriers();
            //Assert.IsType<GetCarriersResponseBody>(response);
        }
    }
}
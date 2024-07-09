/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;
using ShipEngineSDK.Client;
// uncomment below to import models
using ShipEngineSDK.Model;
using ShipEngineTest;

namespace ShipEngineSDK.Test.Api
{
    /// <summary>
    ///  Class for testing CarrierAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CarrierAccountsApiTests : IDisposable
    {
        private ShipEngine instance;

        public CarrierAccountsApiTests()
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
        /// Test an instance of CarrierAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CarrierAccountsApi
            //Assert.IsType<CarrierAccountsApi>(instance);
        }

        /// <summary>
        /// Test ConnectCarrier
        /// </summary>
        [Fact]
        public void ConnectCarrierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CarrierName carrierName = null;
            //ConnectCarrierRequestBody connectCarrierRequestBody = null;
            //var response = instance.ConnectCarrier(carrierName, connectCarrierRequestBody);
            //Assert.IsType<ConnectCarrierResponseBody>(response);
        }

        /// <summary>
        /// Test DisconnectCarrier
        /// </summary>
        [Fact]
        public void DisconnectCarrierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CarrierName carrierName = null;
            //string carrierId = null;
            //var response = instance.DisconnectCarrier(carrierName, carrierId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetCarrierSettings
        /// </summary>
        [Fact]
        public void GetCarrierSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CarrierNameWithSettings carrierName = null;
            //string carrierId = null;
            //var response = instance.GetCarrierSettings(carrierName, carrierId);
            //Assert.IsType<GetCarrierSettingsResponseBody>(response);
        }

        /// <summary>
        /// Test UpdateCarrierSettings
        /// </summary>
        [Fact]
        public void UpdateCarrierSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CarrierNameWithSettings carrierName = null;
            //string carrierId = null;
            //UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody = null;
            //var response = instance.UpdateCarrierSettings(carrierName, carrierId, updateCarrierSettingsRequestBody);
            //Assert.IsType<string>(response);
        }
    }
}

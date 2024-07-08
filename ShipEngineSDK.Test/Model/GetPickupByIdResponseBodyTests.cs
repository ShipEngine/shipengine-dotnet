/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ShipEngineSDK.Model;
using ShipEngineSDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ShipEngineSDK.Test.Model
{
    /// <summary>
    ///  Class for testing GetPickupByIdResponseBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetPickupByIdResponseBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetPickupByIdResponseBody
        //private GetPickupByIdResponseBody instance;

        public GetPickupByIdResponseBodyTests()
        {
            // TODO uncomment below to create an instance of GetPickupByIdResponseBody
            //instance = new GetPickupByIdResponseBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetPickupByIdResponseBody
        /// </summary>
        [Fact]
        public void GetPickupByIdResponseBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetPickupByIdResponseBody
            //Assert.IsType<GetPickupByIdResponseBody>(instance);
        }

        /// <summary>
        /// Test the property 'PickupId'
        /// </summary>
        [Fact]
        public void PickupIdTest()
        {
            // TODO unit test for the property 'PickupId'
        }

        /// <summary>
        /// Test the property 'LabelIds'
        /// </summary>
        [Fact]
        public void LabelIdsTest()
        {
            // TODO unit test for the property 'LabelIds'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'CancelledAt'
        /// </summary>
        [Fact]
        public void CancelledAtTest()
        {
            // TODO unit test for the property 'CancelledAt'
        }

        /// <summary>
        /// Test the property 'CarrierId'
        /// </summary>
        [Fact]
        public void CarrierIdTest()
        {
            // TODO unit test for the property 'CarrierId'
        }

        /// <summary>
        /// Test the property 'ConfirmationNumber'
        /// </summary>
        [Fact]
        public void ConfirmationNumberTest()
        {
            // TODO unit test for the property 'ConfirmationNumber'
        }

        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Fact]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }

        /// <summary>
        /// Test the property 'PickupAddress'
        /// </summary>
        [Fact]
        public void PickupAddressTest()
        {
            // TODO unit test for the property 'PickupAddress'
        }

        /// <summary>
        /// Test the property 'ContactDetails'
        /// </summary>
        [Fact]
        public void ContactDetailsTest()
        {
            // TODO unit test for the property 'ContactDetails'
        }

        /// <summary>
        /// Test the property 'PickupNotes'
        /// </summary>
        [Fact]
        public void PickupNotesTest()
        {
            // TODO unit test for the property 'PickupNotes'
        }

        /// <summary>
        /// Test the property 'PickupWindow'
        /// </summary>
        [Fact]
        public void PickupWindowTest()
        {
            // TODO unit test for the property 'PickupWindow'
        }

        /// <summary>
        /// Test the property 'PickupWindows'
        /// </summary>
        [Fact]
        public void PickupWindowsTest()
        {
            // TODO unit test for the property 'PickupWindows'
        }

        /// <summary>
        /// Test the property 'RequestId'
        /// </summary>
        [Fact]
        public void RequestIdTest()
        {
            // TODO unit test for the property 'RequestId'
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
    }
}

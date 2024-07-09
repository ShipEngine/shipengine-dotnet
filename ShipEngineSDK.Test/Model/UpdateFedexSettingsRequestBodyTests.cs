/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
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
    ///  Class for testing UpdateFedexSettingsRequestBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdateFedexSettingsRequestBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateFedexSettingsRequestBody
        //private UpdateFedexSettingsRequestBody instance;

        public UpdateFedexSettingsRequestBodyTests()
        {
            // TODO uncomment below to create an instance of UpdateFedexSettingsRequestBody
            //instance = new UpdateFedexSettingsRequestBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateFedexSettingsRequestBody
        /// </summary>
        [Fact]
        public void UpdateFedexSettingsRequestBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateFedexSettingsRequestBody
            //Assert.IsType<UpdateFedexSettingsRequestBody>(instance);
        }

        /// <summary>
        /// Test the property 'Nickname'
        /// </summary>
        [Fact]
        public void NicknameTest()
        {
            // TODO unit test for the property 'Nickname'
        }

        /// <summary>
        /// Test the property 'PickupType'
        /// </summary>
        [Fact]
        public void PickupTypeTest()
        {
            // TODO unit test for the property 'PickupType'
        }

        /// <summary>
        /// Test the property 'SmartPostHub'
        /// </summary>
        [Fact]
        public void SmartPostHubTest()
        {
            // TODO unit test for the property 'SmartPostHub'
        }

        /// <summary>
        /// Test the property 'SmartPostEndorsement'
        /// </summary>
        [Fact]
        public void SmartPostEndorsementTest()
        {
            // TODO unit test for the property 'SmartPostEndorsement'
        }

        /// <summary>
        /// Test the property 'IsPrimaryAccount'
        /// </summary>
        [Fact]
        public void IsPrimaryAccountTest()
        {
            // TODO unit test for the property 'IsPrimaryAccount'
        }

        /// <summary>
        /// Test the property 'SignatureImage'
        /// </summary>
        [Fact]
        public void SignatureImageTest()
        {
            // TODO unit test for the property 'SignatureImage'
        }

        /// <summary>
        /// Test the property 'LetterheadImage'
        /// </summary>
        [Fact]
        public void LetterheadImageTest()
        {
            // TODO unit test for the property 'LetterheadImage'
        }
    }

}
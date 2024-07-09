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
    ///  Class for testing AddressValidationCode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AddressValidationCodeTests
    {
        [Fact]
        public void ParameterlessConstructorSetsDefaultValue()
        {
            var testModel = new AddressValidationCode();
            Assert.Equal("a1000", testModel.ToString());
        }

        [Fact]
        public void A1000Test()
        {
            var testModel = AddressValidationCode.A1000;
            Assert.Equal("a1000", testModel.ToString());
        }

        [Fact]
        public void A1001Test()
        {
            var testModel = AddressValidationCode.A1001;
            Assert.Equal("a1001", testModel.ToString());
        }

        [Fact]
        public void A1002Test()
        {
            var testModel = AddressValidationCode.A1002;
            Assert.Equal("a1002", testModel.ToString());
        }

        [Fact]
        public void A1003Test()
        {
            var testModel = AddressValidationCode.A1003;
            Assert.Equal("a1003", testModel.ToString());
        }

        [Fact]
        public void A1004Test()
        {
            var testModel = AddressValidationCode.A1004;
            Assert.Equal("a1004", testModel.ToString());
        }

        [Fact]
        public void A1005Test()
        {
            var testModel = AddressValidationCode.A1005;
            Assert.Equal("a1005", testModel.ToString());
        }

        [Fact]
        public void A1006Test()
        {
            var testModel = AddressValidationCode.A1006;
            Assert.Equal("a1006", testModel.ToString());
        }

        [Fact]
        public void A1007Test()
        {
            var testModel = AddressValidationCode.A1007;
            Assert.Equal("a1007", testModel.ToString());
        }

        [Fact]
        public void A1008Test()
        {
            var testModel = AddressValidationCode.A1008;
            Assert.Equal("a1008", testModel.ToString());
        }

        [Fact]
        public void R1000Test()
        {
            var testModel = AddressValidationCode.R1000;
            Assert.Equal("r1000", testModel.ToString());
        }

        [Fact]
        public void R1001Test()
        {
            var testModel = AddressValidationCode.R1001;
            Assert.Equal("r1001", testModel.ToString());
        }

        [Fact]
        public void R1002Test()
        {
            var testModel = AddressValidationCode.R1002;
            Assert.Equal("r1002", testModel.ToString());
        }

        [Fact]
        public void R1003Test()
        {
            var testModel = AddressValidationCode.R1003;
            Assert.Equal("r1003", testModel.ToString());
        }


        [Fact]
        public void CustomValueTest()
        {
            var testModel = new AddressValidationCode("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a AddressValidationCode from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<AddressValidationCode>("\"a custom value\"");
            Assert.IsType<AddressValidationCode>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }

}
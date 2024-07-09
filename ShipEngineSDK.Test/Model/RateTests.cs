/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
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
using System.Text.Json;
using ShipEngineSDK.Model;
using ShipEngineSDK.Client;
using System.Reflection;

namespace ShipEngineSDK.Test.Model 
{
    /// <summary>
    ///  Class for testing Rate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Rate
        //private Rate instance;

        public RateTests()
        {
            // TODO uncomment below to create an instance of Rate
            //instance = new Rate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Rate
        /// </summary>
        [Fact]
        public void RateInstanceTest()
        {
            // TODO uncomment below to test "IsType" Rate
            //Assert.IsType<Rate>(instance);
        }

        /// <summary>
        /// Test the property 'RateId'
        /// </summary>
        [Fact]
        public void RateIdTest()
        {
            // TODO unit test for the property 'RateId'
        }

        /// <summary>
        /// Test the property 'RateType'
        /// </summary>
        [Fact]
        public void RateTypeTest()
        {
            // TODO unit test for the property 'RateType'
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
        /// Test the property 'ShippingAmount'
        /// </summary>
        [Fact]
        public void ShippingAmountTest()
        {
            // TODO unit test for the property 'ShippingAmount'
        }

        /// <summary>
        /// Test the property 'InsuranceAmount'
        /// </summary>
        [Fact]
        public void InsuranceAmountTest()
        {
            // TODO unit test for the property 'InsuranceAmount'
        }

        /// <summary>
        /// Test the property 'ConfirmationAmount'
        /// </summary>
        [Fact]
        public void ConfirmationAmountTest()
        {
            // TODO unit test for the property 'ConfirmationAmount'
        }

        /// <summary>
        /// Test the property 'OtherAmount'
        /// </summary>
        [Fact]
        public void OtherAmountTest()
        {
            // TODO unit test for the property 'OtherAmount'
        }

        /// <summary>
        /// Test the property 'RequestedComparisonAmount'
        /// </summary>
        [Fact]
        public void RequestedComparisonAmountTest()
        {
            // TODO unit test for the property 'RequestedComparisonAmount'
        }

        /// <summary>
        /// Test the property 'TaxAmount'
        /// </summary>
        [Fact]
        public void TaxAmountTest()
        {
            // TODO unit test for the property 'TaxAmount'
        }

        /// <summary>
        /// Test the property 'Zone'
        /// </summary>
        [Fact]
        public void ZoneTest()
        {
            // TODO unit test for the property 'Zone'
        }

        /// <summary>
        /// Test the property 'PackageType'
        /// </summary>
        [Fact]
        public void PackageTypeTest()
        {
            // TODO unit test for the property 'PackageType'
        }

        /// <summary>
        /// Test the property 'DeliveryDays'
        /// </summary>
        [Fact]
        public void DeliveryDaysTest()
        {
            // TODO unit test for the property 'DeliveryDays'
        }

        /// <summary>
        /// Test the property 'GuaranteedService'
        /// </summary>
        [Fact]
        public void GuaranteedServiceTest()
        {
            // TODO unit test for the property 'GuaranteedService'
        }

        /// <summary>
        /// Test the property 'EstimatedDeliveryDate'
        /// </summary>
        [Fact]
        public void EstimatedDeliveryDateTest()
        {
            // TODO unit test for the property 'EstimatedDeliveryDate'
        }

        /// <summary>
        /// Test the property 'CarrierDeliveryDays'
        /// </summary>
        [Fact]
        public void CarrierDeliveryDaysTest()
        {
            // TODO unit test for the property 'CarrierDeliveryDays'
        }

        /// <summary>
        /// Test the property 'ShipDate'
        /// </summary>
        [Fact]
        public void ShipDateTest()
        {
            // TODO unit test for the property 'ShipDate'
        }

        /// <summary>
        /// Test the property 'NegotiatedRate'
        /// </summary>
        [Fact]
        public void NegotiatedRateTest()
        {
            // TODO unit test for the property 'NegotiatedRate'
        }

        /// <summary>
        /// Test the property 'ServiceType'
        /// </summary>
        [Fact]
        public void ServiceTypeTest()
        {
            // TODO unit test for the property 'ServiceType'
        }

        /// <summary>
        /// Test the property 'ServiceCode'
        /// </summary>
        [Fact]
        public void ServiceCodeTest()
        {
            // TODO unit test for the property 'ServiceCode'
        }

        /// <summary>
        /// Test the property 'Trackable'
        /// </summary>
        [Fact]
        public void TrackableTest()
        {
            // TODO unit test for the property 'Trackable'
        }

        /// <summary>
        /// Test the property 'CarrierCode'
        /// </summary>
        [Fact]
        public void CarrierCodeTest()
        {
            // TODO unit test for the property 'CarrierCode'
        }

        /// <summary>
        /// Test the property 'CarrierNickname'
        /// </summary>
        [Fact]
        public void CarrierNicknameTest()
        {
            // TODO unit test for the property 'CarrierNickname'
        }

        /// <summary>
        /// Test the property 'CarrierFriendlyName'
        /// </summary>
        [Fact]
        public void CarrierFriendlyNameTest()
        {
            // TODO unit test for the property 'CarrierFriendlyName'
        }

        /// <summary>
        /// Test the property 'ValidationStatus'
        /// </summary>
        [Fact]
        public void ValidationStatusTest()
        {
            // TODO unit test for the property 'ValidationStatus'
        }

        /// <summary>
        /// Test the property 'WarningMessages'
        /// </summary>
        [Fact]
        public void WarningMessagesTest()
        {
            // TODO unit test for the property 'WarningMessages'
        }

        /// <summary>
        /// Test the property 'ErrorMessages'
        /// </summary>
        [Fact]
        public void ErrorMessagesTest()
        {
            // TODO unit test for the property 'ErrorMessages'
        }
    }

}

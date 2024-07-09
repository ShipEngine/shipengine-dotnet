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

namespace ShipEngineSDK.Test.Model 
{
    /// <summary>
    ///  Class for testing AdvancedShipmentOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdvancedShipmentOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdvancedShipmentOptions
        //private AdvancedShipmentOptions instance;

        public AdvancedShipmentOptionsTests()
        {
            // TODO uncomment below to create an instance of AdvancedShipmentOptions
            //instance = new AdvancedShipmentOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdvancedShipmentOptions
        /// </summary>
        [Fact]
        public void AdvancedShipmentOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdvancedShipmentOptions
            //Assert.IsType<AdvancedShipmentOptions>(instance);
        }

        /// <summary>
        /// Test the property 'BillToAccount'
        /// </summary>
        [Fact]
        public void BillToAccountTest()
        {
            // TODO unit test for the property 'BillToAccount'
        }

        /// <summary>
        /// Test the property 'BillToCountryCode'
        /// </summary>
        [Fact]
        public void BillToCountryCodeTest()
        {
            // TODO unit test for the property 'BillToCountryCode'
        }

        /// <summary>
        /// Test the property 'BillToParty'
        /// </summary>
        [Fact]
        public void BillToPartyTest()
        {
            // TODO unit test for the property 'BillToParty'
        }

        /// <summary>
        /// Test the property 'BillToPostalCode'
        /// </summary>
        [Fact]
        public void BillToPostalCodeTest()
        {
            // TODO unit test for the property 'BillToPostalCode'
        }

        /// <summary>
        /// Test the property 'ContainsAlcohol'
        /// </summary>
        [Fact]
        public void ContainsAlcoholTest()
        {
            // TODO unit test for the property 'ContainsAlcohol'
        }

        /// <summary>
        /// Test the property 'DeliveredDutyPaid'
        /// </summary>
        [Fact]
        public void DeliveredDutyPaidTest()
        {
            // TODO unit test for the property 'DeliveredDutyPaid'
        }

        /// <summary>
        /// Test the property 'DryIce'
        /// </summary>
        [Fact]
        public void DryIceTest()
        {
            // TODO unit test for the property 'DryIce'
        }

        /// <summary>
        /// Test the property 'DryIceWeight'
        /// </summary>
        [Fact]
        public void DryIceWeightTest()
        {
            // TODO unit test for the property 'DryIceWeight'
        }

        /// <summary>
        /// Test the property 'NonMachinable'
        /// </summary>
        [Fact]
        public void NonMachinableTest()
        {
            // TODO unit test for the property 'NonMachinable'
        }

        /// <summary>
        /// Test the property 'SaturdayDelivery'
        /// </summary>
        [Fact]
        public void SaturdayDeliveryTest()
        {
            // TODO unit test for the property 'SaturdayDelivery'
        }

        /// <summary>
        /// Test the property 'FedexFreight'
        /// </summary>
        [Fact]
        public void FedexFreightTest()
        {
            // TODO unit test for the property 'FedexFreight'
        }

        /// <summary>
        /// Test the property 'UseUpsGroundFreightPricing'
        /// </summary>
        [Fact]
        public void UseUpsGroundFreightPricingTest()
        {
            // TODO unit test for the property 'UseUpsGroundFreightPricing'
        }

        /// <summary>
        /// Test the property 'FreightClass'
        /// </summary>
        [Fact]
        public void FreightClassTest()
        {
            // TODO unit test for the property 'FreightClass'
        }

        /// <summary>
        /// Test the property 'CustomField1'
        /// </summary>
        [Fact]
        public void CustomField1Test()
        {
            // TODO unit test for the property 'CustomField1'
        }

        /// <summary>
        /// Test the property 'CustomField2'
        /// </summary>
        [Fact]
        public void CustomField2Test()
        {
            // TODO unit test for the property 'CustomField2'
        }

        /// <summary>
        /// Test the property 'CustomField3'
        /// </summary>
        [Fact]
        public void CustomField3Test()
        {
            // TODO unit test for the property 'CustomField3'
        }

        /// <summary>
        /// Test the property 'OriginType'
        /// </summary>
        [Fact]
        public void OriginTypeTest()
        {
            // TODO unit test for the property 'OriginType'
        }

        /// <summary>
        /// Test the property 'AdditionalHandling'
        /// </summary>
        [Fact]
        public void AdditionalHandlingTest()
        {
            // TODO unit test for the property 'AdditionalHandling'
        }

        /// <summary>
        /// Test the property 'ShipperRelease'
        /// </summary>
        [Fact]
        public void ShipperReleaseTest()
        {
            // TODO unit test for the property 'ShipperRelease'
        }

        /// <summary>
        /// Test the property 'CollectOnDelivery'
        /// </summary>
        [Fact]
        public void CollectOnDeliveryTest()
        {
            // TODO unit test for the property 'CollectOnDelivery'
        }

        /// <summary>
        /// Test the property 'ThirdPartyConsignee'
        /// </summary>
        [Fact]
        public void ThirdPartyConsigneeTest()
        {
            // TODO unit test for the property 'ThirdPartyConsignee'
        }

        /// <summary>
        /// Test the property 'DangerousGoods'
        /// </summary>
        [Fact]
        public void DangerousGoodsTest()
        {
            // TODO unit test for the property 'DangerousGoods'
        }

        /// <summary>
        /// Test the property 'DangerousGoodsContact'
        /// </summary>
        [Fact]
        public void DangerousGoodsContactTest()
        {
            // TODO unit test for the property 'DangerousGoodsContact'
        }
    }
}


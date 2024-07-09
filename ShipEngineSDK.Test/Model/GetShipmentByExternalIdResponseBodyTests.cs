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
    ///  Class for testing GetShipmentByExternalIdResponseBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetShipmentByExternalIdResponseBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetShipmentByExternalIdResponseBody
        //private GetShipmentByExternalIdResponseBody instance;

        public GetShipmentByExternalIdResponseBodyTests()
        {
            // TODO uncomment below to create an instance of GetShipmentByExternalIdResponseBody
            //instance = new GetShipmentByExternalIdResponseBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetShipmentByExternalIdResponseBody
        /// </summary>
        [Fact]
        public void GetShipmentByExternalIdResponseBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetShipmentByExternalIdResponseBody
            //Assert.IsType<GetShipmentByExternalIdResponseBody>(instance);
        }

        /// <summary>
        /// Test the property 'ShipmentId'
        /// </summary>
        [Fact]
        public void ShipmentIdTest()
        {
            // TODO unit test for the property 'ShipmentId'
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
        /// Test the property 'ServiceCode'
        /// </summary>
        [Fact]
        public void ServiceCodeTest()
        {
            // TODO unit test for the property 'ServiceCode'
        }

        /// <summary>
        /// Test the property 'ShippingRuleId'
        /// </summary>
        [Fact]
        public void ShippingRuleIdTest()
        {
            // TODO unit test for the property 'ShippingRuleId'
        }

        /// <summary>
        /// Test the property 'ExternalOrderId'
        /// </summary>
        [Fact]
        public void ExternalOrderIdTest()
        {
            // TODO unit test for the property 'ExternalOrderId'
        }

        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Fact]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }

        /// <summary>
        /// Test the property 'TaxIdentifiers'
        /// </summary>
        [Fact]
        public void TaxIdentifiersTest()
        {
            // TODO unit test for the property 'TaxIdentifiers'
        }

        /// <summary>
        /// Test the property 'ExternalShipmentId'
        /// </summary>
        [Fact]
        public void ExternalShipmentIdTest()
        {
            // TODO unit test for the property 'ExternalShipmentId'
        }

        /// <summary>
        /// Test the property 'ShipmentNumber'
        /// </summary>
        [Fact]
        public void ShipmentNumberTest()
        {
            // TODO unit test for the property 'ShipmentNumber'
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
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'ModifiedAt'
        /// </summary>
        [Fact]
        public void ModifiedAtTest()
        {
            // TODO unit test for the property 'ModifiedAt'
        }

        /// <summary>
        /// Test the property 'ShipmentStatus'
        /// </summary>
        [Fact]
        public void ShipmentStatusTest()
        {
            // TODO unit test for the property 'ShipmentStatus'
        }

        /// <summary>
        /// Test the property 'ShipTo'
        /// </summary>
        [Fact]
        public void ShipToTest()
        {
            // TODO unit test for the property 'ShipTo'
        }

        /// <summary>
        /// Test the property 'ShipFrom'
        /// </summary>
        [Fact]
        public void ShipFromTest()
        {
            // TODO unit test for the property 'ShipFrom'
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
        /// Test the property 'ReturnTo'
        /// </summary>
        [Fact]
        public void ReturnToTest()
        {
            // TODO unit test for the property 'ReturnTo'
        }

        /// <summary>
        /// Test the property 'IsReturn'
        /// </summary>
        [Fact]
        public void IsReturnTest()
        {
            // TODO unit test for the property 'IsReturn'
        }

        /// <summary>
        /// Test the property 'Confirmation'
        /// </summary>
        [Fact]
        public void ConfirmationTest()
        {
            // TODO unit test for the property 'Confirmation'
        }

        /// <summary>
        /// Test the property 'Customs'
        /// </summary>
        [Fact]
        public void CustomsTest()
        {
            // TODO unit test for the property 'Customs'
        }

        /// <summary>
        /// Test the property 'AdvancedOptions'
        /// </summary>
        [Fact]
        public void AdvancedOptionsTest()
        {
            // TODO unit test for the property 'AdvancedOptions'
        }

        /// <summary>
        /// Test the property 'InsuranceProvider'
        /// </summary>
        [Fact]
        public void InsuranceProviderTest()
        {
            // TODO unit test for the property 'InsuranceProvider'
        }

        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }

        /// <summary>
        /// Test the property 'OrderSourceCode'
        /// </summary>
        [Fact]
        public void OrderSourceCodeTest()
        {
            // TODO unit test for the property 'OrderSourceCode'
        }

        /// <summary>
        /// Test the property 'Packages'
        /// </summary>
        [Fact]
        public void PackagesTest()
        {
            // TODO unit test for the property 'Packages'
        }

        /// <summary>
        /// Test the property 'TotalWeight'
        /// </summary>
        [Fact]
        public void TotalWeightTest()
        {
            // TODO unit test for the property 'TotalWeight'
        }

        /// <summary>
        /// Test the property 'ComparisonRateType'
        /// </summary>
        [Fact]
        public void ComparisonRateTypeTest()
        {
            // TODO unit test for the property 'ComparisonRateType'
        }
    }

}

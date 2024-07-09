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
    ///  Class for testing UpdateUpsSettingsRequestBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdateUpsSettingsRequestBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateUpsSettingsRequestBody
        //private UpdateUpsSettingsRequestBody instance;

        public UpdateUpsSettingsRequestBodyTests()
        {
            // TODO uncomment below to create an instance of UpdateUpsSettingsRequestBody
            //instance = new UpdateUpsSettingsRequestBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateUpsSettingsRequestBody
        /// </summary>
        [Fact]
        public void UpdateUpsSettingsRequestBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateUpsSettingsRequestBody
            //Assert.IsType<UpdateUpsSettingsRequestBody>(instance);
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
        /// Test the property 'IsPrimaryAccount'
        /// </summary>
        [Fact]
        public void IsPrimaryAccountTest()
        {
            // TODO unit test for the property 'IsPrimaryAccount'
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
        /// Test the property 'UseCarbonNeutralShippingProgram'
        /// </summary>
        [Fact]
        public void UseCarbonNeutralShippingProgramTest()
        {
            // TODO unit test for the property 'UseCarbonNeutralShippingProgram'
        }

        /// <summary>
        /// Test the property 'UseGroundFreightPricing'
        /// </summary>
        [Fact]
        public void UseGroundFreightPricingTest()
        {
            // TODO unit test for the property 'UseGroundFreightPricing'
        }

        /// <summary>
        /// Test the property 'UseConsolidationServices'
        /// </summary>
        [Fact]
        public void UseConsolidationServicesTest()
        {
            // TODO unit test for the property 'UseConsolidationServices'
        }

        /// <summary>
        /// Test the property 'UseOrderNumberOnMailInnovationsLabels'
        /// </summary>
        [Fact]
        public void UseOrderNumberOnMailInnovationsLabelsTest()
        {
            // TODO unit test for the property 'UseOrderNumberOnMailInnovationsLabels'
        }

        /// <summary>
        /// Test the property 'MailInnovationsEndorsement'
        /// </summary>
        [Fact]
        public void MailInnovationsEndorsementTest()
        {
            // TODO unit test for the property 'MailInnovationsEndorsement'
        }

        /// <summary>
        /// Test the property 'MailInnovationsCostCenter'
        /// </summary>
        [Fact]
        public void MailInnovationsCostCenterTest()
        {
            // TODO unit test for the property 'MailInnovationsCostCenter'
        }

        /// <summary>
        /// Test the property 'UseNegotiatedRates'
        /// </summary>
        [Fact]
        public void UseNegotiatedRatesTest()
        {
            // TODO unit test for the property 'UseNegotiatedRates'
        }

        /// <summary>
        /// Test the property 'AccountPostalCode'
        /// </summary>
        [Fact]
        public void AccountPostalCodeTest()
        {
            // TODO unit test for the property 'AccountPostalCode'
        }

        /// <summary>
        /// Test the property 'Invoice'
        /// </summary>
        [Fact]
        public void InvoiceTest()
        {
            // TODO unit test for the property 'Invoice'
        }
    }
}


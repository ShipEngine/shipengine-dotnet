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
    ///  Class for testing CarrierName
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CarrierNameTests : IDisposable
    {
        [Fact]
        public void DefaultValueReturnsaccess_worldwide
        {
            var testModel = new CarrierName();
            Assert.Equal("access_worldwide", testModel.ToString());
        }

        [Fact]
        public void AccessWorldwideTest()
        {
            var testModel = CarrierName.AccessWorldwide;
            Assert.Equal("access_worldwide", testModel.ToString());
        }

        [Fact]
        public void AmazonBuyShippingTest()
        {
            var testModel = CarrierName.AmazonBuyShipping;
            Assert.Equal("amazon_buy_shipping", testModel.ToString());
        }

        [Fact]
        public void AmazonShippingUkTest()
        {
            var testModel = CarrierName.AmazonShippingUk;
            Assert.Equal("amazon_shipping_uk", testModel.ToString());
        }

        [Fact]
        public void ApcTest()
        {
            var testModel = CarrierName.Apc;
            Assert.Equal("apc", testModel.ToString());
        }

        [Fact]
        public void AsendiaTest()
        {
            var testModel = CarrierName.Asendia;
            Assert.Equal("asendia", testModel.ToString());
        }

        [Fact]
        public void AustraliaPostTest()
        {
            var testModel = CarrierName.AustraliaPost;
            Assert.Equal("australia_post", testModel.ToString());
        }

        [Fact]
        public void CanadaPostTest()
        {
            var testModel = CarrierName.CanadaPost;
            Assert.Equal("canada_post", testModel.ToString());
        }

        [Fact]
        public void DhlEcommerceTest()
        {
            var testModel = CarrierName.DhlEcommerce;
            Assert.Equal("dhl_ecommerce", testModel.ToString());
        }

        [Fact]
        public void DhlExpressTest()
        {
            var testModel = CarrierName.DhlExpress;
            Assert.Equal("dhl_express", testModel.ToString());
        }

        [Fact]
        public void DhlExpressAuTest()
        {
            var testModel = CarrierName.DhlExpressAu;
            Assert.Equal("dhl_express_au", testModel.ToString());
        }

        [Fact]
        public void DhlExpressCaTest()
        {
            var testModel = CarrierName.DhlExpressCa;
            Assert.Equal("dhl_express_ca", testModel.ToString());
        }

        [Fact]
        public void DhlExpressUkTest()
        {
            var testModel = CarrierName.DhlExpressUk;
            Assert.Equal("dhl_express_uk", testModel.ToString());
        }

        [Fact]
        public void DpdTest()
        {
            var testModel = CarrierName.Dpd;
            Assert.Equal("dpd", testModel.ToString());
        }

        [Fact]
        public void EndiciaTest()
        {
            var testModel = CarrierName.Endicia;
            Assert.Equal("endicia", testModel.ToString());
        }

        [Fact]
        public void FedexTest()
        {
            var testModel = CarrierName.Fedex;
            Assert.Equal("fedex", testModel.ToString());
        }

        [Fact]
        public void FedexUkTest()
        {
            var testModel = CarrierName.FedexUk;
            Assert.Equal("fedex_uk", testModel.ToString());
        }

        [Fact]
        public void FirstmileTest()
        {
            var testModel = CarrierName.Firstmile;
            Assert.Equal("firstmile", testModel.ToString());
        }

        [Fact]
        public void ImexTest()
        {
            var testModel = CarrierName.Imex;
            Assert.Equal("imex", testModel.ToString());
        }

        [Fact]
        public void NewgisticsTest()
        {
            var testModel = CarrierName.Newgistics;
            Assert.Equal("newgistics", testModel.ToString());
        }

        [Fact]
        public void OntracTest()
        {
            var testModel = CarrierName.Ontrac;
            Assert.Equal("ontrac", testModel.ToString());
        }

        [Fact]
        public void PurolatorCanadaTest()
        {
            var testModel = CarrierName.PurolatorCanada;
            Assert.Equal("purolator_canada", testModel.ToString());
        }

        [Fact]
        public void RoyalMailTest()
        {
            var testModel = CarrierName.RoyalMail;
            Assert.Equal("royal_mail", testModel.ToString());
        }

        [Fact]
        public void RrDonnelleyTest()
        {
            var testModel = CarrierName.RrDonnelley;
            Assert.Equal("rr_donnelley", testModel.ToString());
        }

        [Fact]
        public void SekoTest()
        {
            var testModel = CarrierName.Seko;
            Assert.Equal("seko", testModel.ToString());
        }

        [Fact]
        public void SendleTest()
        {
            var testModel = CarrierName.Sendle;
            Assert.Equal("sendle", testModel.ToString());
        }

        [Fact]
        public void StampsComTest()
        {
            var testModel = CarrierName.StampsCom;
            Assert.Equal("stamps_com", testModel.ToString());
        }

        [Fact]
        public void UpsTest()
        {
            var testModel = CarrierName.Ups;
            Assert.Equal("ups", testModel.ToString());
        }

        [Fact]
        public void LasershipTest()
        {
            var testModel = CarrierName.Lasership;
            Assert.Equal("lasership", testModel.ToString());
        }
        

        [Fact]
        public void CustomValueTest()
        {
            var testModel = new CarrierName("a custom value");
            Assert.Equal("a custom value", testModel.ToString());
        }

        /// <summary>
        /// Test deserialize a CarrierName from a string
        /// </summary>
        [Fact]
        public void CanDeserializeFromStringTest()
        {
            var testModel = JsonSerializer.Deserialize<CarrierName>("\"a custom value\"");
            Assert.IsType<CarrierName>(testModel);
            Assert.Equal("a custom value", testModel.ToString());
        }
    }
}



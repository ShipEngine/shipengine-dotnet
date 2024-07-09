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
    ///  Class for testing CreateLabelResponseBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateLabelResponseBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateLabelResponseBody
        //private CreateLabelResponseBody instance;

        public CreateLabelResponseBodyTests()
        {
            // TODO uncomment below to create an instance of CreateLabelResponseBody
            //instance = new CreateLabelResponseBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateLabelResponseBody
        /// </summary>
        [Fact]
        public void CreateLabelResponseBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateLabelResponseBody
            //Assert.IsType<CreateLabelResponseBody>(instance);
        }

        /// <summary>
        /// Test the property 'LabelId'
        /// </summary>
        [Fact]
        public void LabelIdTest()
        {
            // TODO unit test for the property 'LabelId'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
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
        /// Test the property 'Shipment'
        /// </summary>
        [Fact]
        public void ShipmentTest()
        {
            // TODO unit test for the property 'Shipment'
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
        /// Test the property 'ShipmentCost'
        /// </summary>
        [Fact]
        public void ShipmentCostTest()
        {
            // TODO unit test for the property 'ShipmentCost'
        }

        /// <summary>
        /// Test the property 'InsuranceCost'
        /// </summary>
        [Fact]
        public void InsuranceCostTest()
        {
            // TODO unit test for the property 'InsuranceCost'
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
        /// Test the property 'TrackingNumber'
        /// </summary>
        [Fact]
        public void TrackingNumberTest()
        {
            // TODO unit test for the property 'TrackingNumber'
        }

        /// <summary>
        /// Test the property 'IsReturnLabel'
        /// </summary>
        [Fact]
        public void IsReturnLabelTest()
        {
            // TODO unit test for the property 'IsReturnLabel'
        }

        /// <summary>
        /// Test the property 'RmaNumber'
        /// </summary>
        [Fact]
        public void RmaNumberTest()
        {
            // TODO unit test for the property 'RmaNumber'
        }

        /// <summary>
        /// Test the property 'IsInternational'
        /// </summary>
        [Fact]
        public void IsInternationalTest()
        {
            // TODO unit test for the property 'IsInternational'
        }

        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Fact]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
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
        /// Test the property 'ChargeEvent'
        /// </summary>
        [Fact]
        public void ChargeEventTest()
        {
            // TODO unit test for the property 'ChargeEvent'
        }

        /// <summary>
        /// Test the property 'OutboundLabelId'
        /// </summary>
        [Fact]
        public void OutboundLabelIdTest()
        {
            // TODO unit test for the property 'OutboundLabelId'
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
        /// Test the property 'TestLabel'
        /// </summary>
        [Fact]
        public void TestLabelTest()
        {
            // TODO unit test for the property 'TestLabel'
        }

        /// <summary>
        /// Test the property 'PackageCode'
        /// </summary>
        [Fact]
        public void PackageCodeTest()
        {
            // TODO unit test for the property 'PackageCode'
        }

        /// <summary>
        /// Test the property 'ValidateAddress'
        /// </summary>
        [Fact]
        public void ValidateAddressTest()
        {
            // TODO unit test for the property 'ValidateAddress'
        }

        /// <summary>
        /// Test the property 'Voided'
        /// </summary>
        [Fact]
        public void VoidedTest()
        {
            // TODO unit test for the property 'Voided'
        }

        /// <summary>
        /// Test the property 'VoidedAt'
        /// </summary>
        [Fact]
        public void VoidedAtTest()
        {
            // TODO unit test for the property 'VoidedAt'
        }

        /// <summary>
        /// Test the property 'LabelDownloadType'
        /// </summary>
        [Fact]
        public void LabelDownloadTypeTest()
        {
            // TODO unit test for the property 'LabelDownloadType'
        }

        /// <summary>
        /// Test the property 'LabelFormat'
        /// </summary>
        [Fact]
        public void LabelFormatTest()
        {
            // TODO unit test for the property 'LabelFormat'
        }

        /// <summary>
        /// Test the property 'DisplayScheme'
        /// </summary>
        [Fact]
        public void DisplaySchemeTest()
        {
            // TODO unit test for the property 'DisplayScheme'
        }

        /// <summary>
        /// Test the property 'LabelLayout'
        /// </summary>
        [Fact]
        public void LabelLayoutTest()
        {
            // TODO unit test for the property 'LabelLayout'
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
        /// Test the property 'LabelImageId'
        /// </summary>
        [Fact]
        public void LabelImageIdTest()
        {
            // TODO unit test for the property 'LabelImageId'
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
        /// Test the property 'TrackingStatus'
        /// </summary>
        [Fact]
        public void TrackingStatusTest()
        {
            // TODO unit test for the property 'TrackingStatus'
        }

        /// <summary>
        /// Test the property 'LabelDownload'
        /// </summary>
        [Fact]
        public void LabelDownloadTest()
        {
            // TODO unit test for the property 'LabelDownload'
        }

        /// <summary>
        /// Test the property 'FormDownload'
        /// </summary>
        [Fact]
        public void FormDownloadTest()
        {
            // TODO unit test for the property 'FormDownload'
        }

        /// <summary>
        /// Test the property 'PaperlessDownload'
        /// </summary>
        [Fact]
        public void PaperlessDownloadTest()
        {
            // TODO unit test for the property 'PaperlessDownload'
        }

        /// <summary>
        /// Test the property 'InsuranceClaim'
        /// </summary>
        [Fact]
        public void InsuranceClaimTest()
        {
            // TODO unit test for the property 'InsuranceClaim'
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
        /// Test the property 'AlternativeIdentifiers'
        /// </summary>
        [Fact]
        public void AlternativeIdentifiersTest()
        {
            // TODO unit test for the property 'AlternativeIdentifiers'
        }

        /// <summary>
        /// Test the property 'TrackingUrl'
        /// </summary>
        [Fact]
        public void TrackingUrlTest()
        {
            // TODO unit test for the property 'TrackingUrl'
        }
    }

}
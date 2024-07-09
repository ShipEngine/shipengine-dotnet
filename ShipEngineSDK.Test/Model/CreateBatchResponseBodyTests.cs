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
    ///  Class for testing CreateBatchResponseBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateBatchResponseBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateBatchResponseBody
        //private CreateBatchResponseBody instance;

        public CreateBatchResponseBodyTests()
        {
            // TODO uncomment below to create an instance of CreateBatchResponseBody
            //instance = new CreateBatchResponseBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateBatchResponseBody
        /// </summary>
        [Fact]
        public void CreateBatchResponseBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateBatchResponseBody
            //Assert.IsType<CreateBatchResponseBody>(instance);
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
        /// Test the property 'LabelFormat'
        /// </summary>
        [Fact]
        public void LabelFormatTest()
        {
            // TODO unit test for the property 'LabelFormat'
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
        /// Test the property 'BatchNumber'
        /// </summary>
        [Fact]
        public void BatchNumberTest()
        {
            // TODO unit test for the property 'BatchNumber'
        }

        /// <summary>
        /// Test the property 'ExternalBatchId'
        /// </summary>
        [Fact]
        public void ExternalBatchIdTest()
        {
            // TODO unit test for the property 'ExternalBatchId'
        }

        /// <summary>
        /// Test the property 'BatchNotes'
        /// </summary>
        [Fact]
        public void BatchNotesTest()
        {
            // TODO unit test for the property 'BatchNotes'
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
        /// Test the property 'ProcessedAt'
        /// </summary>
        [Fact]
        public void ProcessedAtTest()
        {
            // TODO unit test for the property 'ProcessedAt'
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }

        /// <summary>
        /// Test the property 'ProcessErrors'
        /// </summary>
        [Fact]
        public void ProcessErrorsTest()
        {
            // TODO unit test for the property 'ProcessErrors'
        }

        /// <summary>
        /// Test the property 'Warnings'
        /// </summary>
        [Fact]
        public void WarningsTest()
        {
            // TODO unit test for the property 'Warnings'
        }

        /// <summary>
        /// Test the property 'Completed'
        /// </summary>
        [Fact]
        public void CompletedTest()
        {
            // TODO unit test for the property 'Completed'
        }

        /// <summary>
        /// Test the property 'Forms'
        /// </summary>
        [Fact]
        public void FormsTest()
        {
            // TODO unit test for the property 'Forms'
        }

        /// <summary>
        /// Test the property 'Count'
        /// </summary>
        [Fact]
        public void CountTest()
        {
            // TODO unit test for the property 'Count'
        }

        /// <summary>
        /// Test the property 'BatchShipmentsUrl'
        /// </summary>
        [Fact]
        public void BatchShipmentsUrlTest()
        {
            // TODO unit test for the property 'BatchShipmentsUrl'
        }

        /// <summary>
        /// Test the property 'BatchLabelsUrl'
        /// </summary>
        [Fact]
        public void BatchLabelsUrlTest()
        {
            // TODO unit test for the property 'BatchLabelsUrl'
        }

        /// <summary>
        /// Test the property 'BatchErrorsUrl'
        /// </summary>
        [Fact]
        public void BatchErrorsUrlTest()
        {
            // TODO unit test for the property 'BatchErrorsUrl'
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
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
    }

}
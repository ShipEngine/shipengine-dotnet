/*
 * ShipEngine API
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
    ///  Class for testing ConnectCarrierRequestBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConnectCarrierRequestBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConnectCarrierRequestBody
        //private ConnectCarrierRequestBody instance;

        public ConnectCarrierRequestBodyTests()
        {
            // TODO uncomment below to create an instance of ConnectCarrierRequestBody
            //instance = new ConnectCarrierRequestBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConnectCarrierRequestBody
        /// </summary>
        [Fact]
        public void ConnectCarrierRequestBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConnectCarrierRequestBody
            //Assert.IsType<ConnectCarrierRequestBody>(instance);
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectAccessWorldwideRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectAccessWorldwideRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectAccessWorldwideRequestBody());
            Assert.IsType<ConnectAccessWorldwideRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectAccessWorldwideRequestBody>(testModel.GetConnectAccessWorldwideRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectAmazonBuyShippingRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectAmazonBuyShippingRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectAmazonBuyShippingRequestBody());
            Assert.IsType<ConnectAmazonBuyShippingRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectAmazonBuyShippingRequestBody>(testModel.GetConnectAmazonBuyShippingRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectAmazonShippingUk" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectAmazonShippingUkTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectAmazonShippingUk());
            Assert.IsType<ConnectAmazonShippingUk>(testModel.ActualInstance);
            Assert.IsType<ConnectAmazonShippingUk>(testModel.GetConnectAmazonShippingUk());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectApcRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectApcRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectApcRequestBody());
            Assert.IsType<ConnectApcRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectApcRequestBody>(testModel.GetConnectApcRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectAsendiaRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectAsendiaRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectAsendiaRequestBody());
            Assert.IsType<ConnectAsendiaRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectAsendiaRequestBody>(testModel.GetConnectAsendiaRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectAustraliaPostRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectAustraliaPostRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectAustraliaPostRequestBody());
            Assert.IsType<ConnectAustraliaPostRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectAustraliaPostRequestBody>(testModel.GetConnectAustraliaPostRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectCanadaPostRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectCanadaPostRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectCanadaPostRequestBody());
            Assert.IsType<ConnectCanadaPostRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectCanadaPostRequestBody>(testModel.GetConnectCanadaPostRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDhlEcommerceRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDhlEcommerceRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDhlEcommerceRequestBody());
            Assert.IsType<ConnectDhlEcommerceRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDhlEcommerceRequestBody>(testModel.GetConnectDhlEcommerceRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDhlExpressRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDhlExpressRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDhlExpressRequestBody());
            Assert.IsType<ConnectDhlExpressRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDhlExpressRequestBody>(testModel.GetConnectDhlExpressRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDhlExpressAuRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDhlExpressAuRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDhlExpressAuRequestBody());
            Assert.IsType<ConnectDhlExpressAuRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDhlExpressAuRequestBody>(testModel.GetConnectDhlExpressAuRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDhlExpressCaRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDhlExpressCaRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDhlExpressCaRequestBody());
            Assert.IsType<ConnectDhlExpressCaRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDhlExpressCaRequestBody>(testModel.GetConnectDhlExpressCaRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDhlExpressUkRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDhlExpressUkRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDhlExpressUkRequestBody());
            Assert.IsType<ConnectDhlExpressUkRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDhlExpressUkRequestBody>(testModel.GetConnectDhlExpressUkRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectDpdRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectDpdRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectDpdRequestBody());
            Assert.IsType<ConnectDpdRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectDpdRequestBody>(testModel.GetConnectDpdRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectEndiciaRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectEndiciaRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectEndiciaRequestBody());
            Assert.IsType<ConnectEndiciaRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectEndiciaRequestBody>(testModel.GetConnectEndiciaRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectFedexRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectFedexRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectFedexRequestBody());
            Assert.IsType<ConnectFedexRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectFedexRequestBody>(testModel.GetConnectFedexRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectFedexUkRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectFedexUkRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectFedexUkRequestBody());
            Assert.IsType<ConnectFedexUkRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectFedexUkRequestBody>(testModel.GetConnectFedexUkRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectFirstmileRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectFirstmileRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectFirstmileRequestBody());
            Assert.IsType<ConnectFirstmileRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectFirstmileRequestBody>(testModel.GetConnectFirstmileRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectImexRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectImexRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectImexRequestBody());
            Assert.IsType<ConnectImexRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectImexRequestBody>(testModel.GetConnectImexRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectLasershipRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectLasershipRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectLasershipRequestBody());
            Assert.IsType<ConnectLasershipRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectLasershipRequestBody>(testModel.GetConnectLasershipRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectNewgisticsRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectNewgisticsRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectNewgisticsRequestBody());
            Assert.IsType<ConnectNewgisticsRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectNewgisticsRequestBody>(testModel.GetConnectNewgisticsRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectOntracRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectOntracRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectOntracRequestBody());
            Assert.IsType<ConnectOntracRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectOntracRequestBody>(testModel.GetConnectOntracRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectPurolatorRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectPurolatorRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectPurolatorRequestBody());
            Assert.IsType<ConnectPurolatorRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectPurolatorRequestBody>(testModel.GetConnectPurolatorRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectRoyalMailRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectRoyalMailRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectRoyalMailRequestBody());
            Assert.IsType<ConnectRoyalMailRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectRoyalMailRequestBody>(testModel.GetConnectRoyalMailRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectRrDonnelleyRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectRrDonnelleyRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectRrDonnelleyRequestBody());
            Assert.IsType<ConnectRrDonnelleyRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectRrDonnelleyRequestBody>(testModel.GetConnectRrDonnelleyRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectSekoRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectSekoRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectSekoRequestBody());
            Assert.IsType<ConnectSekoRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectSekoRequestBody>(testModel.GetConnectSekoRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectSendleRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectSendleRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectSendleRequestBody());
            Assert.IsType<ConnectSendleRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectSendleRequestBody>(testModel.GetConnectSendleRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectStampsRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectStampsRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectStampsRequestBody());
            Assert.IsType<ConnectStampsRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectStampsRequestBody>(testModel.GetConnectStampsRequestBody());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCarrierRequestBody" /> class
        /// with the <see cref="ConnectUpsRequestBody" /> class
        /// </summary>
        [Fact]
        public void ActualInstanceIsConnectUpsRequestBodyTest()
        {
            var testModel = new ConnectCarrierRequestBody(new ConnectUpsRequestBody());
            Assert.IsType<ConnectUpsRequestBody>(testModel.ActualInstance);
            Assert.IsType<ConnectUpsRequestBody>(testModel.GetConnectUpsRequestBody());
        }
    }

}
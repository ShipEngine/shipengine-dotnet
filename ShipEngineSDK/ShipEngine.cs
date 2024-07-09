using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Result = ShipEngineSDK.ValidateAddresses.Result;
using ShipEngineSDK.Common;
using ShipEngineSDK.Manifests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("ShipEngineSDK.Test")]

namespace ShipEngineSDK
{
    /// <summary>
    /// Interface for ShipEngine
    /// </summary>
    public partial interface IShipEngine
    {
        /// <summary>
        /// Validates an address in nearly any country in the world.
        /// </summary>
        /// <param name="addresses">The address to validate. This can even be an incomplete or improperly formatted address</param>
        /// <returns>An address validation result object</returns>
        [Obsolete("Use ValidateAddress(List<AddressToValidate> addressToValidate) instead")]
        Task<List<ValidateAddresses.Result>> ValidateAddresses(List<Address> addresses);

        /// <summary>
        /// Validates an address in nearly any country in the world.
        /// </summary>
        /// <param name="addresses">The address to validate. This can even be an incomplete or improperly formatted address</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>An address validation result object</returns>
        [Obsolete("Use ValidateAddress(List<AddressToValidate> addressToValidate, methodConfig) instead")]
        Task<List<ValidateAddresses.Result>> ValidateAddresses(List<Address> addresses, Config methodConfig);

        /// <summary>
        /// Retrieve a list of all carriers that have been added to this account
        /// </summary>
        /// <returns>A list of carriers</returns>
        [Obsolete]
        Task<ListCarriers.Result> ListCarriers();

        /// <summary>
        /// Retrieve a list of all carriers that have been added to this account
        /// </summary>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call.</param>
        /// <returns>A list of carriers</returns>
        [Obsolete]
        Task<ListCarriers.Result> ListCarriers(Config methodConfig);

        /// <summary>
        /// Create a manifest
        /// </summary>
        /// <param name="manifestParams">The details of the manifest you want to create.</param>
        /// <returns></returns>
        [Obsolete]
        Task<Manifests.Result> CreateManifest(Manifests.Params manifestParams);

        /// <summary>
        /// Create a manifest
        /// </summary>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call.</param>
        /// <param name="manifestParams">The details of the manifest you want to create.</param>
        /// <returns></returns>
        [Obsolete]
        Task<Manifests.Result> CreateManifest(Config methodConfig, Manifests.Params manifestParams);

        /// <summary>
        /// Void a label by ID to get a refund.
        /// </summary>
        /// <param name="labelId">The id of the label to void</param>
        /// <returns>Result object indicating the success of the void label attempt</returns>
        [Obsolete]
        Task<VoidLabelWithLabelId.Result> VoidLabelWithLabelId(string labelId);

        /// <summary>
        /// Void a label by ID to get a refund.
        /// </summary>
        /// <param name="labelId">The id of the label to void</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Result object indicating the success of the void label attempt</returns>
        [Obsolete]
        Task<VoidLabelWithLabelId.Result> VoidLabelWithLabelId(string labelId, Config methodConfig);

        /// <summary>
        /// Track a shipment using the label id
        /// </summary>
        /// <param name="labelId">The label id associated with the shipment</param>
        /// <returns>An object that contains the label id tracking information</returns>
        [Obsolete]
        Task<TrackUsingLabelId.Result> TrackUsingLabelId(string labelId);

        /// <summary>
        /// Track a shipment using the label id
        /// </summary>
        /// <param name="labelId">The label id associated with the shipment</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>An object that contains the label id tracking information</returns>
        [Obsolete]
        Task<TrackUsingLabelId.Result> TrackUsingLabelId(string labelId, Config methodConfig);

        /// <summary>
        /// Tracks a package based on the trackingNumber and carrierCode.
        /// </summary>
        /// <param name="trackingNumber">The tracking number of the package you wish to track.</param>
        /// <param name="carrierCode">The carrierCode for the trackingNumber you are using to track the package.</param>
        /// <returns></returns>
        [Obsolete]
        Task<TrackUsingCarrierCodeAndTrackingNumber.Result> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode);

        /// <summary>
        /// Tracks a package based on the trackingNumber and carrierCode.
        /// </summary>
        /// <param name="trackingNumber">The tracking number of the package you wish to track.</param>
        /// <param name="carrierCode">The carrierCode for the trackingNumber you are using to track the package.</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns></returns>
        [Obsolete]
        Task<TrackUsingCarrierCodeAndTrackingNumber.Result> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode, Config methodConfig);

        /// <summary>
        /// Create a label from shipment details
        /// </summary>
        /// <param name="labelParams">Details of the label that you want to create</param>
        /// <returns>Object containing the created label information</returns>
        [Obsolete]
        Task<CreateLabelFromShipmentDetails.Result> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params labelParams);

        /// <summary>
        /// Create a label from shipment details
        /// </summary>
        /// <param name="labelParams">Details of the label that you want to create</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Object containing the created label information</returns>
        [Obsolete]
        Task<CreateLabelFromShipmentDetails.Result> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params labelParams, Config methodConfig);

        /// <summary>
        /// Create a label from a rate id
        /// </summary>
        /// <param name="createLabelFromRateParams">The details of the rate that you want to use to purchase a label</param>
        /// <returns>Object containing the created label information</returns>
        [Obsolete]
        Task<CreateLabelFromRate.Result> CreateLabelFromRate(CreateLabelFromRate.Params createLabelFromRateParams);

        /// <summary>
        /// Create a label from a rate id
        /// </summary>
        /// <param name="createLabelFromRateParams">The details of the rate that you want to use to purchase a label</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Object containing the created label information</returns>
        [Obsolete]
        Task<CreateLabelFromRate.Result> CreateLabelFromRate(CreateLabelFromRate.Params createLabelFromRateParams, Config methodConfig);

        /// <summary>
        /// Retrieve rates for a package with the provided shipment details.
        /// </summary>
        /// <param name="rateParams"></param>
        /// <returns>The rates result</returns>
        [Obsolete]
        Task<GetRatesWithShipmentDetails.Result> GetRatesWithShipmentDetails(GetRatesWithShipmentDetails.Params rateParams);

        /// <summary>
        /// Retrieve rates for a package with the provided shipment details.
        /// </summary>
        /// <param name="rateParams"></param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>The rates result</returns>
        [Obsolete]
        Task<GetRatesWithShipmentDetails.Result> GetRatesWithShipmentDetails(GetRatesWithShipmentDetails.Params rateParams, Config methodConfig);
    }


    /// <summary>
    /// Extension method to allow customized client configuration
    /// </summary>
    public static class ShipEngineExtensions
    {
        /// <summary>
        /// Adds ShipEngine to the host builder and configures the client.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configureClient"></param>
        /// <returns></returns>
        public static IHostApplicationBuilder AddShipEngine(this IHostApplicationBuilder builder, Action<HttpClient>? configureClient = null)
        {
            builder.Services.AddHttpClient<ShipEngine>(c =>
            {
                var baseUri = builder.Configuration["ShipEngine:BaseUrl"] ?? "https://api.shipengine.com";
                var apiKey = builder.Configuration["ShipEngine:ApiKey"] ?? "";
                ShipEngineClient.ConfigureHttpClient(c, apiKey, new Uri(baseUri));
                configureClient?.Invoke(c);
            });

            return builder;
        }
    }

    /// <summary>
    /// Contains methods for interacting with the ShipEngine API.
    /// </summary>
    public partial class ShipEngine : ShipEngineClient, IDisposable, IShipEngine
    {
        /// <summary>
        /// Global HttpClient for ShipEngine instance.
        /// </summary>
        public HttpClient _client;

        /// <summary>
        /// Global config for ShipEngine instance.
        /// </summary>
        public Config _config;

        /// <summary>
        /// Initialize the ShipEngine SDK with an API Key
        /// </summary>
        /// <param name="apiKey">Api Key associated with the ShipEngine account you want to use</param>
        public ShipEngine(string apiKey) : base()
        {
            _config = new Config(apiKey);
            _client = ConfigureHttpClient(_config, new HttpClient());
        }

        /// <summary>
        /// Initialize the ShipEngine SDK with a config object
        /// </summary>
        /// <param name="config">Config object containing custom configurations</param>
        public ShipEngine(Config config) : base()
        {
            this._config = config;
            _client = ConfigureHttpClient(config, new HttpClient());
        }

        /// <summary>
        /// Initialize the ShipEngine SDK with an httpClient object
        /// </summary>
        /// <param name="httpClient">HttpClient object to be used for ShipEngine API calls. We expect the httpClient has already been configured with ConfigureHttpClient</param>
        public ShipEngine(HttpClient httpClient) : base()
        {
            _client = httpClient;
        }

        /// <summary>
        /// Dispose of the ShipEngine client
        /// </summary>
        public void Dispose()
        {
            _client.Dispose();
        }

        /// <summary>
        /// Validates an address in nearly any country in the world.
        /// </summary>
        /// <param name="addresses">The address to validate. This can even be an incomplete or improperly formatted address</param>
        /// <returns>An address validation result object</returns>

        [Obsolete]
        public async Task<List<ValidateAddresses.Result>> ValidateAddresses(List<Address> addresses)
        {

            string addressesJsonString = JsonSerializer.Serialize(addresses, JsonSerializerOptions);

            var path = "v1/addresses/validate";

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result>>(HttpMethod.Post, path, addressesJsonString, _client, _config);

            return validatedAddresses;
        }

        /// <summary>
        /// Validates an address in nearly any country in the world.
        /// </summary>
        /// <param name="addresses">The address to validate. This can even be an incomplete or improperly formatted address</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call.</param>
        /// <returns>An address validation result object</returns>

        [Obsolete]
        public async Task<List<ValidateAddresses.Result>> ValidateAddresses(List<Address> addresses, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string addressesJsonString = JsonSerializer.Serialize(addresses, JsonSerializerOptions);

            var path = "v1/addresses/validate";

            var validatedAddresses = await SendHttpRequestAsync<List<ValidateAddresses.Result>>(HttpMethod.Post, path, addressesJsonString, client, methodConfig);

            client.Dispose();

            return validatedAddresses;
        }

        /// <summary>
        /// Retrieve a list of all carriers that have been added to this account
        /// </summary>
        /// <returns>A list of carriers</returns>

        [Obsolete]
        public async Task<ListCarriers.Result> ListCarriers()
        {
            var path = "v1/carriers";

            var carriers = await SendHttpRequestAsync<ListCarriers.Result>(HttpMethod.Get, path, null, _client, _config);

            return carriers;
        }

        /// <summary>
        /// Retrieve a list of all carriers that have been added to this account
        /// </summary>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call.</param>
        /// <returns>A list of carriers</returns>

        [Obsolete]
        public async Task<ListCarriers.Result> ListCarriers(Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = "v1/carriers";

            var carriers = await SendHttpRequestAsync<ListCarriers.Result>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return carriers;
        }


        /// <summary>
        /// Create a manifest
        /// </summary>
        /// <param name="manifestParams">The details of the manifest you want to create.</param>
        /// <returns></returns>

        [Obsolete]
        public async Task<Manifests.Result> CreateManifest(Manifests.Params manifestParams)
        {
            var path = "v1/manifests";

            string paramString = JsonSerializer.Serialize(manifestParams, JsonSerializerOptions);

            var manifest = await SendHttpRequestAsync<Manifests.Result>(HttpMethod.Post, path, paramString, _client, _config);

            return manifest;
        }

        /// <summary>
        /// Create a manifest
        /// </summary>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call.</param>
        /// <param name="manifestParams">The details of the manifest you want to create.</param>
        /// <returns></returns>

        [Obsolete]
        public async Task<Manifests.Result> CreateManifest(Config methodConfig, Manifests.Params manifestParams)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = "v1/manifests";

            string paramString = JsonSerializer.Serialize(manifestParams, JsonSerializerOptions);

            var manifest = await SendHttpRequestAsync<Manifests.Result>(HttpMethod.Post, path, paramString, client, _config);

            return manifest;
        }

        /// <summary>
        /// Void a label by ID to get a refund.
        /// </summary>
        /// <param name="labelId">The id of the label to void</param>
        /// <returns>Result object indicating the success of the void label attempt</returns>

        [Obsolete]
        public async Task<VoidLabelWithLabelId.Result> VoidLabelWithLabelId(string labelId)
        {
            var path = $"v1/labels/{labelId}/void";

            var voidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result>(HttpMethod.Put, path, null, _client, _config);

            return voidedLabelResponse;
        }

        /// <summary>
        /// Void a label by ID to get a refund.
        /// </summary>
        /// <param name="labelId">The id of the label to void</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Result object indicating the success of the void label attempt</returns>

        [Obsolete]
        public async Task<VoidLabelWithLabelId.Result> VoidLabelWithLabelId(string labelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"v1/labels/{labelId}/void";

            var voidedLabelResponse = await SendHttpRequestAsync<VoidLabelWithLabelId.Result>(HttpMethod.Put, path, null, client, methodConfig);

            client.Dispose();

            return voidedLabelResponse;
        }

        /// <summary>
        /// Track a shipment using the label id
        /// </summary>
        /// <param name="labelId">The label id associated with the shipment</param>
        /// <returns>An object that contains the label id tracking information</returns>

        [Obsolete]
        public async Task<TrackUsingLabelId.Result> TrackUsingLabelId(string labelId)
        {
            var path = $"/v1/labels/{labelId}/track";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result>(HttpMethod.Get, path, null, _client, _config);

            return trackingInfo;
        }

        /// <summary>
        /// Track a shipment using the label id
        /// </summary>
        /// <param name="labelId">The label id associated with the shipment</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>An object that contains the label id tracking information</returns>

        [Obsolete]
        public async Task<TrackUsingLabelId.Result> TrackUsingLabelId(string labelId, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/labels/{labelId}/track";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingLabelId.Result>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return trackingInfo;
        }

        /// <summary>
        /// Tracks a package based on the trackingNumber and carrierCode.
        /// </summary>
        /// <param name="trackingNumber">The tracking number of the package you wish to track.</param>
        /// <param name="carrierCode">The carrierCode for the trackingNumber you are using to track the package.</param>
        /// <returns></returns>

        [Obsolete]
        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode)
        {
            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result>(HttpMethod.Get, path, null, _client, _config);

            return trackingInfo;
        }

        /// <summary>
        /// Tracks a package based on the trackingNumber and carrierCode.
        /// </summary>
        /// <param name="trackingNumber">The tracking number of the package you wish to track.</param>
        /// <param name="carrierCode">The carrierCode for the trackingNumber you are using to track the package.</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns></returns>

        [Obsolete]
        public async Task<TrackUsingCarrierCodeAndTrackingNumber.Result> TrackUsingCarrierCodeAndTrackingNumber(string trackingNumber, string carrierCode, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/tracking?tracking_number={trackingNumber}&carrier_code={carrierCode}";

            var trackingInfo = await SendHttpRequestAsync<TrackUsingCarrierCodeAndTrackingNumber.Result>(HttpMethod.Get, path, null, client, methodConfig);

            client.Dispose();

            return trackingInfo;
        }

        /// <summary>
        /// Create a label from shipment details
        /// </summary>
        /// <param name="labelParams">Details of the label that you want to create</param>
        /// <returns>Object containing the created label information</returns>

        [Obsolete]
        public async Task<CreateLabelFromShipmentDetails.Result> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params labelParams)
        {

            string labelParamsString = JsonSerializer.Serialize(labelParams, JsonSerializerOptions);

            var path = "/v1/labels";

            var labelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result>(HttpMethod.Post, path, labelParamsString, _client, _config);

            return labelResult;
        }

        /// <summary>
        /// Create a label from shipment details
        /// </summary>
        /// <param name="labelParams">Details of the label that you want to create</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Object containing the created label information</returns>

        [Obsolete]
        public async Task<CreateLabelFromShipmentDetails.Result> CreateLabelFromShipmentDetails(CreateLabelFromShipmentDetails.Params labelParams, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            string labelParamsString = JsonSerializer.Serialize(labelParams, JsonSerializerOptions);

            var path = "/v1/labels";

            var labelResult = await SendHttpRequestAsync<CreateLabelFromShipmentDetails.Result>(HttpMethod.Post, path, labelParamsString, client, methodConfig);

            client.Dispose();

            return labelResult;
        }

        /// <summary>
        /// Create a label from a rate id
        /// </summary>
        /// <param name="createLabelFromRateParams">The details of the rate that you want to use to purchase a label</param>
        /// <returns>Object containing the created label information</returns>

        [Obsolete]
        public async Task<CreateLabelFromRate.Result> CreateLabelFromRate(CreateLabelFromRate.Params createLabelFromRateParams)
        {
            var path = $"/v1/labels/rates/{createLabelFromRateParams.RateId}";

            string createLabelFromRateParamsString = JsonSerializer.Serialize(createLabelFromRateParams, JsonSerializerOptions);

            var labelResult = await SendHttpRequestAsync<CreateLabelFromRate.Result>(HttpMethod.Post, path, createLabelFromRateParamsString, _client, _config);

            return labelResult;
        }

        /// <summary>
        /// Create a label from a rate id
        /// </summary>
        /// <param name="createLabelFromRateParams">The details of the rate that you want to use to purchase a label</param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>Object containing the created label information</returns>

        [Obsolete]
        public async Task<CreateLabelFromRate.Result> CreateLabelFromRate(CreateLabelFromRate.Params createLabelFromRateParams, Config methodConfig)
        {

            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = $"/v1/labels/rates/{createLabelFromRateParams.RateId}";

            string createLabelFromRateParamsString = JsonSerializer.Serialize(createLabelFromRateParams, JsonSerializerOptions);

            var labelResult = await SendHttpRequestAsync<CreateLabelFromRate.Result>(HttpMethod.Post, path, createLabelFromRateParamsString, client, methodConfig);

            client.Dispose();

            return labelResult;
        }

        /// <summary>
        /// Retrieve rates for a package with the provided shipment details.
        /// </summary>
        /// <param name="rateParams"></param>
        /// <returns>The rates result</returns>

        [Obsolete]
        public async Task<GetRatesWithShipmentDetails.Result> GetRatesWithShipmentDetails(GetRatesWithShipmentDetails.Params rateParams)
        {
            var path = "/v1/rates";

            string paramString = JsonSerializer.Serialize(rateParams, JsonSerializerOptions);

            var labelResult = await SendHttpRequestAsync<GetRatesWithShipmentDetails.Result>(HttpMethod.Post, path, paramString, _client, _config);

            return labelResult;
        }

        /// <summary>
        /// Retrieve rates for a package with the provided shipment details.
        /// </summary>
        /// <param name="rateParams"></param>
        /// <param name="methodConfig">Configuration object that overrides the global config for this method call</param>
        /// <returns>The rates result</returns>

        [Obsolete]
        public async Task<GetRatesWithShipmentDetails.Result> GetRatesWithShipmentDetails(GetRatesWithShipmentDetails.Params rateParams, Config methodConfig)
        {
            var client = ConfigureHttpClient(methodConfig, new HttpClient());

            var path = "/v1/rates";

            string paramString = JsonSerializer.Serialize(rateParams, JsonSerializerOptions);

            var labelResult = await SendHttpRequestAsync<GetRatesWithShipmentDetails.Result>(HttpMethod.Post, path, paramString, client, methodConfig);

            client.Dispose();

            return labelResult;
        }
    }
}
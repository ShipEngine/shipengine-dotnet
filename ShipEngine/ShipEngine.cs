using ShipEngineSDK.Common;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    /// <summary>
    /// Contains methods for interacting with the ShipEngine API.
    /// </summary>
    public class ShipEngine : ShipEngineClient
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
            var client = new HttpClient();
            _config = new Config(apiKey);
            _client = ConfigureHttpClient(_config, client);
        }

        /// <summary>
        /// Initialize the ShipEngine SDK with a config object
        /// </summary>
        /// <param name="config">Config object containing custom configurations</param>
        public ShipEngine(Config config) : base()
        {
            var client = new HttpClient();
            this._config = config;
            _client = ConfigureHttpClient(config, client);
        }

        /// <summary>
        /// Validates an address in nearly any country in the world.
        /// </summary>
        /// <param name="addresses">The address to validate. This can even be an incomplete or improperly formatted address</param>
        /// <returns>An address validation result object</returns>
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
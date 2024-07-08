/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ShipEngineSDK.Model;

namespace ShipEngineSDK;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial interface IShipEngine
{
    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(Config methodConfig, string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(HttpClient methodClient, Config methodConfig, string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrierById(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrierById(Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrierById(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    Task<GetCarrierByIdResponseBody> GetCarrierById(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    Task<GetCarrierByIdResponseBody> GetCarrierById(Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    Task<GetCarrierByIdResponseBody> GetCarrierById(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    Task<GetCarrierOptionsResponseBody> GetCarrierOptions(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    Task<GetCarrierOptionsResponseBody> GetCarrierOptions(Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    Task<GetCarrierOptionsResponseBody> GetCarrierOptions(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    Task<ListCarrierServicesResponseBody> ListCarrierServices(string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    Task<ListCarrierServicesResponseBody> ListCarrierServices(Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    Task<ListCarrierServicesResponseBody> ListCarrierServices(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    Task<GetCarriersResponseBody> ListCarriers(CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    Task<GetCarriersResponseBody> ListCarriers(Config methodConfig, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    Task<GetCarriersResponseBody> ListCarriers(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    public Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        return AddFundsToCarrier(_client, _config, carrierId, addFundsToCarrierRequestBody, cancellationToken);
    }

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    public async Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(Config methodConfig, string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await AddFundsToCarrier(methodClient, methodConfig, carrierId, addFundsToCarrierRequestBody, cancellationToken);
    }

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    public async Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(HttpClient methodClient, Config methodConfig, string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }

        // verify the required parameter 'addFundsToCarrierRequestBody' is set
        if (addFundsToCarrierRequestBody == null)
        {
            throw new ArgumentNullException(nameof(addFundsToCarrierRequestBody));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/add_funds");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(addFundsToCarrierRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "CarriersApi.AddFundsToCarrier";

        var result = await SendHttpRequestAsync<AddFundsToCarrierResponseBody>(HttpMethods.Put, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> DisconnectCarrierById(string carrierId, CancellationToken cancellationToken = default)
    {
        return DisconnectCarrierById(_client, _config, carrierId, cancellationToken);
    }

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DisconnectCarrierById(Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await DisconnectCarrierById(methodClient, methodConfig, carrierId, cancellationToken);
    }

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DisconnectCarrierById(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.DisconnectCarrierById";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    public Task<GetCarrierByIdResponseBody> GetCarrierById(string carrierId, CancellationToken cancellationToken = default)
    {
        return GetCarrierById(_client, _config, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    public async Task<GetCarrierByIdResponseBody> GetCarrierById(Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await GetCarrierById(methodClient, methodConfig, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    public async Task<GetCarrierByIdResponseBody> GetCarrierById(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.GetCarrierById";

        var result = await SendHttpRequestAsync<GetCarrierByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    public Task<GetCarrierOptionsResponseBody> GetCarrierOptions(string carrierId, CancellationToken cancellationToken = default)
    {
        return GetCarrierOptions(_client, _config, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    public async Task<GetCarrierOptionsResponseBody> GetCarrierOptions(Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await GetCarrierOptions(methodClient, methodConfig, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    public async Task<GetCarrierOptionsResponseBody> GetCarrierOptions(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/options");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.GetCarrierOptions";

        var result = await SendHttpRequestAsync<GetCarrierOptionsResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    public Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(string carrierId, CancellationToken cancellationToken = default)
    {
        return ListCarrierPackageTypes(_client, _config, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    public async Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ListCarrierPackageTypes(methodClient, methodConfig, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    public async Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/packages");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.ListCarrierPackageTypes";

        var result = await SendHttpRequestAsync<ListCarrierPackageTypesResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    public Task<ListCarrierServicesResponseBody> ListCarrierServices(string carrierId, CancellationToken cancellationToken = default)
    {
        return ListCarrierServices(_client, _config, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    public async Task<ListCarrierServicesResponseBody> ListCarrierServices(Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ListCarrierServices(methodClient, methodConfig, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    public async Task<ListCarrierServicesResponseBody> ListCarrierServices(HttpClient methodClient, Config methodConfig, string carrierId, CancellationToken cancellationToken = default)
    {
        
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/services");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.ListCarrierServices";

        var result = await SendHttpRequestAsync<ListCarrierServicesResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    public Task<GetCarriersResponseBody> ListCarriers(CancellationToken cancellationToken = default)
    {
        return ListCarriers(_client, _config, cancellationToken);
    }

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    public async Task<GetCarriersResponseBody> ListCarriers(Config methodConfig, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ListCarriers(methodClient, methodConfig, cancellationToken);
    }

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    public async Task<GetCarriersResponseBody> ListCarriers(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default)
    {
        

        RequestOptions requestOptions = new("/v1/carriers");


        requestOptions.Operation = "CarriersApi.ListCarriers";

        var result = await SendHttpRequestAsync<GetCarriersResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}

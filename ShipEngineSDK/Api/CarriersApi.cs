/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using ShipEngineSDK.Model;
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
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(HttpClient methodClient, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrierById(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    Task<GetCarrierByIdResponseBody> GetCarrierById(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    Task<GetCarrierOptionsResponseBody> GetCarrierOptions(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    Task<ListCarrierServicesResponseBody> ListCarrierServices(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default);

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
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    Task<GetCarriersResponseBody> ListCarriers(HttpClient methodClient, CancellationToken cancellationToken = default);

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
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    public Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default)
    {
        return AddFundsToCarrier(_client, addFundsToCarrierRequestBody, carrierId, cancellationToken);
    }

    /// <summary>
    /// Add Funds To Carrier Add Funds To A Carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="addFundsToCarrierRequestBody"></param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AddFundsToCarrierResponseBody)</returns>
    public async Task<AddFundsToCarrierResponseBody> AddFundsToCarrier(HttpClient methodClient, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'addFundsToCarrierRequestBody' is set
        if (addFundsToCarrierRequestBody == null)
        {
            throw new ArgumentNullException(nameof(addFundsToCarrierRequestBody));
        }

        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/add_funds");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(addFundsToCarrierRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "CarriersApi.AddFundsToCarrier";

        var result = await SendHttpRequestAsync<AddFundsToCarrierResponseBody>(HttpMethods.Put, requestOptions, methodClient, _config, cancellationToken);

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
        return DisconnectCarrierById(_client, carrierId, cancellationToken);
    }

    /// <summary>
    /// Disconnect Carrier by ID Disconnect a Carrier of the given ID from the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DisconnectCarrierById(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.DisconnectCarrierById";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, _config, cancellationToken);

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
        return GetCarrierById(_client, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier By ID Retrive carrier info by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierByIdResponseBody)</returns>
    public async Task<GetCarrierByIdResponseBody> GetCarrierById(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.GetCarrierById";

        var result = await SendHttpRequestAsync<GetCarrierByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

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
        return GetCarrierOptions(_client, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get Carrier Options Get a list of the options available for the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierOptionsResponseBody)</returns>
    public async Task<GetCarrierOptionsResponseBody> GetCarrierOptions(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/options");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.GetCarrierOptions";

        var result = await SendHttpRequestAsync<GetCarrierOptionsResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

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
        return ListCarrierPackageTypes(_client, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Package Types List the package types associated with the carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierPackageTypesResponseBody)</returns>
    public async Task<ListCarrierPackageTypesResponseBody> ListCarrierPackageTypes(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/packages");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.ListCarrierPackageTypes";

        var result = await SendHttpRequestAsync<ListCarrierPackageTypesResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

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
        return ListCarrierServices(_client, carrierId, cancellationToken);
    }

    /// <summary>
    /// List Carrier Services List the services associated with the carrier ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListCarrierServicesResponseBody)</returns>
    public async Task<ListCarrierServicesResponseBody> ListCarrierServices(HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/carriers/{carrier_id}/services");

        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarriersApi.ListCarrierServices";

        var result = await SendHttpRequestAsync<ListCarrierServicesResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

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
        return ListCarriers(_client, cancellationToken);
    }

    /// <summary>
    /// List Carriers List all carriers that have been added to this account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarriersResponseBody)</returns>
    public async Task<GetCarriersResponseBody> ListCarriers(HttpClient methodClient, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/carriers");


        requestOptions.Operation = "CarriersApi.ListCarriers";

        var result = await SendHttpRequestAsync<GetCarriersResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}
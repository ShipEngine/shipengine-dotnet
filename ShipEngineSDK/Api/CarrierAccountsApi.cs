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
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    Task<ConnectCarrierResponseBody> ConnectCarrier(CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    Task<ConnectCarrierResponseBody> ConnectCarrier(Config methodConfig, CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    Task<ConnectCarrierResponseBody> ConnectCarrier(HttpClient methodClient, Config methodConfig, CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrier(CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrier(Config methodConfig, CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DisconnectCarrier(HttpClient methodClient, Config methodConfig, CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    Task<GetCarrierSettingsResponseBody> GetCarrierSettings(CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    Task<GetCarrierSettingsResponseBody> GetCarrierSettings(Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    Task<GetCarrierSettingsResponseBody> GetCarrierSettings(HttpClient methodClient, Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateCarrierSettings(CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateCarrierSettings(Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateCarrierSettings(HttpClient methodClient, Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    public Task<ConnectCarrierResponseBody> ConnectCarrier(CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        return ConnectCarrier(_client, _config, carrierName, connectCarrierRequestBody, cancellationToken);
    }

    /// <summary>
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    public async Task<ConnectCarrierResponseBody> ConnectCarrier(Config methodConfig, CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ConnectCarrier(methodClient, methodConfig, carrierName, connectCarrierRequestBody, cancellationToken);
    }

    /// <summary>
    /// Connect a carrier account Connect a carrier account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="connectCarrierRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConnectCarrierResponseBody)</returns>
    public async Task<ConnectCarrierResponseBody> ConnectCarrier(HttpClient methodClient, Config methodConfig, CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'connectCarrierRequestBody' is set
        if (connectCarrierRequestBody == null)
        {
            throw new ArgumentNullException(nameof(connectCarrierRequestBody));
        }


        RequestOptions requestOptions = new("/v1/connections/carriers/{carrier_name}");

        requestOptions.PathParameters.Add("carrier_name", ShipEngineSDK.ClientUtils.ParameterToString(carrierName)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(connectCarrierRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "CarrierAccountsApi.ConnectCarrier";

        var result = await SendHttpRequestAsync<ConnectCarrierResponseBody>(HttpMethods.Post, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> DisconnectCarrier(CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        return DisconnectCarrier(_client, _config, carrierName, carrierId, cancellationToken);
    }

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DisconnectCarrier(Config methodConfig, CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await DisconnectCarrier(methodClient, methodConfig, carrierName, carrierId, cancellationToken);
    }

    /// <summary>
    /// Disconnect a carrier Disconnect a carrier
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DisconnectCarrier(HttpClient methodClient, Config methodConfig, CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/connections/carriers/{carrier_name}/{carrier_id}");

        requestOptions.PathParameters.Add("carrier_name", ShipEngineSDK.ClientUtils.ParameterToString(carrierName)); // path parameter
        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarrierAccountsApi.DisconnectCarrier";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    public Task<GetCarrierSettingsResponseBody> GetCarrierSettings(CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        return GetCarrierSettings(_client, _config, carrierName, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    public async Task<GetCarrierSettingsResponseBody> GetCarrierSettings(Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await GetCarrierSettings(methodClient, methodConfig, carrierName, carrierId, cancellationToken);
    }

    /// <summary>
    /// Get carrier settings Get carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetCarrierSettingsResponseBody)</returns>
    public async Task<GetCarrierSettingsResponseBody> GetCarrierSettings(HttpClient methodClient, Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }


        RequestOptions requestOptions = new("/v1/connections/carriers/{carrier_name}/{carrier_id}/settings");

        requestOptions.PathParameters.Add("carrier_name", ShipEngineSDK.ClientUtils.ParameterToString(carrierName)); // path parameter
        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter

        requestOptions.Operation = "CarrierAccountsApi.GetCarrierSettings";

        var result = await SendHttpRequestAsync<GetCarrierSettingsResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> UpdateCarrierSettings(CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default)
    {
        return UpdateCarrierSettings(_client, _config, carrierName, carrierId, updateCarrierSettingsRequestBody, cancellationToken);
    }

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateCarrierSettings(Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await UpdateCarrierSettings(methodClient, methodConfig, carrierName, carrierId, updateCarrierSettingsRequestBody, cancellationToken);
    }

    /// <summary>
    /// Update carrier settings Update carrier settings
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierName">The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;.</param>
    /// <param name="carrierId">Carrier ID</param>
    /// <param name="updateCarrierSettingsRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateCarrierSettings(HttpClient methodClient, Config methodConfig, CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierId' is set
        if (carrierId == null)
        {
            throw new ArgumentNullException(nameof(carrierId));
        }

        // verify the required parameter 'updateCarrierSettingsRequestBody' is set
        if (updateCarrierSettingsRequestBody == null)
        {
            throw new ArgumentNullException(nameof(updateCarrierSettingsRequestBody));
        }


        RequestOptions requestOptions = new("/v1/connections/carriers/{carrier_name}/{carrier_id}/settings");

        requestOptions.PathParameters.Add("carrier_name", ShipEngineSDK.ClientUtils.ParameterToString(carrierName)); // path parameter
        requestOptions.PathParameters.Add("carrier_id", ShipEngineSDK.ClientUtils.ParameterToString(carrierId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(updateCarrierSettingsRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "CarrierAccountsApi.UpdateCarrierSettings";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Put, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}
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
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    Task<GetServicePointByIdResponseBody> ServicePointsGetById(string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    Task<GetServicePointByIdResponseBody> ServicePointsGetById(Config methodConfig, string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    Task<GetServicePointByIdResponseBody> ServicePointsGetById(HttpClient methodClient, Config methodConfig, string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    Task<ListServicePointsResponseBody> ServicePointsList(GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    Task<ListServicePointsResponseBody> ServicePointsList(Config methodConfig, GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    Task<ListServicePointsResponseBody> ServicePointsList(HttpClient methodClient, Config methodConfig, GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    public Task<GetServicePointByIdResponseBody> ServicePointsGetById(string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default)
    {
        return ServicePointsGetById(_client, _config, carrierCode, countryCode, servicePointId, cancellationToken);
    }

    /// <summary>
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    public async Task<GetServicePointByIdResponseBody> ServicePointsGetById(Config methodConfig, string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ServicePointsGetById(methodClient, methodConfig, carrierCode, countryCode, servicePointId, cancellationToken);
    }

    /// <summary>
    /// Get Service Point By ID Returns a carrier service point by using the service_point_id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="carrierCode">Carrier code</param>
    /// <param name="countryCode">A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </param>
    /// <param name="servicePointId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetServicePointByIdResponseBody)</returns>
    public async Task<GetServicePointByIdResponseBody> ServicePointsGetById(HttpClient methodClient, Config methodConfig, string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'carrierCode' is set
        if (carrierCode == null)
        {
            throw new ArgumentNullException(nameof(carrierCode));
        }

        // verify the required parameter 'countryCode' is set
        if (countryCode == null)
        {
            throw new ArgumentNullException(nameof(countryCode));
        }

        // verify the required parameter 'servicePointId' is set
        if (servicePointId == null)
        {
            throw new ArgumentNullException(nameof(servicePointId));
        }


        RequestOptions requestOptions = new("/v1/service_points/{carrier_code}/{country_code}/{service_point_id}");

        requestOptions.PathParameters.Add("carrier_code", ShipEngineSDK.Client.ClientUtils.ParameterToString(carrierCode)); // path parameter
        requestOptions.PathParameters.Add("country_code", ShipEngineSDK.Client.ClientUtils.ParameterToString(countryCode)); // path parameter
        requestOptions.PathParameters.Add("service_point_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(servicePointId)); // path parameter

        requestOptions.Operation = "ServicePointsApi.ServicePointsGetById";

        var result = await SendHttpRequestAsync<GetServicePointByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    public Task<ListServicePointsResponseBody> ServicePointsList(GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default)
    {
        return ServicePointsList(_client, _config, getServicePointsRequest, cancellationToken);
    }

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    public async Task<ListServicePointsResponseBody> ServicePointsList(Config methodConfig, GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ServicePointsList(methodClient, methodConfig, getServicePointsRequest, cancellationToken);
    }

    /// <summary>
    /// List Service Points List carrier service points by location
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="getServicePointsRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListServicePointsResponseBody)</returns>
    public async Task<ListServicePointsResponseBody> ServicePointsList(HttpClient methodClient, Config methodConfig, GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'getServicePointsRequest' is set
        if (getServicePointsRequest == null)
        {
            throw new ArgumentNullException(nameof(getServicePointsRequest));
        }


        RequestOptions requestOptions = new("/v1/service_points/list");

        requestOptions.Data = JsonSerializer.Serialize(getServicePointsRequest, JsonSerializerOptions);

        requestOptions.Operation = "ServicePointsApi.ServicePointsList";

        var result = await SendHttpRequestAsync<ListServicePointsResponseBody>(HttpMethods.Post, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}
/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
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
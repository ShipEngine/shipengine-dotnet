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
    /// Create Manifest Each ShipEngine manifest is created for a specific warehouse, so you&#39;ll need to provide the warehouse_id rather than the ship_from address. You can create a warehouse for each location that you want to create manifests for. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createManifestRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    Task<CreateManifestResponseBody> CreateManifest(CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Manifest Each ShipEngine manifest is created for a specific warehouse, so you&#39;ll need to provide the warehouse_id rather than the ship_from address. You can create a warehouse for each location that you want to create manifests for. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createManifestRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    Task<CreateManifestResponseBody> CreateManifest(HttpClient methodClient, CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Manifest By Id Get Manifest By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="manifestId">The Manifest Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetManifestByIdResponseBody)</returns>
    Task<GetManifestByIdResponseBody> GetManifestById(string manifestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Manifest By Id Get Manifest By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="manifestId">The Manifest Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetManifestByIdResponseBody)</returns>
    Task<GetManifestByIdResponseBody> GetManifestById(HttpClient methodClient, string manifestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Manifest Request By Id Get Manifest Request By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="manifestRequestId">The Manifest Request Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    Task<CreateManifestResponseBody> GetManifestRequestById(string manifestRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Manifest Request By Id Get Manifest Request By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="manifestRequestId">The Manifest Request Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    Task<CreateManifestResponseBody> GetManifestRequestById(HttpClient methodClient, string manifestRequestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Manifests Similar to querying shipments, we allow you to query manifests since there will likely be a large number over a long period of time.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID (optional)</param>
    /// <param name="shipDateStart">ship date start range (optional)</param>
    /// <param name="shipDateEnd">ship date end range (optional)</param>
    /// <param name="createdAtStart">Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional)</param>
    /// <param name="createdAtEnd">Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional)</param>
    /// <param name="carrierId">Carrier ID (optional)</param>
    /// <param name="page">Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  (optional, default to 1)</param>
    /// <param name="pageSize">The number of results to return per response. (optional, default to 25)</param>
    /// <param name="labelIds"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListManifestsResponseBody)</returns>
    Task<ListManifestsResponseBody> ListManifests(string warehouseId, DateTime? shipDateStart, DateTime? shipDateEnd, DateTime? createdAtStart, DateTime? createdAtEnd, string carrierId, int? page, int? pageSize, List<string> labelIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Manifests Similar to querying shipments, we allow you to query manifests since there will likely be a large number over a long period of time.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID (optional)</param>
    /// <param name="shipDateStart">ship date start range (optional)</param>
    /// <param name="shipDateEnd">ship date end range (optional)</param>
    /// <param name="createdAtStart">Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional)</param>
    /// <param name="createdAtEnd">Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional)</param>
    /// <param name="carrierId">Carrier ID (optional)</param>
    /// <param name="page">Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  (optional, default to 1)</param>
    /// <param name="pageSize">The number of results to return per response. (optional, default to 25)</param>
    /// <param name="labelIds"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListManifestsResponseBody)</returns>
    Task<ListManifestsResponseBody> ListManifests(HttpClient methodClient, string warehouseId, DateTime? shipDateStart, DateTime? shipDateEnd, DateTime? createdAtStart, DateTime? createdAtEnd, string carrierId, int? page, int? pageSize, List<string> labelIds, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Create Manifest Each ShipEngine manifest is created for a specific warehouse, so you&#39;ll need to provide the warehouse_id rather than the ship_from address. You can create a warehouse for each location that you want to create manifests for. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createManifestRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    public Task<CreateManifestResponseBody> CreateManifest(CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default)
    {
        return CreateManifest(_client, createManifestRequestBody, cancellationToken);
    }

    /// <summary>
    /// Create Manifest Each ShipEngine manifest is created for a specific warehouse, so you&#39;ll need to provide the warehouse_id rather than the ship_from address. You can create a warehouse for each location that you want to create manifests for. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createManifestRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    public async Task<CreateManifestResponseBody> CreateManifest(HttpClient methodClient, CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'createManifestRequestBody' is set
        if (createManifestRequestBody == null)
        {
            throw new ArgumentNullException(nameof(createManifestRequestBody));
        }


        RequestOptions requestOptions = new("/v1/manifests");

        requestOptions.Data = JsonSerializer.Serialize(createManifestRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "ManifestsApi.CreateManifest";

        var result = await SendHttpRequestAsync<CreateManifestResponseBody>(HttpMethods.Post, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Manifest By Id Get Manifest By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="manifestId">The Manifest Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetManifestByIdResponseBody)</returns>
    public Task<GetManifestByIdResponseBody> GetManifestById(string manifestId, CancellationToken cancellationToken = default)
    {
        return GetManifestById(_client, manifestId, cancellationToken);
    }

    /// <summary>
    /// Get Manifest By Id Get Manifest By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="manifestId">The Manifest Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetManifestByIdResponseBody)</returns>
    public async Task<GetManifestByIdResponseBody> GetManifestById(HttpClient methodClient, string manifestId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'manifestId' is set
        if (manifestId == null)
        {
            throw new ArgumentNullException(nameof(manifestId));
        }


        RequestOptions requestOptions = new("/v1/manifests/{manifest_id}");

        requestOptions.PathParameters.Add("manifest_id", ShipEngineSDK.ClientUtils.ParameterToString(manifestId)); // path parameter

        requestOptions.Operation = "ManifestsApi.GetManifestById";

        var result = await SendHttpRequestAsync<GetManifestByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Manifest Request By Id Get Manifest Request By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="manifestRequestId">The Manifest Request Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    public Task<CreateManifestResponseBody> GetManifestRequestById(string manifestRequestId, CancellationToken cancellationToken = default)
    {
        return GetManifestRequestById(_client, manifestRequestId, cancellationToken);
    }

    /// <summary>
    /// Get Manifest Request By Id Get Manifest Request By Id
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="manifestRequestId">The Manifest Request Id</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateManifestResponseBody)</returns>
    public async Task<CreateManifestResponseBody> GetManifestRequestById(HttpClient methodClient, string manifestRequestId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'manifestRequestId' is set
        if (manifestRequestId == null)
        {
            throw new ArgumentNullException(nameof(manifestRequestId));
        }


        RequestOptions requestOptions = new("/v1/manifests/requests/{manifest_request_id}");

        requestOptions.PathParameters.Add("manifest_request_id", ShipEngineSDK.ClientUtils.ParameterToString(manifestRequestId)); // path parameter

        requestOptions.Operation = "ManifestsApi.GetManifestRequestById";

        var result = await SendHttpRequestAsync<CreateManifestResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Manifests Similar to querying shipments, we allow you to query manifests since there will likely be a large number over a long period of time.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID (optional)</param>
    /// <param name="shipDateStart">ship date start range (optional)</param>
    /// <param name="shipDateEnd">ship date end range (optional)</param>
    /// <param name="createdAtStart">Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional)</param>
    /// <param name="createdAtEnd">Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional)</param>
    /// <param name="carrierId">Carrier ID (optional)</param>
    /// <param name="page">Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  (optional, default to 1)</param>
    /// <param name="pageSize">The number of results to return per response. (optional, default to 25)</param>
    /// <param name="labelIds"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListManifestsResponseBody)</returns>
    public Task<ListManifestsResponseBody> ListManifests(string warehouseId = default, DateTime? shipDateStart = default, DateTime? shipDateEnd = default, DateTime? createdAtStart = default, DateTime? createdAtEnd = default, string carrierId = default, int? page = default, int? pageSize = default, List<string> labelIds = default, CancellationToken cancellationToken = default)
    {
        return ListManifests(_client, warehouseId, shipDateStart, shipDateEnd, createdAtStart, createdAtEnd, carrierId, page, pageSize, labelIds, cancellationToken);
    }

    /// <summary>
    /// List Manifests Similar to querying shipments, we allow you to query manifests since there will likely be a large number over a long period of time.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID (optional)</param>
    /// <param name="shipDateStart">ship date start range (optional)</param>
    /// <param name="shipDateEnd">ship date end range (optional)</param>
    /// <param name="createdAtStart">Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional)</param>
    /// <param name="createdAtEnd">Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional)</param>
    /// <param name="carrierId">Carrier ID (optional)</param>
    /// <param name="page">Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  (optional, default to 1)</param>
    /// <param name="pageSize">The number of results to return per response. (optional, default to 25)</param>
    /// <param name="labelIds"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListManifestsResponseBody)</returns>
    public async Task<ListManifestsResponseBody> ListManifests(HttpClient methodClient, string warehouseId = default, DateTime? shipDateStart = default, DateTime? shipDateEnd = default, DateTime? createdAtStart = default, DateTime? createdAtEnd = default, string carrierId = default, int? page = default, int? pageSize = default, List<string> labelIds = default, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/manifests");

        if (warehouseId != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "warehouse_id", warehouseId));
        }
        if (shipDateStart != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "ship_date_start", shipDateStart));
        }
        if (shipDateEnd != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "ship_date_end", shipDateEnd));
        }
        if (createdAtStart != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "created_at_start", createdAtStart));
        }
        if (createdAtEnd != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "created_at_end", createdAtEnd));
        }
        if (carrierId != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "carrier_id", carrierId));
        }
        if (page != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "page", page));
        }
        if (pageSize != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
        }
        if (labelIds != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.ClientUtils.ParameterToMultiMap("multi", "label_ids", labelIds));
        }

        requestOptions.Operation = "ManifestsApi.ListManifests";

        var result = await SendHttpRequestAsync<ListManifestsResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}
// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


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
    /// Create Warehouse Create a warehouse location that you can use to create shipping items by simply passing in the generated warehouse id. If the return address is not supplied in the request body then it is assumed that the origin address is the return address as well 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWarehouseRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWarehouseResponseBody)</returns>
    Task<CreateWarehouseResponseBody> CreateWarehouse(CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Warehouse Create a warehouse location that you can use to create shipping items by simply passing in the generated warehouse id. If the return address is not supplied in the request body then it is assumed that the origin address is the return address as well 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createWarehouseRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWarehouseResponseBody)</returns>
    Task<CreateWarehouseResponseBody> CreateWarehouse(HttpClient methodClient, CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Warehouse By ID Delete a warehouse by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteWarehouse(string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Warehouse By ID Delete a warehouse by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteWarehouse(HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Warehouse By Id Retrieve warehouse data based on the warehouse ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWarehouseByIdResponseBody)</returns>
    Task<GetWarehouseByIdResponseBody> GetWarehouseById(string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Warehouse By Id Retrieve warehouse data based on the warehouse ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWarehouseByIdResponseBody)</returns>
    Task<GetWarehouseByIdResponseBody> GetWarehouseById(HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Warehouses Retrieve a list of warehouses associated with this account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListWarehousesResponseBody)</returns>
    Task<ListWarehousesResponseBody> ListWarehouses(CancellationToken cancellationToken = default);

    /// <summary>
    /// List Warehouses Retrieve a list of warehouses associated with this account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListWarehousesResponseBody)</returns>
    Task<ListWarehousesResponseBody> ListWarehouses(HttpClient methodClient, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Warehouse By Id Update Warehouse object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updateWarehouseRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWarehouse(UpdateWarehouseRequestBody updateWarehouseRequestBody, string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Warehouse By Id Update Warehouse object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updateWarehouseRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWarehouse(HttpClient methodClient, UpdateWarehouseRequestBody updateWarehouseRequestBody, string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Warehouse Settings Update Warehouse settings object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updateWarehouseSettingsRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWarehouseSettings(UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBody, string warehouseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Warehouse Settings Update Warehouse settings object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updateWarehouseSettingsRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWarehouseSettings(HttpClient methodClient, UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBody, string warehouseId, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Create Warehouse Create a warehouse location that you can use to create shipping items by simply passing in the generated warehouse id. If the return address is not supplied in the request body then it is assumed that the origin address is the return address as well 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWarehouseRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWarehouseResponseBody)</returns>
    public Task<CreateWarehouseResponseBody> CreateWarehouse(CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default)
    {
        return CreateWarehouse(_client, createWarehouseRequestBody, cancellationToken);
    }

    /// <summary>
    /// Create Warehouse Create a warehouse location that you can use to create shipping items by simply passing in the generated warehouse id. If the return address is not supplied in the request body then it is assumed that the origin address is the return address as well 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createWarehouseRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWarehouseResponseBody)</returns>
    public async Task<CreateWarehouseResponseBody> CreateWarehouse(HttpClient methodClient, CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'createWarehouseRequestBody' is set
        if (createWarehouseRequestBody == null)
        {
            throw new ArgumentNullException(nameof(createWarehouseRequestBody));
        }


        RequestOptions requestOptions = new("/v1/warehouses");

        requestOptions.Data = JsonSerializer.Serialize(createWarehouseRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "WarehousesApi.CreateWarehouse";

        var result = await SendHttpRequestAsync<CreateWarehouseResponseBody>(HttpMethods.Post, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Delete Warehouse By ID Delete a warehouse by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> DeleteWarehouse(string warehouseId, CancellationToken cancellationToken = default)
    {
        return DeleteWarehouse(_client, warehouseId, cancellationToken);
    }

    /// <summary>
    /// Delete Warehouse By ID Delete a warehouse by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DeleteWarehouse(HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'warehouseId' is set
        if (warehouseId == null)
        {
            throw new ArgumentNullException(nameof(warehouseId));
        }


        RequestOptions requestOptions = new("/v1/warehouses/{warehouse_id}");

        requestOptions.PathParameters.Add("warehouse_id", ClientUtils.ParameterToString(warehouseId)); // path parameter

        requestOptions.Operation = "WarehousesApi.DeleteWarehouse";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Warehouse By Id Retrieve warehouse data based on the warehouse ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWarehouseByIdResponseBody)</returns>
    public Task<GetWarehouseByIdResponseBody> GetWarehouseById(string warehouseId, CancellationToken cancellationToken = default)
    {
        return GetWarehouseById(_client, warehouseId, cancellationToken);
    }

    /// <summary>
    /// Get Warehouse By Id Retrieve warehouse data based on the warehouse ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWarehouseByIdResponseBody)</returns>
    public async Task<GetWarehouseByIdResponseBody> GetWarehouseById(HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'warehouseId' is set
        if (warehouseId == null)
        {
            throw new ArgumentNullException(nameof(warehouseId));
        }


        RequestOptions requestOptions = new("/v1/warehouses/{warehouse_id}");

        requestOptions.PathParameters.Add("warehouse_id", ClientUtils.ParameterToString(warehouseId)); // path parameter

        requestOptions.Operation = "WarehousesApi.GetWarehouseById";

        var result = await SendHttpRequestAsync<GetWarehouseByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Warehouses Retrieve a list of warehouses associated with this account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListWarehousesResponseBody)</returns>
    public Task<ListWarehousesResponseBody> ListWarehouses(CancellationToken cancellationToken = default)
    {
        return ListWarehouses(_client, cancellationToken);
    }

    /// <summary>
    /// List Warehouses Retrieve a list of warehouses associated with this account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListWarehousesResponseBody)</returns>
    public async Task<ListWarehousesResponseBody> ListWarehouses(HttpClient methodClient, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/warehouses");


        requestOptions.Operation = "WarehousesApi.ListWarehouses";

        var result = await SendHttpRequestAsync<ListWarehousesResponseBody>(HttpMethods.Get, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Update Warehouse By Id Update Warehouse object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updateWarehouseRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> UpdateWarehouse(UpdateWarehouseRequestBody updateWarehouseRequestBody, string warehouseId, CancellationToken cancellationToken = default)
    {
        return UpdateWarehouse(_client, updateWarehouseRequestBody, warehouseId, cancellationToken);
    }

    /// <summary>
    /// Update Warehouse By Id Update Warehouse object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updateWarehouseRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateWarehouse(HttpClient methodClient, UpdateWarehouseRequestBody updateWarehouseRequestBody, string warehouseId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'updateWarehouseRequestBody' is set
        if (updateWarehouseRequestBody == null)
        {
            throw new ArgumentNullException(nameof(updateWarehouseRequestBody));
        }

        // verify the required parameter 'warehouseId' is set
        if (warehouseId == null)
        {
            throw new ArgumentNullException(nameof(warehouseId));
        }


        RequestOptions requestOptions = new("/v1/warehouses/{warehouse_id}");

        requestOptions.PathParameters.Add("warehouse_id", ClientUtils.ParameterToString(warehouseId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(updateWarehouseRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "WarehousesApi.UpdateWarehouse";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Put, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Update Warehouse Settings Update Warehouse settings object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updateWarehouseSettingsRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> UpdateWarehouseSettings(UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBody, string warehouseId, CancellationToken cancellationToken = default)
    {
        return UpdateWarehouseSettings(_client, updateWarehouseSettingsRequestBody, warehouseId, cancellationToken);
    }

    /// <summary>
    /// Update Warehouse Settings Update Warehouse settings object information
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updateWarehouseSettingsRequestBody"></param>
    /// <param name="warehouseId">Warehouse ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateWarehouseSettings(HttpClient methodClient, UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBody, string warehouseId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'updateWarehouseSettingsRequestBody' is set
        if (updateWarehouseSettingsRequestBody == null)
        {
            throw new ArgumentNullException(nameof(updateWarehouseSettingsRequestBody));
        }

        // verify the required parameter 'warehouseId' is set
        if (warehouseId == null)
        {
            throw new ArgumentNullException(nameof(warehouseId));
        }


        RequestOptions requestOptions = new("/v1/warehouses/{warehouse_id}/settings");

        requestOptions.PathParameters.Add("warehouse_id", ClientUtils.ParameterToString(warehouseId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(updateWarehouseSettingsRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "WarehousesApi.UpdateWarehouseSettings";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Put, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}
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
    /// Create Custom Package Type Create a custom package type to better assist in getting accurate rate estimates
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createPackageTypeRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (CreatePackageTypeResponseBody)</returns>
    Task<ShipEngineResponse<CreatePackageTypeResponseBody>> CreatePackageType(CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Custom Package Type Create a custom package type to better assist in getting accurate rate estimates
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createPackageTypeRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (CreatePackageTypeResponseBody)</returns>
    Task<ShipEngineResponse<CreatePackageTypeResponseBody>> CreatePackageType(HttpClient methodClient, CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete A Custom Package By ID Delete a custom package using the ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    Task<ShipEngineResponse<string>> DeletePackageType(string packageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete A Custom Package By ID Delete a custom package using the ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    Task<ShipEngineResponse<string>> DeletePackageType(HttpClient methodClient, string packageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Custom Package Type By ID Get Custom Package Type by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (GetPackageTypeByIdResponseBody)</returns>
    Task<ShipEngineResponse<GetPackageTypeByIdResponseBody>> GetPackageTypeById(string packageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Custom Package Type By ID Get Custom Package Type by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (GetPackageTypeByIdResponseBody)</returns>
    Task<ShipEngineResponse<GetPackageTypeByIdResponseBody>> GetPackageTypeById(HttpClient methodClient, string packageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Custom Package Types List the custom package types associated with the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (ListPackageTypesResponseBody)</returns>
    Task<ShipEngineResponse<ListPackageTypesResponseBody>> ListPackageTypes(CancellationToken cancellationToken = default);

    /// <summary>
    /// List Custom Package Types List the custom package types associated with the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (ListPackageTypesResponseBody)</returns>
    Task<ShipEngineResponse<ListPackageTypesResponseBody>> ListPackageTypes(HttpClient methodClient, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Custom Package Type By ID Update the custom package type object by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updatePackageTypeRequestBody"></param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    Task<ShipEngineResponse<string>> UpdatePackageType(UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Custom Package Type By ID Update the custom package type object by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updatePackageTypeRequestBody"></param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    Task<ShipEngineResponse<string>> UpdatePackageType(HttpClient methodClient, UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Create Custom Package Type Create a custom package type to better assist in getting accurate rate estimates
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createPackageTypeRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (CreatePackageTypeResponseBody)</returns>
    public Task<ShipEngineResponse<CreatePackageTypeResponseBody>> CreatePackageType(CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default)
    {
        return CreatePackageType(_client, createPackageTypeRequestBody, cancellationToken);
    }

    /// <summary>
    /// Create Custom Package Type Create a custom package type to better assist in getting accurate rate estimates
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="createPackageTypeRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (CreatePackageTypeResponseBody)</returns>
    public async Task<ShipEngineResponse<CreatePackageTypeResponseBody>> CreatePackageType(HttpClient methodClient, CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'createPackageTypeRequestBody' is set
        if (createPackageTypeRequestBody == null)
        {
            throw new ArgumentNullException(nameof(createPackageTypeRequestBody));
        }


        RequestOptions requestOptions = new("/v1/packages");

        requestOptions.Data = JsonSerializer.Serialize(createPackageTypeRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "PackageTypesApi.CreatePackageType";

        var (data, response) = await GetHttpResponse<CreatePackageTypeResponseBody>(HttpMethods.Post, requestOptions.FullPath(), requestOptions.Data, methodClient, _config, cancellationToken);
        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(),
            StringComparer.InvariantCultureIgnoreCase);
        return new ShipEngineResponse<CreatePackageTypeResponseBody>(data, response.StatusCode, headers);
    }

    /// <summary>
    /// Delete A Custom Package By ID Delete a custom package using the ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    public Task<ShipEngineResponse<string>> DeletePackageType(string packageId, CancellationToken cancellationToken = default)
    {
        return DeletePackageType(_client, packageId, cancellationToken);
    }

    /// <summary>
    /// Delete A Custom Package By ID Delete a custom package using the ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    public async Task<ShipEngineResponse<string>> DeletePackageType(HttpClient methodClient, string packageId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'packageId' is set
        if (packageId == null)
        {
            throw new ArgumentNullException(nameof(packageId));
        }


        RequestOptions requestOptions = new("/v1/packages/{package_id}");

        requestOptions.PathParameters.Add("package_id", ClientUtils.ParameterToString(packageId)); // path parameter

        requestOptions.Operation = "PackageTypesApi.DeletePackageType";

        var (data, response) = await GetHttpResponse<string>(HttpMethods.Delete, requestOptions.FullPath(), requestOptions.Data, methodClient, _config, cancellationToken);
        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(),
            StringComparer.InvariantCultureIgnoreCase);
        return new ShipEngineResponse<string>(data, response.StatusCode, headers);
    }

    /// <summary>
    /// Get Custom Package Type By ID Get Custom Package Type by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (GetPackageTypeByIdResponseBody)</returns>
    public Task<ShipEngineResponse<GetPackageTypeByIdResponseBody>> GetPackageTypeById(string packageId, CancellationToken cancellationToken = default)
    {
        return GetPackageTypeById(_client, packageId, cancellationToken);
    }

    /// <summary>
    /// Get Custom Package Type By ID Get Custom Package Type by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (GetPackageTypeByIdResponseBody)</returns>
    public async Task<ShipEngineResponse<GetPackageTypeByIdResponseBody>> GetPackageTypeById(HttpClient methodClient, string packageId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'packageId' is set
        if (packageId == null)
        {
            throw new ArgumentNullException(nameof(packageId));
        }


        RequestOptions requestOptions = new("/v1/packages/{package_id}");

        requestOptions.PathParameters.Add("package_id", ClientUtils.ParameterToString(packageId)); // path parameter

        requestOptions.Operation = "PackageTypesApi.GetPackageTypeById";

        var (data, response) = await GetHttpResponse<GetPackageTypeByIdResponseBody>(HttpMethods.Get, requestOptions.FullPath(), requestOptions.Data, methodClient, _config, cancellationToken);
        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(),
            StringComparer.InvariantCultureIgnoreCase);
        return new ShipEngineResponse<GetPackageTypeByIdResponseBody>(data, response.StatusCode, headers);
    }

    /// <summary>
    /// List Custom Package Types List the custom package types associated with the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (ListPackageTypesResponseBody)</returns>
    public Task<ShipEngineResponse<ListPackageTypesResponseBody>> ListPackageTypes(CancellationToken cancellationToken = default)
    {
        return ListPackageTypes(_client, cancellationToken);
    }

    /// <summary>
    /// List Custom Package Types List the custom package types associated with the account
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (ListPackageTypesResponseBody)</returns>
    public async Task<ShipEngineResponse<ListPackageTypesResponseBody>> ListPackageTypes(HttpClient methodClient, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/packages");


        requestOptions.Operation = "PackageTypesApi.ListPackageTypes";

        var (data, response) = await GetHttpResponse<ListPackageTypesResponseBody>(HttpMethods.Get, requestOptions.FullPath(), requestOptions.Data, methodClient, _config, cancellationToken);
        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(),
            StringComparer.InvariantCultureIgnoreCase);
        return new ShipEngineResponse<ListPackageTypesResponseBody>(data, response.StatusCode, headers);
    }

    /// <summary>
    /// Update Custom Package Type By ID Update the custom package type object by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="updatePackageTypeRequestBody"></param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    public Task<ShipEngineResponse<string>> UpdatePackageType(UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default)
    {
        return UpdatePackageType(_client, updatePackageTypeRequestBody, packageId, cancellationToken);
    }

    /// <summary>
    /// Update Custom Package Type By ID Update the custom package type object by ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="updatePackageTypeRequestBody"></param>
    /// <param name="packageId">Package ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ShipEngineResponse (string)</returns>
    public async Task<ShipEngineResponse<string>> UpdatePackageType(HttpClient methodClient, UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'updatePackageTypeRequestBody' is set
        if (updatePackageTypeRequestBody == null)
        {
            throw new ArgumentNullException(nameof(updatePackageTypeRequestBody));
        }

        // verify the required parameter 'packageId' is set
        if (packageId == null)
        {
            throw new ArgumentNullException(nameof(packageId));
        }


        RequestOptions requestOptions = new("/v1/packages/{package_id}");

        requestOptions.PathParameters.Add("package_id", ClientUtils.ParameterToString(packageId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(updatePackageTypeRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "PackageTypesApi.UpdatePackageType";

        var (data, response) = await GetHttpResponse<string>(HttpMethods.Put, requestOptions.FullPath(), requestOptions.Data, methodClient, _config, cancellationToken);
        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(),
            StringComparer.InvariantCultureIgnoreCase);
        return new ShipEngineResponse<string>(data, response.StatusCode, headers);
    }

}

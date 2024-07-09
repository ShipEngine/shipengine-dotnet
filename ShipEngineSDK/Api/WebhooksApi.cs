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
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    Task<CreateWebhookResponseBody> CreateWebhook(CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    Task<CreateWebhookResponseBody> CreateWebhook(Config methodConfig, CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    Task<CreateWebhookResponseBody> CreateWebhook(HttpClient methodClient, Config methodConfig, CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteWebhook(string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteWebhook(Config methodConfig, string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteWebhook(HttpClient methodClient, Config methodConfig, string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    Task<GetWebhookByIdResponseBody> GetWebhookById(string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    Task<GetWebhookByIdResponseBody> GetWebhookById(Config methodConfig, string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    Task<GetWebhookByIdResponseBody> GetWebhookById(HttpClient methodClient, Config methodConfig, string webhookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    Task<List<Webhook>> ListWebhooks(CancellationToken cancellationToken = default);

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    Task<List<Webhook>> ListWebhooks(Config methodConfig, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    Task<List<Webhook>> ListWebhooks(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWebhook(string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWebhook(Config methodConfig, string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> UpdateWebhook(HttpClient methodClient, Config methodConfig, string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    public Task<CreateWebhookResponseBody> CreateWebhook(CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        return CreateWebhook(_client, _config, createWebhookRequestBody, cancellationToken);
    }

    /// <summary>
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    public async Task<CreateWebhookResponseBody> CreateWebhook(Config methodConfig, CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await CreateWebhook(methodClient, methodConfig, createWebhookRequestBody, cancellationToken);
    }

    /// <summary>
    /// Create a Webhook Create a webook for specific events in the environment.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="createWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateWebhookResponseBody)</returns>
    public async Task<CreateWebhookResponseBody> CreateWebhook(HttpClient methodClient, Config methodConfig, CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'createWebhookRequestBody' is set
        if (createWebhookRequestBody == null)
        {
            throw new ArgumentNullException(nameof(createWebhookRequestBody));
        }


        RequestOptions requestOptions = new("/v1/environment/webhooks");

        requestOptions.Data = JsonSerializer.Serialize(createWebhookRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "WebhooksApi.CreateWebhook";

        var result = await SendHttpRequestAsync<CreateWebhookResponseBody>(HttpMethods.Post, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> DeleteWebhook(string webhookId, CancellationToken cancellationToken = default)
    {
        return DeleteWebhook(_client, _config, webhookId, cancellationToken);
    }

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DeleteWebhook(Config methodConfig, string webhookId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await DeleteWebhook(methodClient, methodConfig, webhookId, cancellationToken);
    }

    /// <summary>
    /// Delete Webhook By ID Delete a webhook
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DeleteWebhook(HttpClient methodClient, Config methodConfig, string webhookId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'webhookId' is set
        if (webhookId == null)
        {
            throw new ArgumentNullException(nameof(webhookId));
        }


        RequestOptions requestOptions = new("/v1/environment/webhooks/{webhook_id}");

        requestOptions.PathParameters.Add("webhook_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(webhookId)); // path parameter

        requestOptions.Operation = "WebhooksApi.DeleteWebhook";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    public Task<GetWebhookByIdResponseBody> GetWebhookById(string webhookId, CancellationToken cancellationToken = default)
    {
        return GetWebhookById(_client, _config, webhookId, cancellationToken);
    }

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    public async Task<GetWebhookByIdResponseBody> GetWebhookById(Config methodConfig, string webhookId, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await GetWebhookById(methodClient, methodConfig, webhookId, cancellationToken);
    }

    /// <summary>
    /// Get Webhook By ID Retrieve individual webhook by an ID
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetWebhookByIdResponseBody)</returns>
    public async Task<GetWebhookByIdResponseBody> GetWebhookById(HttpClient methodClient, Config methodConfig, string webhookId, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'webhookId' is set
        if (webhookId == null)
        {
            throw new ArgumentNullException(nameof(webhookId));
        }


        RequestOptions requestOptions = new("/v1/environment/webhooks/{webhook_id}");

        requestOptions.PathParameters.Add("webhook_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(webhookId)); // path parameter

        requestOptions.Operation = "WebhooksApi.GetWebhookById";

        var result = await SendHttpRequestAsync<GetWebhookByIdResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    public Task<List<Webhook>> ListWebhooks(CancellationToken cancellationToken = default)
    {
        return ListWebhooks(_client, _config, cancellationToken);
    }

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    public async Task<List<Webhook>> ListWebhooks(Config methodConfig, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ListWebhooks(methodClient, methodConfig, cancellationToken);
    }

    /// <summary>
    /// List Webhooks List all webhooks currently enabled for the account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Webhook&gt;)</returns>
    public async Task<List<Webhook>> ListWebhooks(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default)
    {

        RequestOptions requestOptions = new("/v1/environment/webhooks");


        requestOptions.Operation = "WebhooksApi.ListWebhooks";

        var result = await SendHttpRequestAsync<List<Webhook>>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> UpdateWebhook(string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        return UpdateWebhook(_client, _config, webhookId, updateWebhookRequestBody, cancellationToken);
    }

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateWebhook(Config methodConfig, string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await UpdateWebhook(methodClient, methodConfig, webhookId, updateWebhookRequestBody, cancellationToken);
    }

    /// <summary>
    /// Update a Webhook Update the webhook url property
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="webhookId">Webhook ID</param>
    /// <param name="updateWebhookRequestBody"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> UpdateWebhook(HttpClient methodClient, Config methodConfig, string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'webhookId' is set
        if (webhookId == null)
        {
            throw new ArgumentNullException(nameof(webhookId));
        }

        // verify the required parameter 'updateWebhookRequestBody' is set
        if (updateWebhookRequestBody == null)
        {
            throw new ArgumentNullException(nameof(updateWebhookRequestBody));
        }


        RequestOptions requestOptions = new("/v1/environment/webhooks/{webhook_id}");

        requestOptions.PathParameters.Add("webhook_id", ShipEngineSDK.Client.ClientUtils.ParameterToString(webhookId)); // path parameter
        requestOptions.Data = JsonSerializer.Serialize(updateWebhookRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "WebhooksApi.UpdateWebhook";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Put, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}
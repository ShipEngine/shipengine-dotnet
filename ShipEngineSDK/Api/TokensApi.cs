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
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(string redirect, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(Config methodConfig, string redirect, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(HttpClient methodClient, Config methodConfig, string redirect, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    public Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(string? redirect = default, CancellationToken cancellationToken = default)
    {
        return TokensGetEphemeralToken(_client, _config, redirect, cancellationToken);
    }

    /// <summary>
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    public async Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(Config methodConfig, string? redirect = default, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await TokensGetEphemeralToken(methodClient, methodConfig, redirect, cancellationToken);
    }

    /// <summary>
    /// Get Ephemeral Token This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="redirect">Include a redirect url to the application formatted with the ephemeral token. (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensGetEphemeralTokenResponseBodyYaml)</returns>
    public async Task<TokensGetEphemeralTokenResponseBodyYaml> TokensGetEphemeralToken(HttpClient methodClient, Config methodConfig, string? redirect = default, CancellationToken cancellationToken = default)
    {
        redirect ??= "shipengine-dashboard";


        RequestOptions requestOptions = new("/v1/tokens/ephemeral");

        if (redirect != null)
        {
            requestOptions.QueryParameters.Add(ShipEngineSDK.Client.ClientUtils.ParameterToMultiMap("", "redirect", redirect));
        }

        requestOptions.Operation = "TokensApi.TokensGetEphemeralToken";

        var result = await SendHttpRequestAsync<TokensGetEphemeralTokenResponseBodyYaml>(HttpMethods.Post, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}
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
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    Task<CreateTagResponseBody> CreateTag(string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    Task<CreateTagResponseBody> CreateTag(Config methodConfig, string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    Task<CreateTagResponseBody> CreateTag(HttpClient methodClient, Config methodConfig, string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteTag(string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteTag(Config methodConfig, string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> DeleteTag(HttpClient methodClient, Config methodConfig, string tagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    Task<ListTagsResponseBody> ListTags(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    Task<ListTagsResponseBody> ListTags(Config methodConfig, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    Task<ListTagsResponseBody> ListTags(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> RenameTag(string tagName, string newTagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> RenameTag(Config methodConfig, string tagName, string newTagName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    Task<string> RenameTag(HttpClient methodClient, Config methodConfig, string tagName, string newTagName, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    public Task<CreateTagResponseBody> CreateTag(string tagName, CancellationToken cancellationToken = default)
    {
        return CreateTag(_client, _config, tagName, cancellationToken);
    }

    /// <summary>
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    public async Task<CreateTagResponseBody> CreateTag(Config methodConfig, string tagName, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await CreateTag(methodClient, methodConfig, tagName, cancellationToken);
    }

    /// <summary>
    /// Create a New Tag Create a new Tag for customizing how you track your shipments
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CreateTagResponseBody)</returns>
    public async Task<CreateTagResponseBody> CreateTag(HttpClient methodClient, Config methodConfig, string tagName, CancellationToken cancellationToken = default)
    {

        // verify the required parameter 'tagName' is set
        if (tagName == null)
        {
            throw new ArgumentNullException(nameof(tagName));
        }


        RequestOptions requestOptions = new("/v1/tags/{tag_name}");

        requestOptions.PathParameters.Add("tag_name", ShipEngineSDK.Client.ClientUtils.ParameterToString(tagName)); // path parameter

        requestOptions.Operation = "TagsApi.CreateTag";

        var result = await SendHttpRequestAsync<CreateTagResponseBody>(HttpMethods.Post, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> DeleteTag(string tagName, CancellationToken cancellationToken = default)
    {
        return DeleteTag(_client, _config, tagName, cancellationToken);
    }

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DeleteTag(Config methodConfig, string tagName, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await DeleteTag(methodClient, methodConfig, tagName, cancellationToken);
    }

    /// <summary>
    /// Delete Tag Delete a tag that is no longer needed
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> DeleteTag(HttpClient methodClient, Config methodConfig, string tagName, CancellationToken cancellationToken = default)
    {

        // verify the required parameter 'tagName' is set
        if (tagName == null)
        {
            throw new ArgumentNullException(nameof(tagName));
        }


        RequestOptions requestOptions = new("/v1/tags/{tag_name}");

        requestOptions.PathParameters.Add("tag_name", ShipEngineSDK.Client.ClientUtils.ParameterToString(tagName)); // path parameter

        requestOptions.Operation = "TagsApi.DeleteTag";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Delete, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    public Task<ListTagsResponseBody> ListTags(CancellationToken cancellationToken = default)
    {
        return ListTags(_client, _config, cancellationToken);
    }

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    public async Task<ListTagsResponseBody> ListTags(Config methodConfig, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await ListTags(methodClient, methodConfig, cancellationToken);
    }

    /// <summary>
    /// Get Tags Get a list of all tags associated with an account.
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ListTagsResponseBody)</returns>
    public async Task<ListTagsResponseBody> ListTags(HttpClient methodClient, Config methodConfig, CancellationToken cancellationToken = default)
    {


        RequestOptions requestOptions = new("/v1/tags");


        requestOptions.Operation = "TagsApi.ListTags";

        var result = await SendHttpRequestAsync<ListTagsResponseBody>(HttpMethods.Get, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public Task<string> RenameTag(string tagName, string newTagName, CancellationToken cancellationToken = default)
    {
        return RenameTag(_client, _config, tagName, newTagName, cancellationToken);
    }

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> RenameTag(Config methodConfig, string tagName, string newTagName, CancellationToken cancellationToken = default)
    {
        using var methodClient = ConfigureHttpClient(methodConfig, new HttpClient());
        return await RenameTag(methodClient, methodConfig, tagName, newTagName, cancellationToken);
    }

    /// <summary>
    /// Update Tag Name Change a tag name while still keeping the relevant shipments attached to it
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="tagName"></param>
    /// <param name="newTagName"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    public async Task<string> RenameTag(HttpClient methodClient, Config methodConfig, string tagName, string newTagName, CancellationToken cancellationToken = default)
    {

        // verify the required parameter 'tagName' is set
        if (tagName == null)
        {
            throw new ArgumentNullException(nameof(tagName));
        }

        // verify the required parameter 'newTagName' is set
        if (newTagName == null)
        {
            throw new ArgumentNullException(nameof(newTagName));
        }


        RequestOptions requestOptions = new("/v1/tags/{tag_name}/{new_tag_name}");

        requestOptions.PathParameters.Add("tag_name", ShipEngineSDK.Client.ClientUtils.ParameterToString(tagName)); // path parameter
        requestOptions.PathParameters.Add("new_tag_name", ShipEngineSDK.Client.ClientUtils.ParameterToString(newTagName)); // path parameter

        requestOptions.Operation = "TagsApi.RenameTag";

        var result = await SendHttpRequestAsync<string>(HttpMethods.Put, requestOptions, methodClient, methodConfig, cancellationToken);

        return result;
    }

}
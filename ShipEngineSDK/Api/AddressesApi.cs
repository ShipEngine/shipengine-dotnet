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
    /// Parse an address The address-recognition API makes it easy for you to extract address data from unstructured text, including the recipient name, line 1, line 2, city, postal code, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine&#39;s address-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed address data is returned in the same structure that&#39;s used for other ShipEngine APIs, such as address validation, rate quotes, and shipping labels.  &gt; **Note:** Address recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="parseAddressRequestBody">The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. </param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ParseAddressResponseBody)</returns>
    Task<ParseAddressResponseBody> ParseAddress(ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Parse an address The address-recognition API makes it easy for you to extract address data from unstructured text, including the recipient name, line 1, line 2, city, postal code, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine&#39;s address-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed address data is returned in the same structure that&#39;s used for other ShipEngine APIs, such as address validation, rate quotes, and shipping labels.  &gt; **Note:** Address recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="parseAddressRequestBody">The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. </param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ParseAddressResponseBody)</returns>
    Task<ParseAddressResponseBody> ParseAddress(HttpClient methodClient, ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate An Address Address validation ensures accurate addresses and can lead to reduced shipping costs by preventing address correction surcharges. ShipEngine cross references multiple databases to validate addresses and identify potential deliverability issues. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="addressToValidate"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;AddressValidationResult&gt;)</returns>
    Task<List<AddressValidationResult>> ValidateAddress(List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate An Address Address validation ensures accurate addresses and can lead to reduced shipping costs by preventing address correction surcharges. ShipEngine cross references multiple databases to validate addresses and identify potential deliverability issues. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="addressToValidate"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;AddressValidationResult&gt;)</returns>
    Task<List<AddressValidationResult>> ValidateAddress(HttpClient methodClient, List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default);

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ShipEngine
{
    /// <summary>
    /// Parse an address The address-recognition API makes it easy for you to extract address data from unstructured text, including the recipient name, line 1, line 2, city, postal code, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine&#39;s address-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed address data is returned in the same structure that&#39;s used for other ShipEngine APIs, such as address validation, rate quotes, and shipping labels.  &gt; **Note:** Address recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="parseAddressRequestBody">The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. </param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ParseAddressResponseBody)</returns>
    public Task<ParseAddressResponseBody> ParseAddress(ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default)
    {
        return ParseAddress(_client, parseAddressRequestBody, cancellationToken);
    }

    /// <summary>
    /// Parse an address The address-recognition API makes it easy for you to extract address data from unstructured text, including the recipient name, line 1, line 2, city, postal code, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine&#39;s address-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed address data is returned in the same structure that&#39;s used for other ShipEngine APIs, such as address validation, rate quotes, and shipping labels.  &gt; **Note:** Address recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="parseAddressRequestBody">The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. </param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ParseAddressResponseBody)</returns>
    public async Task<ParseAddressResponseBody> ParseAddress(HttpClient methodClient, ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'parseAddressRequestBody' is set
        if (parseAddressRequestBody == null)
        {
            throw new ArgumentNullException(nameof(parseAddressRequestBody));
        }


        RequestOptions requestOptions = new("/v1/addresses/recognize");

        requestOptions.Data = JsonSerializer.Serialize(parseAddressRequestBody, JsonSerializerOptions);

        requestOptions.Operation = "AddressesApi.ParseAddress";

        var result = await SendHttpRequestAsync<ParseAddressResponseBody>(HttpMethods.Put, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

    /// <summary>
    /// Validate An Address Address validation ensures accurate addresses and can lead to reduced shipping costs by preventing address correction surcharges. ShipEngine cross references multiple databases to validate addresses and identify potential deliverability issues. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="addressToValidate"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;AddressValidationResult&gt;)</returns>
    public Task<List<AddressValidationResult>> ValidateAddress(List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default)
    {
        return ValidateAddress(_client, addressToValidate, cancellationToken);
    }

    /// <summary>
    /// Validate An Address Address validation ensures accurate addresses and can lead to reduced shipping costs by preventing address correction surcharges. ShipEngine cross references multiple databases to validate addresses and identify potential deliverability issues. 
    /// </summary>
    /// <exception cref="System.ArgumentNullException">Thrown when required argument is null</exception>
    /// <exception cref="ShipEngineSDK.ShipEngineException">Thrown when fails to make API call</exception>
    /// <param name="methodClient">HttpClient to use for the request</param>
    /// <param name="addressToValidate"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;AddressValidationResult&gt;)</returns>
    public async Task<List<AddressValidationResult>> ValidateAddress(HttpClient methodClient, List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'addressToValidate' is set
        if (addressToValidate == null)
        {
            throw new ArgumentNullException(nameof(addressToValidate));
        }


        RequestOptions requestOptions = new("/v1/addresses/validate");

        requestOptions.Data = JsonSerializer.Serialize(addressToValidate, JsonSerializerOptions);

        requestOptions.Operation = "AddressesApi.ValidateAddress";

        var result = await SendHttpRequestAsync<List<AddressValidationResult>>(HttpMethods.Post, requestOptions, methodClient, _config, cancellationToken);

        return result;
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace ShipEngineSDK;

/// <summary>
/// Response from ShipEngine API that includes the data, status code, and headers
/// </summary>
/// <typeparam name="T">Type of data returned from the API</typeparam>
/// <param name="data">Deserialized data from the API</param>
/// <param name="message">Response message from the server</param>
public class ShipEngineResponse<T>(T data, HttpResponseMessage message)
{
    /// <summary>
    /// Data returned from the API
    /// </summary>
    public T Data { get; } = data;

    /// <summary>
    /// Status code of the response
    /// </summary>
    public HttpStatusCode HttpStatus { get; } = message.StatusCode;

    /// <summary>
    /// Headers returned from the API
    /// </summary>
    public IDictionary<string, string> Headers { get; } = message.Headers
        .ToDictionary(h => h.Key, h => h.Value.FirstOrDefault(), StringComparer.InvariantCultureIgnoreCase);
}
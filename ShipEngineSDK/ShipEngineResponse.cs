namespace ShipEngineSDK;

using System.Collections.Generic;
using System.Net;

public class ShipEngineResponse<T>
{
    private readonly T _data;
    public HttpStatusCode HttpStatus { get; private init; }
    public IDictionary<string, string> Headers { get; private init; }

    public ShipEngineResponse(T data, HttpStatusCode httpStatus, Dictionary<string, string> headers)
    {
        _data = data;
        HttpStatus = httpStatus;
        Headers = headers;
    }
}
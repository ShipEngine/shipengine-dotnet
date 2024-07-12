using System.Net.Http;

namespace ShipEngineSDK;

/// <summary>
/// Http methods
/// </summary>
/// <remarks>
/// This is needed because the HttpMethod class does not have a PATCH method in the version of .NET that we are using.
/// </remarks>
internal static class HttpMethods
{
    public static HttpMethod Delete => HttpMethod.Delete;
    public static HttpMethod Get => HttpMethod.Get;
    public static HttpMethod Patch => new("PATCH");
    public static HttpMethod Post => HttpMethod.Post;
    public static HttpMethod Put => HttpMethod.Put;
}
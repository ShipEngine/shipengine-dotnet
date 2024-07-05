using System.Net.Http;

namespace ShipEngineSDK;

/// <summary>
/// Http methods
/// </summary>
/// <remarks>
/// This is needed because the HttpMethod class does not have a PATCH method in the version of .NET that we are using.
/// </remarks>
internal static class HttpMethods {
    public static HttpMethod Delete { get; } = HttpMethod.Delete;
    public static HttpMethod Get { get; } = HttpMethod.Get;
    public static HttpMethod Patch { get; } = new HttpMethod("PATCH");
    public static HttpMethod Post { get; } = HttpMethod.Post;
    public static HttpMethod Put { get; } = HttpMethod.Put;
}
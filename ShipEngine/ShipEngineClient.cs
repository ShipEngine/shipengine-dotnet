using ShipEngineSDK.Common;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace ShipEngineSDK
{

    /// <summary>
    /// ShipEngine Client is used for handling generic calls and settings that
    /// are needed for all ShipEngine API calls.
    /// </summary>
    public class ShipEngineClient
    {
        /// <summary>
        /// Options for serializing the method call params to JSON.
        /// A separate inline setting is used for deserializing the response
        /// </summary>
        protected static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Converters = { new JsonStringEnumMemberConverter() }
        };

        private const string JsonMediaType = "application/json";

        /// <summary>
        /// Token to cancel the request
        /// </summary>
        public CancellationToken CancellationToken { get; set; }

        /// <summary>
        /// Sets the HttpClient User agent, the json media type, and the API key to be used
        /// for all ShipEngine API calls unless overrwritten at the method level.
        /// </summary>
        /// <param name="config">Config object used to configure the HttpClient</param>
        /// <param name="client">The HttpClient to be configured</param>
        /// <returns></returns>
        public static HttpClient ConfigureHttpClient(Config config, HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var osPlatform = Environment.OSVersion.Platform.ToString();
            var osVersion = Environment.OSVersion.Version.ToString();
            var clrVersion = Environment.Version.ToString();

            var sdkVersionObject = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var sdkVersion = $"{sdkVersionObject.Major}.{sdkVersionObject.Minor}.{sdkVersionObject.Build}";

            var userAgentString = $"shipengine-dotnet/{sdkVersion} {osPlatform}/{osVersion} clr/{clrVersion}";

            client.DefaultRequestHeaders.Add("User-Agent", userAgentString);
            client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", JsonMediaType);

            client.BaseAddress = new Uri("https://api.shipengine.com");

            client.Timeout = config.Timeout;

            return client;
        }

        /// <summary>
        /// Sets the HttpClient User agent, the json media type, and the API key to be used
        /// for all ShipEngine API calls unless overwritten at the method level.
        /// </summary>
        /// <param name="client">The HttpClient to be configured</param>
        /// <param name="apiKey">The API key to be used for all ShipEngine API calls</param>
        /// <param name="baseUri">The base URI for the ShipEngine API</param>
        /// <param name="timeout">The timeout for the ShipEngine API Calls</param>
        /// <returns></returns>
        public static HttpClient ConfigureHttpClient(HttpClient client, string apiKey, Uri? baseUri, TimeSpan? timeout = null)
        {
            var config = new Config(apiKey, timeout);
            client.BaseAddress = baseUri ?? new Uri("https://api.shipengine.com");
            return ConfigureHttpClient(config, client);
        }

        private async Task<T> DeserializedResultOrThrow<T>(HttpResponseMessage response)
        {
            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ShipEngineAPIError? deserializedError = null;
                try
                {
                    deserializedError =
                        JsonSerializer.Deserialize<ShipEngineAPIError>(contentString, JsonSerializerOptions);
                }
                catch (JsonException)
                {
                }

                // Throw Generic HttpClient Error if unable to deserialize to a ShipEngineException
                if (deserializedError == null)
                {
                    response.EnsureSuccessStatusCode();
                }

                var error = deserializedError?.Errors[0];

                if (error != null && error.Message != null && deserializedError?.RequestId != null)
                {
                    throw new ShipEngineException(
                        error.Message,
                        error.ErrorSource,
                        error.ErrorType,
                        error.ErrorCode,
                        deserializedError.RequestId,
                        response
                    );
                }

            }

            var result = JsonSerializer.Deserialize<T>(contentString, JsonSerializerOptions);

            if (result != null)
            {
                return result;
            }

            throw new ShipEngineException(message: "Unexpected Error");
        }


        /// <summary>
        /// Builds and sends an HTTP Request to the ShipEngine Client, has special logic for handling
        /// 429 rate limit exceeded errors and subsequent retry logic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="path"></param>
        /// <param name="jsonContent"></param>
        /// <param name="client"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public virtual async Task<T> SendHttpRequestAsync<T>(HttpMethod method, string path, string? jsonContent, HttpClient client, Config config)
        {
            int retry = 0;

            HttpResponseMessage? response = null;
            ShipEngineException requestException;
            while (true)
            {
                try
                {
                    var request = BuildRequest(method, path, jsonContent);
                    var streamTask = client.SendAsync(request, CancellationToken);
                    response = await streamTask;

                    var deserializedResult = await DeserializedResultOrThrow<T>(response);

                    return deserializedResult;
                }
                catch (ShipEngineException e)
                {
                    if (e.ErrorCode != ErrorCode.RateLimitExceeded)
                    {
                        throw e;
                    }

                    requestException = e;
                }

                catch (Exception e)
                {
                    throw e;
                }


                if (!ShouldRetry(retry, response?.StatusCode, response?.Headers, config))
                {
                    break;
                }

                retry += 1;
                await WaitAndRetry(response, config, requestException);
            }

            if (requestException != null)
            {
                throw requestException;
            }
            else
            {
                throw new ShipEngineException(message: "Unexpected Error");
            }
        }

        private async Task WaitAndRetry(HttpResponseMessage? response, Config config, ShipEngineException ex)
        {
            int? retryAfter;

            try
            {
                retryAfter = Int32.Parse(response?.Headers.GetValues("RetryAfter").First());
            }
            catch
            {
                retryAfter = 5;
            }

            if (config.Timeout.Seconds < retryAfter)
            {
                throw new ShipEngineException(
                    $"The request took longer than the {config.Timeout.Milliseconds} milliseconds allowed",
                    ErrorSource.Shipengine,
                    ErrorType.System,
                    ErrorCode.Timeout,
                    ex.RequestId,
                    ex.ResponseMessage
                );
            }

            await Task.Delay((int)retryAfter * 1000, CancellationToken).ConfigureAwait(false);
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string path, string? jsonContent)
        {
            var request = new HttpRequestMessage(method, path);

            if (jsonContent != null)
            {
                request.Content = new StringContent(jsonContent, System.Text.Encoding.UTF8, JsonMediaType);
            }

            return request;
        }

        private static bool ShouldRetry(
            int numRetries,
            HttpStatusCode? statusCode,
            HttpHeaders? headers,
            Config config)
        {
            // Do not retry if we are out of retries.
            if (numRetries >= config.Retries)
            {
                return false;
            }

            if (statusCode == (HttpStatusCode)429 || headers != null && headers.Contains("RetryAfter"))
            {
                return true;
            }

            return false;
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ShipEngineSDK.Common;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngineClient
    {

        protected readonly JsonSerializerSettings JsonSerializerSettings;

        public ShipEngineClient()
        {
            JsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };
        }

        private const string JsonMediaType = "application/json";
        public static HttpClient ConfigureHttpClient(Config config, HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            // TODO: Add SDK version/OS/and other metadata here.
            client.DefaultRequestHeaders.Add("User-Agent", "User-Agent-goes-here");
            client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", JsonMediaType);

            client.BaseAddress = new Uri("https://api.shipengine.com");

            client.Timeout = config.Timeout;

            return client;
        }

        private async Task<T> DeserializedResultOrThrow<T>(HttpResponseMessage response)
        {

            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var deserializedError = JsonConvert.DeserializeObject<ShipEngineAPIError>(contentString, JsonSerializerSettings);

                // Throw Generic HttpClient Error if unable to deserialize to a ShipEngineException
                if (deserializedError == null)
                {
                    response.EnsureSuccessStatusCode();
                }

                var error = deserializedError.Errors[0];

                if (error != null && error.Message != null && error.ErrorSource != null && error.ErrorType != null && error.ErrorCode != null && deserializedError.RequestId != null)
                {
                    throw new ShipEngineException(error.Message, (ErrorSource)error.ErrorSource, (ErrorType)error.ErrorType, (ErrorCode)error.ErrorCode, deserializedError.RequestId);
                }

            }

            var result = JsonConvert.DeserializeObject<T>(contentString, JsonSerializerSettings);

            // var result = JsonSerializer.Deserialize<T>(contentString);
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

            HttpResponseMessage response = null;
            ShipEngineException requestException;
            while (true)
            {
                try
                {
                    var request = BuildRequest(method, path, jsonContent);
                    var streamTask = client.SendAsync(request);
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

        private async Task WaitAndRetry(HttpResponseMessage response, Config config, ShipEngineException ex)
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
                    ex.RequestId
                );
            }

            await Task.Delay((int)retryAfter * 1000).ConfigureAwait(false);
        }

        private HttpRequestMessage BuildRequest(HttpMethod method, string path, string? jsonContent)
        {
            var request = new HttpRequestMessage(method, path);

            if (jsonContent != null)
            {
                request.Content = new StringContent(jsonContent, System.Text.Encoding.UTF8, JsonMediaType);
            }

            return request;
        }

        private bool ShouldRetry(
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
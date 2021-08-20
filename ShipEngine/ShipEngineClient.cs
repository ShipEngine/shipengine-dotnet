using ShipEngineSDK.Common;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public class ShipEngineClient
    {
        public static HttpClient ConfigureHttpClient(Config config, HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            // TODO: Add SDK version/OS/and other metadata here.
            client.DefaultRequestHeaders.Add("User-Agent", "User-Agent-goes-here");
            client.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            client.BaseAddress = new Uri("https://api.shipengine.com");

            client.Timeout = config.Timeout;

            return client;
        }

        private async Task<T> DeserializedResultOrThrow<T>(HttpResponseMessage response)
        {

            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var deserializedError = JsonSerializer.Deserialize<ShipEngineAPIError>(contentString);

                // Throw Generic HttpClient Error if unable to deserialize to a ShipEngineException
                if (deserializedError == null)
                {
                    response.EnsureSuccessStatusCode();
                }

                var error = deserializedError.Errors[0];

                if (error != null && error.Message != null && error.ErrorSource != null && error.ErrorType != null && error.ErrorCode != null && deserializedError.RequestId != null)
                {
                    throw new ShipEngineException(error.Message, error.ErrorSource, error.ErrorType, error.ErrorCode, deserializedError.RequestId);
                }

            }
            var result = JsonSerializer.Deserialize<T>(contentString);
            if (result != null)
            {
                return result;
            }

            throw new ShipEngineException(message: "Unexpected Error");
        }

        public virtual async Task<T> SendHttpRequestAsync<T>(HttpMethod method, string path, string? jsonContent, HttpClient client, Config config)
        {
            int retry = 0;

            HttpResponseMessage response = null;
            Exception requestException;
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


                if (!ShouldRetry(retry, response?.StatusCode, response?.Headers, config.Retries))
                {
                    break;
                }

                retry += 1;
                await WaitAndRetry(response);
            }

            // If max retries have been met throw
            if (requestException != null)
            {
                throw requestException;
            }
            else
            {
                throw new ShipEngineException(message: "Unexpected Error");
            }
        }

        // On a 429 response,
        private async Task WaitAndRetry(HttpResponseMessage response)
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

            await Task.Delay((int)retryAfter * 1000).ConfigureAwait(false);
        }

        private HttpRequestMessage BuildRequest(HttpMethod method, string path, string? jsonContent)
        {
            var request = new HttpRequestMessage(method, path);

            if (jsonContent != null)
            {
                request.Content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
            }

            return request;
        }

        private bool ShouldRetry(
            int numRetries,
            HttpStatusCode? statusCode,
            HttpHeaders? headers,
            int maxRetries)
        {
            // Do not retry if we are out of retries.
            if (numRetries >= maxRetries)
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
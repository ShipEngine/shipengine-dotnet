using ShipEngineSDK.Common;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShipEngineSDK
{
    public static class ShipEngineClient
    {
        public static HttpClient ConfigureHttpClient(ShipEngineConfig config, HttpClient client)
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


        public static async Task<T> SendHttpRequestAsync<T>(HttpRequestMessage request, HttpClient client)
        {
            try
            {
                var streamTask = client.SendAsync(request);
                var response = await streamTask;

                var deserializedResult = await DeserializedResultOrThrow<T>(response);

                return deserializedResult;
            }
            // TODO: Is there a better way to do error handling?
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task<T> DeserializedResultOrThrow<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var contentString = await response.Content.ReadAsStringAsync();
                var deserializedError = JsonSerializer.Deserialize<ShipEngineAPIError>(contentString);

                // Throw Generic HttpClient Error if unable to deserialize to a ShipEngineException
                if (deserializedError == null)
                {
                    response.EnsureSuccessStatusCode();
                }

                var error = deserializedError.Errors[0];

                if (error != null)
                {
                    throw new ShipEngineException(error.Message, error.ErrorSource, error.ErrorType, error.ErrorCode, deserializedError.RequestId);
                }

            }
            else
            {
                var contentString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<T>(contentString);
                if (result != null)
                {
                    return result;
                }
            }

            throw new ShipEngineException(message: "Unexpected Error");
        }
    }
}
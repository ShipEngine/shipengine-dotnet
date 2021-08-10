using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ShipEngineSDK
{
    public static class ShipEngineClient
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
                var deserializedError = JsonSerializer.Deserialize<ShipEngineException>(contentString);
                // Throw Generic HttpClient Error if unable to deserialize to a ShipEngineException
                if (deserializedError == null)
                {
                    response.EnsureSuccessStatusCode();
                }
                throw new ShipEngineException(deserializedError.RequestId, deserializedError.Errors);
            }
            else
            {
                var contentString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<T>(contentString);
                return result;
            }
        }
    }
}

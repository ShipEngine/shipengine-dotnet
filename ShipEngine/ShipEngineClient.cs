using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ShipEngineSDK
{
    public class ShipEngineClient
    {
        public HttpClient _httpClient;

        public ShipEngineConfig _config;

        public ShipEngineClient(string ApiKey)
        {
            ConfigureHttpClient(new ShipEngineConfig(ApiKey));
        }

        public ShipEngineClient(ShipEngineConfig config)
        {
            ConfigureHttpClient(config);
        }

        private void ConfigureHttpClient(ShipEngineConfig config)
        {
            _httpClient = new HttpClient();
            _config = config;

            _httpClient.DefaultRequestHeaders.Accept.Clear();

            // TODO: Add SDK version/OS/and other metadata here.
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "User-Agent-goes-here");
            _httpClient.DefaultRequestHeaders.Add("Api-Key", config.ApiKey);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            _httpClient.BaseAddress = new Uri("https://api.shipengine.com");

            _httpClient.Timeout = config.Timeout;
        }


        public async Task<T> SendHttpRequestAsync<T>(HttpRequestMessage request)
        {
            try
            {
                var streamTask = _httpClient.SendAsync(request);
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

        private async Task<T> DeserializedResultOrThrow<T>(HttpResponseMessage response)
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

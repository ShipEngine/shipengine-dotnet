using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ShipEngineSDK
{
    public class ShipEngineClient
    {
        private readonly HttpClient _httpClient;
       
        public ShipEngineClient(string apiKey, HttpClient httpClient = null)
        {

            if (httpClient == null)
            {
                _httpClient = new HttpClient();
            }
            else
            {
                _httpClient = httpClient;
            }

            _httpClient.DefaultRequestHeaders.Accept.Clear();

            // TODO: Add SDK version/OS/and other metadata here.
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "User-Agent-goes-here");
            _httpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            _httpClient.BaseAddress = new Uri("https://api.shipengine.com");
        }

        public async Task<T> PostHttpRequest<T>(string url, string jsonBody)
        {

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    // Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json")
                };

                var streamTask = this._httpClient.SendAsync(request);
                var response = await streamTask;

                var deserializedResult = await DeserializedResultOrThrow<T>(response);

                return deserializedResult;
            }
            // TODO: Is there a better way to do error handling?
            catch (HttpRequestException e)
            {
                throw e;
            }
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
                var deserializeError = JsonSerializer.Deserialize<ShipEngineException>(contentString);
                throw new ShipEngineException(deserializeError.RequestId, deserializeError.Errors);
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

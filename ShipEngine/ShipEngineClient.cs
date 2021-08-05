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
                    Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json")
                };

                var streamTask = this._httpClient.SendAsync(request);
                var result = await streamTask;

                result.EnsureSuccessStatusCode();

                var contentString = await result.Content.ReadAsStringAsync();
                var deserializedResult = await JsonSerializer.DeserializeAsync<T>(await result.Content.ReadAsStreamAsync());

                return deserializedResult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
    }
}

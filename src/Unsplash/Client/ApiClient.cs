using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unsplash.Client
{
    public abstract class ApiClient
    {
        public ApiClient(string baseUrl, string accessKey)
        {
            BaseUrl = baseUrl;
            AccessKey = accessKey;

            Client = new HttpClient()
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }

        public string BaseUrl { get; }
        public string AccessKey { get; }

        public HttpClient Client { get; }

        protected async Task<T> GetAsync<T>(
            string requestUri,
            IDictionary<string, string> headers = null,
            JsonSerializerSettings serializerSettings = null,
            CancellationToken cancellationToken = default)
        {
            var response = await SendAsync(requestUri, headers, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                return await ParseStreamAsync<T>(response, serializerSettings);
            }

            var message = !string.IsNullOrWhiteSpace(response.ReasonPhrase)
                    ? response.ReasonPhrase
                    : await response.Content.ReadAsStringAsync();

            throw new ApiException(response.StatusCode, message);
        }

        private async  Task<T> ParseStreamAsync<T>(HttpResponseMessage response, JsonSerializerSettings serializerSettings)
        {
            using (Stream stream = await response.Content.ReadAsStreamAsync())
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    using (JsonReader jsonReader = new JsonTextReader(streamReader))
                    {
                        var serializer = JsonSerializer.Create(serializerSettings);
                        return serializer.Deserialize<T>(jsonReader);
                    }
                }
            }
        }

        private async Task<HttpResponseMessage> SendAsync(
            string requestUri,
            IDictionary<string, string> headers = null,
            CancellationToken cancellationToken = default)
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);
            httpRequest.Headers.Add("Authorization", $"Client-ID {AccessKey}");

            if (headers != null)
            {
                AddHeaders(httpRequest, headers);
            }

            return await Client.SendAsync(httpRequest, cancellationToken);
        }

        private static void AddHeaders(HttpRequestMessage request, IDictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unsplash
{
    public abstract class ApiClient
    {
        private ClientOptions _options;

        public ApiClient(ClientOptions options)
        {
            options = MergeOptions(options);

            Client = new HttpClient()
            {
                BaseAddress = new Uri(options.BaseUrl)
            };

            _options = options;
        }

        private static ClientOptions MergeOptions(ClientOptions options)
        {
            return new ClientOptions
            {
                BaseUrl = options.BaseUrl ?? Constants.BASE_URL,
                AccessKey = options.AccessKey,
                ApiVersion = options.ApiVersion ?? Constants.API_VERSION
            };
        }

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

        private async Task<T> ParseStreamAsync<T>(HttpResponseMessage response, JsonSerializerSettings serializerSettings)
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
            httpRequest.Headers.Add("Authorization", $"Client-ID {_options.AccessKey}");
            httpRequest.Headers.Add("Accept-Version", _options.ApiVersion);

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

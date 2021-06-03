using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Unsplash;
using Unsplash.Api;
using Unsplash.Models;
using WireMock.Matchers;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Tests
{
    public class PhotosApiTests : IDisposable
    {
        private readonly WireMockServer _server;
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };

        private const string ACCESS_KEY = "Token";

        public PhotosApiTests()
        {
            _server = WireMockServer.Start();
        }

        [Fact]
        public async Task GetPhoto()
        {
            var photoId = "AWMNB_buDlQ";
            var photoData = JsonConvert.DeserializeObject<Photo.Full>(await File.ReadAllTextAsync("data/photos/GetPhotoResponse.json"));
            var jsonData = JsonConvert.SerializeObject(photoData, JsonSerializerSettings);

            _server.Given(CreateGetRequestBuilder(PhotosApiUrls.GetPhoto(photoId)))
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photo = await client.GetPhotoAsync(photoId);

            var actual = JsonConvert.SerializeObject(photo, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetPhotos()
        {
            var photosData = JsonConvert.DeserializeObject<IEnumerable<Photo.Full>>(await File.ReadAllTextAsync("data/photos/GetPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(photosData, JsonSerializerSettings);

            _server.Given(CreateGetRequestBuilder("/photos"))
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photos = await client.GetPhotosAsync(FilterOptions.Default);

            var actual = JsonConvert.SerializeObject(photos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetPhotoStatistics()
        {
            // This is hack 🙈
            var photosData = JsonConvert.DeserializeObject<Photo.Stats>(await File.ReadAllTextAsync("data/photos/GetPhotoStatistics.json"));
            var jsonData = JsonConvert.SerializeObject(photosData, JsonSerializerSettings);

            var photoId = "pduutGbL2-M";

            _server.Given(CreateGetRequestBuilder(PhotosApiUrls.GetPhotoStatistics(photoId)))
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photos = await client.GetPhotoStatisticsAsync(photoId);

            var actual = JsonConvert.SerializeObject(photos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetRandomPhotos()
        {
            var photosData = JsonConvert.DeserializeObject<IEnumerable<Photo.Random>>(await File.ReadAllTextAsync("data/photos/GetRandomPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(photosData, JsonSerializerSettings);

            _server.Given(CreateGetRequestBuilder("/photos/random"))
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photos = await client.GetRandomPhotosAsync();

            var actual = JsonConvert.SerializeObject(photos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task TrackPhoto()
        {
            var jsonData = "{\r\n  \"url\": \"https://images.unsplash.com/photo-1593642702909-dec73df255d7?ixlib=rb-1.2.1&q=85&fm=jpg&crop=entropy&cs=srgb\"\r\n}";
            var data = JsonConvert.DeserializeObject<Photo.TrackPhotoDownload>(jsonData);
            jsonData = JsonConvert.SerializeObject(data, JsonSerializerSettings);


            var photoId = "TxXuh_hAFd8";

            _server.Given(CreateGetRequestBuilder(PhotosApiUrls.TrackPhotoDownload(photoId)))
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photos = await client.TrackPhotoDownload(photoId);

            var actual = JsonConvert.SerializeObject(photos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        private static IRequestBuilder CreateGetRequestBuilder(string path)
        {
            return Request.Create()
                    .WithPath(path)
                    .UsingGet()
                    .WithHeader("Authorization", $"Client-ID {ACCESS_KEY}", MatchBehaviour.AcceptOnMatch)
                    .WithHeader("Accept-Version", Constants.API_VERSION, MatchBehaviour.AcceptOnMatch);
        }

        public void Dispose()
        {
            _server.Stop();
            _server.Dispose();
        }
    }
}

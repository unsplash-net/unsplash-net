using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Api.Photos;
using Unsplash.Models;
using WireMock.Matchers;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Unsplash.Tests
{
    public class PhotosApiTests : IDisposable
    {
        private readonly WireMockServer _server;
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            DateParseHandling = DateParseHandling.DateTimeOffset,
            Formatting = Formatting.Indented
        };

        private const string BASE_URL = "http://localhost:3000/";
        private const string ACCESS_KEY = "Token";

        public PhotosApiTests()
        {
            _server = WireMockServer.Start(BASE_URL);
        }

        [Fact]
        public async Task GetPhoto()
        {
            var photoId = "AWMNB_buDlQ";
            var photoData = JsonConvert.DeserializeObject<PhotoFull>(await File.ReadAllTextAsync("GetPhotoResponse.json"));
            var jsonData = JsonConvert.SerializeObject(photoData, JsonSerializerSettings);

            _server.Given(
                    Request.Create()
                    .WithPath(PhotosApiUrls.GetPhoto(photoId))
                    .UsingGet()
                    .WithHeader("Authorization", $"Client-ID {ACCESS_KEY}", MatchBehaviour.AcceptOnMatch)
                ).RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(BASE_URL, ACCESS_KEY);
            
            var photo = await client.GetPhotoAsync(photoId);

            var actual = JsonConvert.SerializeObject(photo, JsonSerializerSettings);
            
            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetPhotos()
        {
            var photosData = JsonConvert.DeserializeObject<IEnumerable<PhotoFull>>(await File.ReadAllTextAsync("GetPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(photosData, JsonSerializerSettings);

            _server.Given(
                    Request.Create()
                    .WithPath("/photos")
                    .UsingGet()
                    .WithHeader("Authorization", $"Client-ID {ACCESS_KEY}", MatchBehaviour.AcceptOnMatch)
                ).RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(BASE_URL, ACCESS_KEY);

            var photos = await client.GetPhotosAsync(FilterOptions.Default);

            var actual = JsonConvert.SerializeObject(photos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        public void Dispose()
        {
            _server.Stop();
            _server.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Api.Collections;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Unsplash.Tests
{
    public class CollectionsApiTests : IDisposable
    {
        private readonly WireMockServer _server;
        private const string ACCESS_KEY = "Token";

        public CollectionsApiTests()
        {
            _server = WireMockServer.Start();
        }

        [Fact]
        public async Task ListCollections()
        {
            var collectionsData = JsonConvert.DeserializeObject<IEnumerable<CollectionBasic>>(await File.ReadAllTextAsync("data/collections/ListCollectionsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(collectionsData);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(
                    CollectionsApiUrls.List(),
                    ACCESS_KEY,
                    Constants.API_VERSION
                )
            ).RespondWith(
                Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
            );

            var client = new CollectionsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var response = await client.ListAsync();

            var responseJson = JsonConvert.SerializeObject(response);

            Assert.Equal(jsonData, responseJson);
        }

        [Fact]
        public async Task GetConnection()
        {
            var collectionData = JsonConvert.DeserializeObject<CollectionBasic>(await File.ReadAllTextAsync("data/collections/GetCollectionResponse.json"));
            var jsonData = JsonConvert.SerializeObject(collectionData);

            string collectionId = "542632";

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(
                    CollectionsApiUrls.GetCollection(collectionId),
                    ACCESS_KEY,
                    Constants.API_VERSION
                )
            ).RespondWith(
                Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
            );

            var client = new CollectionsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var response = await client.GetCollectionAsync(collectionId);

            var responseJson = JsonConvert.SerializeObject(response);

            Assert.Equal(jsonData, responseJson);
        }

        [Fact]
        public async Task GetConnectionPhotos()
        {
            var collectionPhotosData = JsonConvert.DeserializeObject<IEnumerable<PhotoBasic>>(await File.ReadAllTextAsync("data/collections/GetCollectionPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(collectionPhotosData);

            string collectionId = "542632";

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(
                    CollectionsApiUrls.GetCollectionPhotos(collectionId),
                    ACCESS_KEY,
                    Constants.API_VERSION
                )
            ).RespondWith(
                Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
            );

            var client = new CollectionsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var response = await client.GetCollectionPhotosAsync(collectionId);

            var responseJson = JsonConvert.SerializeObject(response);

            Assert.Equal(jsonData, responseJson);
        }

        [Fact]
        public async Task GetRelatedCollections()
        {
            var relatedCollectionsData = JsonConvert.DeserializeObject<IEnumerable<CollectionBasic>>(await File.ReadAllTextAsync("data/collections/GetRelatedCollectionsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(relatedCollectionsData);

            string collectionId = "542632";

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(
                    CollectionsApiUrls.GetRelatedCollections(collectionId),
                    ACCESS_KEY,
                    Constants.API_VERSION
                )
            ).RespondWith(
                Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
            );

            var client = new CollectionsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var response = await client.GetRelatedCollectionsAsync(collectionId);

            var responseJson = JsonConvert.SerializeObject(response);

            Assert.Equal(jsonData, responseJson);
        }

        public void Dispose()
        {
            _server.Stop();
            _server.Dispose();
        }
    }
}

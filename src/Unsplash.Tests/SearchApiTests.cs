using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Unsplash.Api;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Tests
{
    public class SearchApiTests
    {
        private readonly WireMockServer _server;
        private const string ACCESS_KEY = "Token";

        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };

        public SearchApiTests()
        {
            _server = WireMockServer.Start();
        }

        [Fact]
        public async Task SearchPhotos()
        {
            var paginatedPhotosListData = JsonConvert.DeserializeObject<PaginatedList<Photo.Basic>>(await File.ReadAllTextAsync("data/search/SearchPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(paginatedPhotosListData, JsonSerializerSettings);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(SearchApiUrls.Photos(), ACCESS_KEY, Constants.API_VERSION)
                )
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            ISearchApi client = new SearchApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var query = "data";
            var paginatedPhotosList = await client.PhotosAsync(query);

            var actual = JsonConvert.SerializeObject(paginatedPhotosList, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task SearchCollections()
        {
            var paginatedCollectionsListData = JsonConvert.DeserializeObject<PaginatedList<Collection.Basic>>(await File.ReadAllTextAsync("data/search/SearchCollectionsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(paginatedCollectionsListData, JsonSerializerSettings);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(SearchApiUrls.Collections(), ACCESS_KEY, Constants.API_VERSION)
                )
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            ISearchApi client = new SearchApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var query = "data";
            var paginatedCollectionsList = await client.CollectionsAsync(query);

            var actual = JsonConvert.SerializeObject(paginatedCollectionsList, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task SearchUsers()
        {
            var paginatedUsersListData = JsonConvert.DeserializeObject<PaginatedList<User.Medium>>(await File.ReadAllTextAsync("data/search/SearchUsersResponse.json"));
            var jsonData = JsonConvert.SerializeObject(paginatedUsersListData, JsonSerializerSettings);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(SearchApiUrls.Users(), ACCESS_KEY, Constants.API_VERSION)
                )
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            ISearchApi client = new SearchApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var query = "data";
            var paginatedUsersList = await client.UsersAsync(query);

            var actual = JsonConvert.SerializeObject(paginatedUsersList, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }
    }
}

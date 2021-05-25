using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using Unsplash.Api.Search;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

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
            var paginatedPhotosListData = JsonConvert.DeserializeObject<PaginatedList<PhotoBasic>>(await File.ReadAllTextAsync("data/search/SearchPhotosResponse.json"));
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
    }
}

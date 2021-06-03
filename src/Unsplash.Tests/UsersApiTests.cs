using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Api.Users;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using Xunit;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Tests
{
    public class UsersApiTests : ApiTestBase
    {
        [Fact]
        public async Task GetUserPublicProfile()
        {
            var profileData = JsonConvert.DeserializeObject<User.Full>(await File.ReadAllTextAsync("data/users/GetUserPublicProfileResponse.json"));
            var jsonData = JsonConvert.SerializeObject(profileData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetPublicProfile(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var publicProfile = await client.GetPublicProfileAsync(username);

            var actual = JsonConvert.SerializeObject(publicProfile, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetUserPortfolioLink()
        {
            var portfolioLinkData = JsonConvert.DeserializeObject<User.PortfolioLink>(await File.ReadAllTextAsync("data/users/GetUserPortfolioLinkResponse.json"));
            var jsonData = JsonConvert.SerializeObject(portfolioLinkData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetPortfolioLink(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var portfolioLink = await client.GetPortfolioLinkAsync(username);

            var actual = JsonConvert.SerializeObject(portfolioLink, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetUserPhotos()
        {
            var fileData = await File.ReadAllTextAsync("data/users/GetUserPhotosResponse.json");
            var userPhotosData = JsonConvert.DeserializeObject<IEnumerable<Photo.Basic>>(fileData);
            var jsonData = JsonConvert.SerializeObject(userPhotosData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetPhotos(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var userPhotos = await client.GetPhotosAsync(username);

            var actual = JsonConvert.SerializeObject(userPhotos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetUserLikedPhotos()
        {
            var fileData = await File.ReadAllTextAsync("data/users/GetUserLikedPhotosResponse.json");
            var userLikedPhotosData = JsonConvert.DeserializeObject<IEnumerable<Photo.Basic>>(fileData);
            var jsonData = JsonConvert.SerializeObject(userLikedPhotosData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetLikedPhotos(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var userLikedPhotos = await client.GetLikedPhotosAsync(username);

            var actual = JsonConvert.SerializeObject(userLikedPhotos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetUserCollections()
        {
            var fileData = await File.ReadAllTextAsync("data/users/GetUserCollectionsResponse.json");
            var userCollectionsData = JsonConvert.DeserializeObject<IEnumerable<Collection.Basic>>(fileData);
            var jsonData = JsonConvert.SerializeObject(userCollectionsData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetCollections(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var userCollections = await client.GetCollectionsAsync(username);

            var actual = JsonConvert.SerializeObject(userCollections, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetUserStatistics()
        {
            var fileData = await File.ReadAllTextAsync("data/users/GetUserStatistics.json");
            var userStatisticsData = JsonConvert.DeserializeObject<UserStatistics>(fileData);
            var jsonData = JsonConvert.SerializeObject(userStatisticsData, JsonSerializerSettings);

            var username = "amyjoyhumphries";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(UsersApiUrls.GetStatistics(username), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new UsersApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var userStatistics = await client.GetUserStatisticsAsync(username);

            var actual = JsonConvert.SerializeObject(userStatistics, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }
    }
}

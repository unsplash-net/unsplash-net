﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Unsplash.Api.Users;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using Xunit;

namespace Unsplash.Tests
{
    public class UsersApiTests : ApiTestBase
    {
        [Fact]
        public async Task GetUserPublicProfile()
        {
            var profileData = JsonConvert.DeserializeObject<UserFull>(await File.ReadAllTextAsync("data/users/GetUserPublicProfileResponse.json"));
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
            var portfolioLinkData = JsonConvert.DeserializeObject<UrlLinkResponse>(await File.ReadAllTextAsync("data/users/GetUserPortfolioLinkResponse.json"));
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
            var userPhotosData = JsonConvert.DeserializeObject<IEnumerable<PhotoBasic>>(fileData);
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
            var userLikedPhotosData = JsonConvert.DeserializeObject<IEnumerable<PhotoBasic>>(fileData);
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
    }
}

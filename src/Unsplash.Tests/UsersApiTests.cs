using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Unsplash.Api.Users;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Unsplash.Tests
{
    public class ApiTestBase : IDisposable
    {
        protected readonly WireMockServer Server;

        protected static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Newtonsoft.Json.Formatting.Indented,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };

        protected const string ACCESS_KEY = "Token";

        protected ApiTestBase()
        {
            Server = WireMockServer.Start();
        }

        public void Dispose()
        {
            Server.Stop();
            Server.Dispose();
        }
    }

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
    }
}

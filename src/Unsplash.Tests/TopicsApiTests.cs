using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;
using Unsplash.Client;
using WireMock.ResponseBuilders;
using Unsplash.Api.Topics;

namespace Unsplash.Tests
{
    public class TopicsApiTests : ApiTestBase
    {
        [Fact]
        public async Task ListTopics()
        {
            var profileData = JsonConvert.DeserializeObject<IEnumerable<Topic.Basic>>(await File.ReadAllTextAsync("data/topics/ListTopicsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(profileData, JsonSerializerSettings);

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(TopicsApiUrls.List(), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new TopicsApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var topics = await client.ListAsync();

            var actual = JsonConvert.SerializeObject(topics, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }
    }
}
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Unsplash.Api.Topics;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using Xunit;
using static Unsplash.Api.ApiEndpoints;

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

        [Fact]
        public async Task GetTopic()
        {
            var topicData = JsonConvert.DeserializeObject<Topic.Full>(await File.ReadAllTextAsync("data/topics/GetTopicResponse.json"));
            var jsonData = JsonConvert.SerializeObject(topicData, JsonSerializerSettings);

            var topicIdOrSlug = "941OMZGZvvA";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(TopicsApiUrls.Get(topicIdOrSlug), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new TopicsApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var topic = await client.GetAsync(topicIdOrSlug);

            var actual = JsonConvert.SerializeObject(topic, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetTopicPhotos()
        {
            var topicPhotosData = JsonConvert.DeserializeObject<IEnumerable<PhotoBasic>>(await File.ReadAllTextAsync("data/topics/GetTopicPhotosResponse.json"));
            var jsonData = JsonConvert.SerializeObject(topicPhotosData, JsonSerializerSettings);

            var topicIdOrSlug = "941OMZGZvvA";

            Server.Given(
                WireMockHelpers.CreateGetRequestBuilder(TopicsApiUrls.GetPhotos(topicIdOrSlug), ACCESS_KEY, Constants.API_VERSION)
            ).RespondWith(
                Response.Create().WithStatusCode(200).WithBody(jsonData)
            );

            var client = new TopicsApi(new ApiClientOptions
            {
                BaseUrl = Server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var topicPhotos = await client.GetPhotosAsync(topicIdOrSlug);

            var actual = JsonConvert.SerializeObject(topicPhotos, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }
    }
}
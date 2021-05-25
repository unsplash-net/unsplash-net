using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Threading.Tasks;
using Unsplash.Api.Stats;
using Unsplash.Client;
using Unsplash.Models;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Unsplash.Tests
{
    public class StatsApiTests : IDisposable
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

        public StatsApiTests()
        {
            _server = WireMockServer.Start();
        }

        [Fact]
        public async Task GetTotals()
        {
            var totalsData = JsonConvert.DeserializeObject<StatsTotals>(await File.ReadAllTextAsync("GetStatsTotalsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(totalsData, JsonSerializerSettings);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(StatsApiUrls.Totals(), ACCESS_KEY, Constants.API_VERSION)
                )
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new StatsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var photo = await client.GetTotalsAsync();

            var actual = JsonConvert.SerializeObject(photo, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        [Fact]
        public async Task GetPastMonthStats()
        {
            var pastMonthStats = JsonConvert.DeserializeObject<PastMonthStats>(await File.ReadAllTextAsync("GetPastMonthStatsResponse.json"));
            var jsonData = JsonConvert.SerializeObject(pastMonthStats, JsonSerializerSettings);

            _server.Given(
                WireMockHelpers.CreateGetRequestBuilder(StatsApiUrls.PastMonthStats(), ACCESS_KEY, Constants.API_VERSION)
                )
                .RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new StatsApi(new ApiClientOptions
            {
                BaseUrl = _server.Urls[0],
                AccessKey = ACCESS_KEY
            });

            var data = await client.GetPastMonthStatsAsync();

            var actual = JsonConvert.SerializeObject(data, JsonSerializerSettings);

            Assert.Equal(jsonData, actual);
        }

        public void Dispose()
        {
            _server.Stop();
            _server.Dispose();
        }
    }
}

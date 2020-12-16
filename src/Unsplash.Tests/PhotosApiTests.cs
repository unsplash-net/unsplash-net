using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using Unsplash.Api;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Unsplash.Tests
{
    public class PhotosApiTests
    {
        private readonly WireMockServer _server;
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            DateParseHandling = DateParseHandling.DateTimeOffset,
            Formatting = Formatting.Indented
        };

        private const string BASE_URL = "http://localhost:3000/";
        private const string ACCESS_KEY_URL = "AccessKey";

        public PhotosApiTests()
        {
            _server = WireMockServer.Start(BASE_URL);
        }

        [Fact]
        public async Task GetPhoto()
        {
            var photoId = "AWMNB_buDlQ";
            var jsonData = await File.ReadAllTextAsync("GetPhotoResponse.json");

            _server.Given(
                    Request.Create()
                    .WithPath(PhotosApiUrls.GetPhoto(photoId))
                    .UsingGet()
                ).RespondWith(
                    Response.Create()
                    .WithStatusCode(200)
                    .WithBody(jsonData)
                );

            var client = new PhotosApi(BASE_URL, ACCESS_KEY_URL);
            
            var photo = await client.GetPhotoAsync(photoId);

            var actual = JsonConvert.SerializeObject(photo, JsonSerializerSettings);
            
            Assert.Equal(jsonData, actual);
        }
    }
}

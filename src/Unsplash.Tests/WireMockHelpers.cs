using WireMock.Matchers;
using WireMock.RequestBuilders;

namespace Unsplash.Tests
{
    internal static class WireMockHelpers
    {
        internal static IRequestBuilder CreateGetRequestBuilder(string path, string accessKey, string apiVersion)
        {
            return Request.Create()
                    .WithPath(path)
                    .UsingGet()
                    .WithHeader("Authorization", $"Client-ID {accessKey}", MatchBehaviour.AcceptOnMatch)
                    .WithHeader("Accept-Version", apiVersion, MatchBehaviour.AcceptOnMatch);
        }
    }
}

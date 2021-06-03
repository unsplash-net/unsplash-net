namespace Unsplash.Api
{
    public static class ApiEndpoints
    {
        public static class TopicsApiUrls
        {
            public static string List() => "/topics";

            public static string Get(string topicIdOrSlug) => $"/topics/{topicIdOrSlug}";
        }
    }
}
namespace Unsplash.Api.Users
{
    public static class UsersApiUrls
    {
        public static string GetPublicProfile(string username) => $"/users/{username}";

        public static string GetPortfolioLink(string username) => $"/users/{username}/portfolio";

        public static string GetPhotos(string username) => $"/users/{username}/photos";

        public static string GetLikedPhotos(string username) => $"/users/{username}/likes";

        public static string GetCollections(string username) => $"/users/{username}/collections";

        public static string GetStatistics(string username) => $"/users/{username}/statistics";
    }
}

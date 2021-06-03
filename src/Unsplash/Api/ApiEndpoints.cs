using System.Collections.Generic;
using Unsplash.Api;
using Unsplash.Extensions;

namespace Unsplash.Api
{
    public static class ApiEndpoints
    {
        public static class TopicsApiUrls
        {
            public static string List() => "/topics";

            public static string Get(string topicIdOrSlug) => $"/topics/{topicIdOrSlug}";

            public static string GetPhotos(string topicIdOrSlug) => $"/topics/{topicIdOrSlug}/photos";
        }

        public static class CollectionsApiUrls
        {
            public static string List() => "/collections";

            public static string GetCollection(string collectionId) => $"/collections/{collectionId}";

            public static string GetCollectionPhotos(string collectionId) => $"/collections/{collectionId}/photos";

            public static string GetRelatedCollections(string collectionId) => $"/collections/{collectionId}/related";
        }

        internal static class PhotosApiUrls
        {
            public static string GetPhoto(string photoId) => $"/photos/{photoId}";

            public static string GetPhotos(FilterOptions options)
            {
                var parameters = new Dictionary<string, string>
            {
                { "page", options.Page.ToString() },
                { "per_page", options.PerPage.ToString() },
                { "order_by", options.OrderBy.GetEnumMemberAttrValue() }
            };

                return $"/photos?{UrlHelper.CreateQueryString(parameters)}";
            }

            public static string GetPhotoStatistics(string photoId) => $"/photos/{photoId}/statistics";

            public static string GetRandomPhoto(RandomPhotoFilterOptions options)
            {
                var parameters = new Dictionary<string, string>
            {
                { "collections", options.Collections },
                { "topics", options.Topics },
                { "username", options.Username },
                { "query", options.Query },
                { "orientation", options.Orientation?.GetEnumMemberAttrValue() },
                { "content_filter", options.ContentFilter?.GetEnumMemberAttrValue() },
                { "count", options.Count.ToString() }
            };

                return $"/photos/random?{UrlHelper.CreateQueryString(parameters)}";
            }

            public static string TrackPhotoDownload(string photoId) => $"/photos/{photoId}/download";
        }

        public static class SearchApiUrls
        {
            public static string Photos() => "/search/photos";

            public static string Collections() => "/search/collections";

            public static string Users() => "/search/users";
        }

        public static class StatsApiUrls
        {
            public static string Totals() => "/stats/total";

            public static string PastMonthStats() => "/stats/month";
        }

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
}

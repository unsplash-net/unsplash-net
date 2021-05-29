using System.Collections.Generic;
using Unsplash.Extensions;

namespace Unsplash.Api.Photos
{
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
}

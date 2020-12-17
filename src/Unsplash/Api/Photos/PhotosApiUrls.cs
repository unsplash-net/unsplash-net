using System.Collections.Generic;
using Unsplash.Extensions;

namespace Unsplash.Api.Photos
{
    internal static class PhotosApiUrls
    {
        public static string GetPhoto(string id) => $"/photos/{id}";

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
    }
}

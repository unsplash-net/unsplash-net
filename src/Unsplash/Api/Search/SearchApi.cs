using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Extensions;
using Unsplash.Models;

namespace Unsplash.Api.Search
{
    public class SearchApi : ApiClient, ISearchApi
    {
        public SearchApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<PaginatedList<PhotoBasic>> PhotosAsync(string query, SearchPhotosParams parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            if (parameters == null)
            {
                parameters = new SearchPhotosParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "query", query },
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() },
                { "order_by", parameters.OrderBy?.GetEnumMemberAttrValue() },
                { "collections", parameters.Collections },
                { "content_filter", parameters.ContentFilter?.GetEnumMemberAttrValue() },
                { "color", parameters.Color?.GetEnumMemberAttrValue() },
                { "orientation", parameters.Orientation?.GetEnumMemberAttrValue() },
            };

            var url = $"{SearchApiUrls.Photos()}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<PaginatedList<PhotoBasic>>(url);
        }

        public async Task<PaginatedList<CollectionBasic>> CollectionsAsync(string query, SearchCollectionsParams parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            if (parameters == null)
            {
                parameters = new SearchCollectionsParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "query", query },
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() }
            };

            var url = $"{SearchApiUrls.Collections()}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<PaginatedList<CollectionBasic>>(url);
        }
    }
}

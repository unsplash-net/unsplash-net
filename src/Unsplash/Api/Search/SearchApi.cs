﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Extensions;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api
{
    public class SearchApi : ApiClient, ISearchApi
    {
        public SearchApi(ClientOptions options) : base(options)
        {
        }

        public async Task<PaginatedList<Photo.Basic>> PhotosAsync(string query, SearchPhotosParams parameters = null)
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

            return await GetAsync<PaginatedList<Photo.Basic>>(url);
        }

        public async Task<PaginatedList<Collection.Basic>> CollectionsAsync(string query, SearchCollectionsParams parameters = null)
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

            return await GetAsync<PaginatedList<Collection.Basic>>(url);
        }

        public async Task<PaginatedList<User.Medium>> UsersAsync(string query, SearchUsersParams parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            if (parameters == null)
            {
                parameters = new SearchUsersParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "query", query },
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() }
            };

            var url = $"{SearchApiUrls.Users()}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<PaginatedList<User.Medium>>(url);
        }
    }
}

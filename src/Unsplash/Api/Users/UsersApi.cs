﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;
using Unsplash.Extensions;

namespace Unsplash.Api.Users
{
    public interface IUsersApi
    {
        Task<UserFull> GetPublicProfileAsync(string username);
        Task<UrlLinkResponse> GetPortfolioLinkAsync(string username);
        Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string username, GetUserPhotosParams parameters = null);
        Task<IEnumerable<PhotoBasic>> GetLikedPhotosAsync(string username, GetUserLikedPhotosParams parameters = null);
    }

    public static class UsersApiUrls
    {
        public static string GetPublicProfile(string username) => $"/users/{username}";

        public static string GetPortfolioLink(string username) => $"/users/{username}/portfolio";

        public static string GetPhotos(string username) => $"/users/{username}/photos";

        public static string GetLikedPhotos(string username) => $"/users/{username}/likes";
    }

    public class UsersApi : ApiClient, IUsersApi
    {
        public UsersApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<UserFull> GetPublicProfileAsync(string username)
        {
            var url = UsersApiUrls.GetPublicProfile(username);

            return await GetAsync<UserFull>(url);
        }

        public async Task<UrlLinkResponse> GetPortfolioLinkAsync(string username)
        {
            var url = UsersApiUrls.GetPortfolioLink(username);

            return await GetAsync<UrlLinkResponse>(url);
        }

        public async Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string username, GetUserPhotosParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = new GetUserPhotosParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() },
                { "order_by", parameters.OrderBy?.GetEnumMemberAttrValue() },
                { "stats", parameters.Stats?.ToString() },
                { "resolution", parameters.Resolution?.ToString() },
                { "quantity", parameters.Quantity?.ToString() },
                { "orientation", parameters.Orientation?.ToString() }
            };

            var url = $"{UsersApiUrls.GetPhotos(username)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<PhotoBasic>>(url);
        }

        public async Task<IEnumerable<PhotoBasic>> GetLikedPhotosAsync(string username, GetUserLikedPhotosParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = new GetUserLikedPhotosParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() },
                { "order_by", parameters.OrderBy?.GetEnumMemberAttrValue() },
                { "orientation", parameters.Orientation?.ToString() }
            };

            var url = $"{UsersApiUrls.GetLikedPhotos(username)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<PhotoBasic>>(url);
        }
    }
}

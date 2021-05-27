using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Users
{
    public interface IUsersApi
    {
        Task<UserFull> GetPublicProfileAsync(string username);
        Task<UrlLinkResponse> GetPortfolioLinkAsync(string username);
    }

    public static class UsersApiUrls
    {
        public static string GetPublicProfile(string username) => $"/users/{username}";

        public static string GetPortfolioLink(string username) => $"/users/{username}/portfolio";
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
    }
}

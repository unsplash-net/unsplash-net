using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Api.Photos;
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
    }

    public class GetUserPhotosParams
    {
        public int? Page { get; }

        public GetUserPhotosParams(
            int? page = null,
            int? perPage = null,
            UserPhotoOrderBy? orderBy = null,
            bool? stats = null,
            string resolution = null,
            int? quantity = null,
            Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            OrderBy = orderBy;
            Stats = stats;
            Resolution = resolution;
            Quantity = quantity;
            Orientation = orientation;
        }

        public int? PerPage { get; }
        public UserPhotoOrderBy? OrderBy { get; }
        public bool? Stats { get; }
        public string Resolution { get; }
        public int? Quantity { get; }
        public Orientation? Orientation { get; set; }
    }

    public enum UserPhotoOrderBy
    {
        [EnumMember(Value = "latest")]
        Latest,

        [EnumMember(Value = "oldest")]
        Oldest,

        [EnumMember(Value = "popular")]
        Popular,

        [EnumMember(Value = "views")]
        Views,

        [EnumMember(Value = "downloads")]
        Downloads,
    }

    public static class UsersApiUrls
    {
        public static string GetPublicProfile(string username) => $"/users/{username}";

        public static string GetPortfolioLink(string username) => $"/users/{username}/portfolio";

        public static string GetPhotos(string username) => $"/users/{username}/photos";
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
    }
}

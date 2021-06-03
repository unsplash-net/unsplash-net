using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Extensions;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api
{
    public class UsersApi : ApiClient, IUsersApi
    {
        public UsersApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<User.Full> GetPublicProfileAsync(string username)
        {
            var url = UsersApiUrls.GetPublicProfile(username);

            return await GetAsync<User.Full>(url);
        }

        public async Task<User.PortfolioLink> GetPortfolioLinkAsync(string username)
        {
            var url = UsersApiUrls.GetPortfolioLink(username);

            return await GetAsync<User.PortfolioLink>(url);
        }

        public async Task<IEnumerable<Photo.Basic>> GetPhotosAsync(string username, GetUserPhotosParams parameters = null)
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

            return await GetAsync<IEnumerable<Photo.Basic>>(url);
        }

        public async Task<IEnumerable<Photo.Basic>> GetLikedPhotosAsync(string username, GetUserLikedPhotosParams parameters = null)
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

            return await GetAsync<IEnumerable<Photo.Basic>>(url);
        }

        public async Task<IEnumerable<Collection.Basic>> GetCollectionsAsync(string username, PaginationParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = new PaginationParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() }
            };

            var url = $"{UsersApiUrls.GetCollections(username)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<Collection.Basic>>(url);
        }

        public async Task<UserStatistics> GetUserStatisticsAsync(string username, UserStatisticsParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = new UserStatisticsParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "resolution", parameters.Resolution?.ToString() },
                { "quantity", parameters.Quantity?.ToString() }
            };

            var url = $"{UsersApiUrls.GetStatistics(username)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<UserStatistics>(url);
        }
    }
}

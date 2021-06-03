using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Users
{
    public interface IUsersApi
    {
        Task<UserFull> GetPublicProfileAsync(string username);
        Task<UrlLinkResponse> GetPortfolioLinkAsync(string username);
        Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string username, GetUserPhotosParams parameters = null);
        Task<IEnumerable<PhotoBasic>> GetLikedPhotosAsync(string username, GetUserLikedPhotosParams parameters = null);
        Task<IEnumerable<Collection.Basic>> GetCollectionsAsync(string username, PaginationParams parameters = null);
        Task<UserStatistics> GetUserStatisticsAsync(string username, UserStatisticsParams parameters = null);
    }
}

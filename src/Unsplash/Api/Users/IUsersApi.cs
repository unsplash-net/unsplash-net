using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Users
{
    public interface IUsersApi
    {
        Task<User.Full> GetPublicProfileAsync(string username);
        Task<UrlLinkResponse> GetPortfolioLinkAsync(string username);
        Task<IEnumerable<Photo.Basic>> GetPhotosAsync(string username, GetUserPhotosParams parameters = null);
        Task<IEnumerable<Photo.Basic>> GetLikedPhotosAsync(string username, GetUserLikedPhotosParams parameters = null);
        Task<IEnumerable<Collection.Basic>> GetCollectionsAsync(string username, PaginationParams parameters = null);
        Task<UserStatistics> GetUserStatisticsAsync(string username, UserStatisticsParams parameters = null);
    }
}

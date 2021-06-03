using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api
{
    public interface ISearchApi
    {
        Task<PaginatedList<Photo.Basic>> PhotosAsync(string query, SearchPhotosParams parameters = null);
        Task<PaginatedList<Collection.Basic>> CollectionsAsync(string query, SearchCollectionsParams parameters = null);
        Task<PaginatedList<User.Medium>> UsersAsync(string query, SearchUsersParams parameters = null);
    }
}

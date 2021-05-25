using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Search
{
    public interface ISearchApi
    {
        Task<PaginatedList<PhotoBasic>> PhotosAsync(string query, SearchPhotosParams parameters = null);
        Task<PaginatedList<CollectionBasic>> CollectionsAsync(string query, SearchCollectionsParams parameters = null);
    }
}

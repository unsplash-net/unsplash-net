using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Collections
{
    public interface ICollectionsApi
    {
        Task<IEnumerable<Collection.Basic>> ListAsync(ListCollectionsParams parameters = null);
        Task<Collection.Basic> GetCollectionAsync(string collectionId);
        Task<IEnumerable<PhotoBasic>> GetCollectionPhotosAsync(string collectionId, GetCollectionPhotosParams parameters = null);
        Task<IEnumerable<Collection.Basic>> GetRelatedCollectionsAsync(string collectionId);
    }
}

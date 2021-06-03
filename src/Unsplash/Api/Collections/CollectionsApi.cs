using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash;
using Unsplash.Extensions;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api
{
    public class CollectionsApi : ApiClient, ICollectionsApi
    {
        public CollectionsApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<IEnumerable<Collection.Basic>> ListAsync(ListCollectionsParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = ListCollectionsParams.Default;
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() }
            };

            var url = $"{CollectionsApiUrls.List()}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<Collection.Basic>>(url);
        }

        public async Task<Collection.Basic> GetCollectionAsync(string collectionId)
        {
            var url = CollectionsApiUrls.GetCollection(collectionId);

            return await GetAsync<Collection.Basic>(url);
        }

        public async Task<IEnumerable<Photo.Basic>> GetCollectionPhotosAsync(string collectionId, GetCollectionPhotosParams parameters = null)
        {
            if (parameters == null)
            {
                parameters = new GetCollectionPhotosParams();
            }

            var queryParams = new Dictionary<string, string>()
            {
                { "page", parameters.Page?.ToString() },
                { "per_page", parameters.PerPage?.ToString() },
                { "orientation", parameters.Orientation?.GetEnumMemberAttrValue() }
            };

            var url = $"{CollectionsApiUrls.GetCollectionPhotos(collectionId)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<Photo.Basic>>(url);
        }

        public async Task<IEnumerable<Collection.Basic>> GetRelatedCollectionsAsync(string collectionId)
        {
            var url = CollectionsApiUrls.GetRelatedCollections(collectionId);

            return await GetAsync<IEnumerable<Collection.Basic>>(url);
        }
    }
}

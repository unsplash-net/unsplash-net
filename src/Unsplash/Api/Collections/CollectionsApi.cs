using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Extensions;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api.Collections
{
    public class CollectionsApi : ApiClient, ICollectionsApi
    {
        public CollectionsApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<IEnumerable<CollectionBasic>> ListAsync(ListCollectionsParams parameters = null)
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

            return await GetAsync<IEnumerable<CollectionBasic>>(url);
        }

        public async Task<CollectionBasic> GetCollectionAsync(string collectionId)
        {
            var url = CollectionsApiUrls.GetCollection(collectionId);

            return await GetAsync<CollectionBasic>(url);
        }

        public async Task<IEnumerable<PhotoBasic>> GetCollectionPhotosAsync(string collectionId, GetCollectionPhotosParams parameters = null)
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

            return await GetAsync<IEnumerable<PhotoBasic>>(url);
        }

        public async Task<IEnumerable<CollectionBasic>> GetRelatedCollectionsAsync(string collectionId)
        {
            var url = CollectionsApiUrls.GetRelatedCollections(collectionId);

            return await GetAsync<IEnumerable<CollectionBasic>>(url);
        }
    }
}

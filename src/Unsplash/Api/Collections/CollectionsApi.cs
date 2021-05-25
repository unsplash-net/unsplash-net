using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Collections
{
    public interface ICollectionsApi
    {
        Task<IEnumerable<CollectionBasic>> ListAsync(ListCollectionsParams parameters = null);
        Task<CollectionBasic> GetCollectionAsync(string collectionId);
    }

    public static class CollectionsApiUrls
    {
        public static string List() => "/collections";

        public static string GetCollection(string collectionId) => $"/collections/{collectionId}";
    }

    public class ListCollectionsParams
    {
        public ListCollectionsParams(int? page, int? perPage)
        {
            Page = page;
            PerPage = perPage;
        }

        public static ListCollectionsParams Default => new ListCollectionsParams(1, 10);

        public int? Page { get; }
        public int? PerPage { get; }
    }

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
    }
}

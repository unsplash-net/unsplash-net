using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Api.Photos;
using Unsplash.Client;
using Unsplash.Models;
using Unsplash.Extensions;

namespace Unsplash.Api.Collections
{
    public interface ICollectionsApi
    {
        Task<IEnumerable<CollectionBasic>> ListAsync(ListCollectionsParams parameters = null);
        Task<CollectionBasic> GetCollectionAsync(string collectionId);
        Task<IEnumerable<PhotoBasic>> GetCollectionPhotosAsync(string collectionId, GetCollectionPhotosParams parameters = null);
    }

    public static class CollectionsApiUrls
    {
        public static string List() => "/collections";

        public static string GetCollection(string collectionId) => $"/collections/{collectionId}";

        public static string GetCollectionPhotos(string collectionId) => $"/collections/{collectionId}/photos";
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

    public class GetCollectionPhotosParams
    {
        public GetCollectionPhotosParams(int? page = null, int? perPage = null, Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            Orientation = orientation;
        }

        public int? Page { get; }
        public int? PerPage { get; }
        public Orientation? Orientation { get; }
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
    }
}

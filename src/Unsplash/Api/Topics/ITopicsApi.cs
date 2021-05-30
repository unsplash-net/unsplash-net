using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;
using Unsplash.Extensions;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api.Topics
{
    public interface ITopicsApi
    {
        Task<IEnumerable<Topic.Basic>> ListAsync(ListTopicsParams listTopicsParams = null);
    }

    public class ListTopicsParams
    {
        public string Id { get; set; }
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public TopicOrderBy? OrderBy { get; set; }

        public enum TopicOrderBy
        {
            [EnumMember(Value = "featured")]
            Featured,

            [EnumMember(Value = "latest")]
            Latest,

            [EnumMember(Value = "oldest")]
            Oldest,

            [EnumMember(Value = "position")]
            Position
        }
    }

    public class TopicsApi : ApiClient, ITopicsApi
    {
        public TopicsApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<IEnumerable<Topic.Basic>> ListAsync(ListTopicsParams listTopicsParams = null)
        {
            var queryParams = new Dictionary<string, string>
            {
                { "page", listTopicsParams?.Page?.ToString() },
                { "per_page", listTopicsParams?.PerPage?.ToString() },
                { "id", listTopicsParams?.Id?.ToString() },
                { "order_by", listTopicsParams?.OrderBy?.GetEnumMemberAttrValue() }
            };

            var url = $"{TopicsApiUrls.List()}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<Topic.Basic>>(url);
        }
    }
}
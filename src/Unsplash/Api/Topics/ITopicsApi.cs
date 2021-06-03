using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Unsplash.Api.Photos;
using Unsplash.Client;
using Unsplash.Extensions;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api.Topics
{
    public interface ITopicsApi
    {
        Task<IEnumerable<Topic.Basic>> ListAsync(ListTopicsParams listTopicsParams = null);
        Task<Topic.Full> GetAsync(string topicIdOrSlug);
        Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string topicIdOrSlug, GetTopicPhotosParams getTopicPhotosParams = null);
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

    public class GetTopicPhotosParams
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public Orientation? Orientation { get; set; }
        public PhotoOrderBy? OrderBy { get; set; }
    }

    public class TopicsApi : ApiClient, ITopicsApi
    {
        public TopicsApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<Topic.Full> GetAsync(string topicIdOrSlug)
        {
            if (string.IsNullOrWhiteSpace(topicIdOrSlug))
            {
                throw new ArgumentNullException(nameof(topicIdOrSlug));
            }

            var url = TopicsApiUrls.Get(topicIdOrSlug);

            return await GetAsync<Topic.Full>(url);
        }

        public async Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string topicIdOrSlug, GetTopicPhotosParams getTopicPhotosParams = null)
        {
            if (string.IsNullOrWhiteSpace(topicIdOrSlug))
            {
                throw new ArgumentNullException(nameof(topicIdOrSlug));
            }

            var queryParams = new Dictionary<string, string>
            {
                { "page", getTopicPhotosParams?.Page?.ToString() },
                { "per_page", getTopicPhotosParams?.PerPage?.ToString() },
                { "orientation", getTopicPhotosParams?.Orientation?.ToString() },
                { "order_by", getTopicPhotosParams?.OrderBy?.GetEnumMemberAttrValue() }
            };

            var url = $"{TopicsApiUrls.GetPhotos(topicIdOrSlug)}?{UrlHelper.CreateQueryString(queryParams)}";

            return await GetAsync<IEnumerable<PhotoBasic>>(url);
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
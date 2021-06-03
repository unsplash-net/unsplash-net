using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Topics
{
    public interface ITopicsApi
    {
        Task<IEnumerable<Topic.Basic>> ListAsync(ListTopicsParams listTopicsParams = null);
        Task<Topic.Full> GetAsync(string topicIdOrSlug);
        Task<IEnumerable<PhotoBasic>> GetPhotosAsync(string topicIdOrSlug, GetTopicPhotosParams getTopicPhotosParams = null);
    }
}
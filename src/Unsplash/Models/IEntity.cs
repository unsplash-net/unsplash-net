using Newtonsoft.Json;

namespace Unsplash.Models
{
    public interface IEntity
    {
        [JsonProperty("id")]
        string Id { get; set; }
    }
}

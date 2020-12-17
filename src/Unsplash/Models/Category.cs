
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Category
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }
}

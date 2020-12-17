
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class UserLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }
}

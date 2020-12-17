
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class ResultLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }
}

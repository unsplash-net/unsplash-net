
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Tag
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }
}

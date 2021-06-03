using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class UrlLinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

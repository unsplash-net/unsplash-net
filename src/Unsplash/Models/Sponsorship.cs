
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Unsplash.Models
{
    public class Sponsorship
    {
        [JsonProperty("impression_urls")]
        public List<string> ImpressionUrls { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("tagline_url")]
        public string TaglineUrl { get; set; }

        [JsonProperty("sponsor")]
        public Sponsor Sponsor { get; set; }
    }
}

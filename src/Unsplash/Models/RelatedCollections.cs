
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Unsplash.Models
{
    public class RelatedCollections
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }
}

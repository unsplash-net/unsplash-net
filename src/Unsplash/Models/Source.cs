
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Source
    {
        [JsonProperty("ancestry")]
        public Ancestry Ancestry { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("cover_photo")]
        public CoverPhoto CoverPhoto { get; set; }
    }
}

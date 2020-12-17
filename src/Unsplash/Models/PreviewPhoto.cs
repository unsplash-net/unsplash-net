
using Newtonsoft.Json;
using System;

namespace Unsplash.Models
{
    public class PreviewPhoto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("blur_hash")]
        public string BlurHash { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }
    }
}

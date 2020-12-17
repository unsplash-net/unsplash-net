
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Unsplash.Models
{
    public class Result
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("last_collected_at")]
        public DateTimeOffset LastCollectedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("curated")]
        public bool Curated { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("share_key")]
        public string ShareKey { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("links")]
        public ResultLinks Links { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("cover_photo")]
        public CoverPhoto CoverPhoto { get; set; }

        [JsonProperty("preview_photos")]
        public List<PreviewPhoto> PreviewPhotos { get; set; }
    }
}

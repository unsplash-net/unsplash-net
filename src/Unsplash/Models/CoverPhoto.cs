
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Unsplash.Models
{
    public class CoverPhoto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTimeOffset? PromotedAt { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("blur_hash")]
        public string BlurHash { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("links")]
        public PhotoLinks Links { get; set; }

        [JsonProperty("categories")]
        public List<object> Categories { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("liked_by_user")]
        public bool LikedByUser { get; set; }

        [JsonProperty("current_user_collections")]
        public List<object> CurrentUserCollections { get; set; }

        [JsonProperty("sponsorship")]
        public object Sponsorship { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}

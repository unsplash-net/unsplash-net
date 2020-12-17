
using Newtonsoft.Json;
using System;

namespace Unsplash.Models
{
    public class Sponsor
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public object LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage ProfileImage { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("total_collections")]
        public int TotalCollections { get; set; }

        [JsonProperty("total_likes")]
        public int TotalLikes { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }

        [JsonProperty("accepted_tos")]
        public bool AcceptedTos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public interface IUserLinks
    {
        [JsonProperty("self")]
        string Self { get; set; }

        [JsonProperty("html")]
        string Html { get; set; }

        [JsonProperty("photos")]
        string Photos { get; set; }

        [JsonProperty("likes")]
        string Likes { get; set; }

        [JsonProperty("portfolio")]
        string Portfolio { get; set; }

        [JsonProperty("following")]
        string Following { get; set; }

        [JsonProperty("followers")]
        string Followers { get; set; }
    }

    public class UserLinks : IUserLinks
    {
        public string Self { get; set; }
        public string Html { get; set; }
        public string Photos { get; set; }
        public string Likes { get; set; }
        public string Portfolio { get; set; }
        public string Following { get; set; }
        public string Followers { get; set; }
    }

    public interface IProfileImage
    {
        [JsonProperty("small")]
        string Small { get; set; }

        [JsonProperty("medium")]
        string Medium { get; set; }

        [JsonProperty("large")]
        string Large { get; set; }
    }

    public class ProfileImage : IProfileImage
    {
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
    }

    public interface IUserBasic : IEntity
    {
        [JsonProperty("bio")]
        string Bio { get; set; }

        [JsonProperty("first_name")]
        string FirstName { get; set; }

        [JsonProperty("instagram_username")]
        string InstagramUsername { get; set; }

        [JsonProperty("last_name")]
        string LastName { get; set; }

        [JsonProperty("links")]
        UserLinks Links { get; set; }

        [JsonProperty("location")]
        string Location { get; set; }

        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("portfolio_url")]
        string PortfolioUrl { get; set; }

        [JsonProperty("profile_image")]
        ProfileImage ProfileImage { get; set; }

        [JsonProperty("total_collections")]
        int TotalCollections { get; set; }

        [JsonProperty("total_likes")]
        int TotalLikes { get; set; }

        [JsonProperty("total_photos")]
        int TotalPhotos { get; set; }

        [JsonProperty("twitter_username")]
        string TwitterUsername { get; set; }

        [JsonProperty("updated_at")]
        DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        string Username { get; set; }

    }

    public class UserBasic : IUserBasic
    {
        public string Bio { get; set; }
        public string FirstName { get; set; }
        public string InstagramUsername { get; set; }
        public string LastName { get; set; }
        public UserLinks Links { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string PortfolioUrl { get; set; }
        public ProfileImage ProfileImage { get; set; }
        public int TotalCollections { get; set; }
        public int TotalLikes { get; set; }
        public int TotalPhotos { get; set; }
        public string TwitterUsername { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string Username { get; set; }
        public string Id { get; set; }
    }

    public interface IUserMedium : IUserBasic
    {
        [JsonProperty("photos")]
        IEnumerable<PhotoVeryBasic> Photos { get; set; }
    }

    public class UserMedium : IUserMedium
    {
        public IEnumerable<PhotoVeryBasic> Photos { get; set; }
        public string Bio { get; set; }
        public string FirstName { get; set; }
        public string InstagramUsername { get; set; }
        public string LastName { get; set; }
        public UserLinks Links { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string PortfolioUrl { get; set; }
        public ProfileImage ProfileImage { get; set; }
        public int TotalCollections { get; set; }
        public int TotalLikes { get; set; }
        public int TotalPhotos { get; set; }
        public string TwitterUsername { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string Username { get; set; }
        public string Id { get; set; }
    }

    public interface IUserFull : IUserMedium
    {
        [JsonProperty("downloads")]
        int Downloads { get; set; }

        [JsonProperty("followers_count")]
        int FollowersCount { get; set; }

        [JsonProperty("following_count")]
        int FollowingCount { get; set; }
    }

    public class UserFull : UserMedium, IUserFull
    {
        public int Downloads { get; set; }
        public int FollowersCount { get; set; }
        public int FollowingCount { get; set; }
    }

    public class UrlLinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

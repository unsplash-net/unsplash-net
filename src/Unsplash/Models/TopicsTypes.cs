using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Unsplash.Models
{
    public static class Topic
    {
        public class Links
        {
            [JsonProperty("self")]
            public string Self { get; set; }

            [JsonProperty("html")]
            public string Html { get; set; }

            [JsonProperty("photos")]
            public string Photos { get; set; }
        }

        public enum Status
        {
            [EnumMember(Value = "open")]
            Open,

            [EnumMember(Value = "closed")]
            Closed
        }

        public interface ITopicBasic : IEntity
        {
            [JsonProperty("cover_photo")]
            Photo.Basic CoverPhoto { get; set; }

            [JsonProperty("current_user_contributions")]
            IEnumerable<Photo.VeryBasic> CurrentUserContributions { get; set; }

            [JsonProperty("description")]
            string Description { get; set; }

            [JsonProperty("ends_at")]
            string EndsAt { get; set; }

            [JsonProperty("featured")]
            bool IsFeatured { get; set; }

            [JsonProperty("links")]
            Links Links { get; set; }

            [JsonProperty("owners")]
            IEnumerable<User.Basic> Owners { get; set; }

            [JsonProperty("preview_photos")]
            IEnumerable<Photo.VeryBasic> PreviewPhotos { get; set; }

            [JsonProperty("published_at")]
            string PublishedAt { get; set; }

            [JsonProperty("starts_at")]
            string StartsAt { get; set; }

            [JsonProperty("status")]
            [JsonConverter(typeof(StringEnumConverter))]
            Status Status { get; set; }

            [JsonProperty("slug")]
            string Slug { get; set; }

            [JsonProperty("title")]
            string Title { get; set; }

            [JsonProperty("total_photos")]
            long TotalPhotos { get; set; }

            [JsonProperty("updated_at")]
            string UpdatedAt { get; set; }
        }

        public interface ITopicFull : ITopicBasic
        {
            [JsonProperty("top_contributors")]
            IEnumerable<User.Basic> TopContributors { get; set; }
        }

        public class Basic : ITopicBasic
        {
            public Photo.Basic CoverPhoto { get; set; }
            public IEnumerable<Photo.VeryBasic> CurrentUserContributions { get; set; }
            public string Description { get; set; }
            public string EndsAt { get; set; }
            public bool IsFeatured { get; set; }
            public Links Links { get; set; }
            public IEnumerable<User.Basic> Owners { get; set; }
            public IEnumerable<Photo.VeryBasic> PreviewPhotos { get; set; }
            public string PublishedAt { get; set; }
            public string StartsAt { get; set; }
            public Status Status { get; set; }
            public string Slug { get; set; }
            public string Title { get; set; }
            public long TotalPhotos { get; set; }
            public string UpdatedAt { get; set; }
            public string Id { get; set; }
        }

        public class Full : ITopicFull
        {
            public IEnumerable<User.Basic> TopContributors { get; set; }
            public Photo.Basic CoverPhoto { get; set; }
            public IEnumerable<Photo.VeryBasic> CurrentUserContributions { get; set; }
            public string Description { get; set; }
            public string EndsAt { get; set; }
            public bool IsFeatured { get; set; }
            public Links Links { get; set; }
            public IEnumerable<User.Basic> Owners { get; set; }
            public IEnumerable<Photo.VeryBasic> PreviewPhotos { get; set; }
            public string PublishedAt { get; set; }
            public string StartsAt { get; set; }
            public Status Status { get; set; }
            public string Slug { get; set; }
            public string Title { get; set; }
            public long TotalPhotos { get; set; }
            public string UpdatedAt { get; set; }
            public string Id { get; set; }
        }
    }
}

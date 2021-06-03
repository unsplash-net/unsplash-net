using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public static class Collection
    {
        public interface ICollectionBasic : IEntity
        {
            [JsonProperty("cover_photo")]
            PhotoBasic CoverPhoto { get; set; }

            [JsonProperty("description")]
            string Description { get; set; }

            [JsonProperty("featured")]
            bool Featured { get; set; }

            [JsonProperty("last_collected_at")]
            DateTimeOffset LastCollectedAt { get; set; }


            [JsonProperty("links")]
            Links Links { get; set; }

            [JsonProperty("preview_photos")]
            List<PhotoVeryBasic> PreviewPhotos { get; set; }


            [JsonProperty("published_at")]
            DateTimeOffset PublishedAt { get; set; }


            [JsonProperty("title")]
            string Title { get; set; }


            [JsonProperty("total_photos")]
            int TotalPhotos { get; set; }

            [JsonProperty("updated_at")]
            DateTimeOffset UpdatedAt { get; set; }


            [JsonProperty("user")]
            UserBasic User { get; set; }

        }

        public class Basic : ICollectionBasic
        {
            public PhotoBasic CoverPhoto { get; set; }
            public string Description { get; set; }
            public bool Featured { get; set; }
            public DateTimeOffset LastCollectedAt { get; set; }
            public Links Links { get; set; }
            public List<PhotoVeryBasic> PreviewPhotos { get; set; }
            public DateTimeOffset PublishedAt { get; set; }
            public string Title { get; set; }
            public int TotalPhotos { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public UserBasic User { get; set; }
            public string Id { get; set; }
        }


        public interface ICollectionLinks
        {
            [JsonProperty("self")]
            string Self { get; set; }

            [JsonProperty("html")]
            string Html { get; set; }

            [JsonProperty("photos")]
            string Photos { get; set; }

            [JsonProperty("download")]
            string Download { get; set; }

            [JsonProperty("related")]
            string Related { get; set; }
        }

        public class Links : ICollectionLinks
        {
            public string Self { get; set; }
            public string Html { get; set; }
            public string Photos { get; set; }
            public string Download { get; set; }
            public string Related { get; set; }
        }
    }
}

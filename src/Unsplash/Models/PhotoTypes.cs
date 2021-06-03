using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Unsplash.Models
{
    public static class Photo
    {
        public class Stat
        {
            public double Total { get; set; }
            public Historical Historical { get; set; }
        }

        public class Historical
        {
            [JsonProperty("change")]
            public double Change { get; set; }

            [JsonProperty("quantity")]
            public double Quantity { get; set; }

            public string Resolution { get; set; }

            public List<StateValue> Values { get; set; }
        }

        public class Stats : IEntity
        {
            [JsonProperty("views")]
            public Stat Views { get; set; }

            [JsonProperty("downloads")]
            public Stat Downloads { get; set; }

            public string Id { get; set; }
        }

        public interface IUrls
        {
            [JsonProperty("raw")]
            string Raw { get; set; }

            [JsonProperty("full")]
            string Full { get; set; }

            [JsonProperty("regular")]
            string Regular { get; set; }

            [JsonProperty("small")]
            string Small { get; set; }

            [JsonProperty("thumb")]
            string Thumb { get; set; }
        }

        public class Urls : IUrls
        {
            public string Raw { get; set; }
            public string Full { get; set; }
            public string Regular { get; set; }
            public string Small { get; set; }
            public string Thumb { get; set; }
        }

        public interface IVeryBasic : IEntity
        {
            [JsonProperty("created_at")]
            DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("blur_hash")]
            string BlurHash { get; set; }

            [JsonProperty("urls")]
            Urls Urls { get; set; }
        }

        public class VeryBasic : IVeryBasic
        {
            public DateTimeOffset CreatedAt { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public Urls Urls { get; set; }
            public string Id { get; set; }
            public string BlurHash { get; set; }
        }

        public interface ILinks
        {
            [JsonProperty("self")]
            string Self { get; set; }

            [JsonProperty("html")]
            string Html { get; set; }

            [JsonProperty("download")]
            string Download { get; set; }

            [JsonProperty("download_location")]
            string DownloadLocation { get; set; }
        }

        public class Links : ILinks
        {
            public string Self { get; set; }
            public string Html { get; set; }
            public string Download { get; set; }
            public string DownloadLocation { get; set; }
        }

        public interface IBasic : IVeryBasic
        {
            [JsonProperty("alt_description")]
            string AltDescription { get; set; }

            [JsonProperty("color")]
            string Color { get; set; }

            [JsonProperty("description")]
            string Description { get; set; }

            [JsonProperty("height")]
            int Height { get; set; }

            [JsonProperty("likes")]
            int Likes { get; set; }

            [JsonProperty("links")]
            Links Links { get; set; }

            [JsonProperty("promoted_at")]
            DateTimeOffset? PromotedAt { get; set; }

            [JsonProperty("width")]
            int Width { get; set; }

            [JsonProperty("user")]
            User.Basic User { get; set; }
        }

        public class Basic : IBasic
        {
            public string AltDescription { get; set; }
            public string BlurHash { get; set; }
            public string Color { get; set; }
            public string Description { get; set; }
            public int Height { get; set; }
            public int Likes { get; set; }
            public Links Links { get; set; }
            public DateTimeOffset? PromotedAt { get; set; }
            public int Width { get; set; }
            public User.Basic User { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public Urls Urls { get; set; }
            public string Id { get; set; }
        }

        public interface IExif
        {
            [JsonProperty("make")]
            string Make { get; set; }

            [JsonProperty("model")]
            string Model { get; set; }

            [JsonProperty("exposure_time")]
            string ExposureTime { get; set; }

            [JsonProperty("aperture")]
            string Aperture { get; set; }

            [JsonProperty("focal_length")]
            string FocalLength { get; set; }

            [JsonProperty("iso")]
            int Iso { get; set; }
        }

        public class Exif : IExif
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string ExposureTime { get; set; }
            public string Aperture { get; set; }
            public string FocalLength { get; set; }
            public int Iso { get; set; }
        }

        public interface ILocation
        {
            [JsonProperty("name")]
            string Name { get; set; }

            [JsonProperty("city")]
            string City { get; set; }

            [JsonProperty("country")]
            string Country { get; set; }

            [JsonProperty("position")]
            Position Position { get; set; }
        }

        public class Location : ILocation
        {
            public string Name { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public Position Position { get; set; }
        }

        public interface IPosition
        {
            [JsonProperty("latitude")]
            double? Latitude { get; set; }

            [JsonProperty("longitude")]
            double? Longitude { get; set; }
        }

        public class Position : IPosition
        {
            public double? Latitude { get; set; }
            public double? Longitude { get; set; }
        }

        public interface IExifAdnLocation
        {
            [JsonProperty("exif")]
            Exif Exif { get; set; }

            [JsonProperty("location")]
            Location Location { get; set; }
        }

        public interface IRandom : IBasic, IExifAdnLocation
        {
        }

        public class Random : IRandom
        {
            public string AltDescription { get; set; }
            public string Color { get; set; }
            public string Description { get; set; }
            public int Height { get; set; }
            public int Likes { get; set; }
            public Links Links { get; set; }
            public DateTimeOffset? PromotedAt { get; set; }
            public int Width { get; set; }
            public User.Basic User { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public string BlurHash { get; set; }
            public Urls Urls { get; set; }
            public string Id { get; set; }
            public Exif Exif { get; set; }
            public Location Location { get; set; }
        }


        public enum RelatedCollectionType
        {
            [EnumMember(Value = "related")]
            Related,

            [EnumMember(Value = "collected")]
            Collected
        }

        public interface IRelatedCollections
        {
            [JsonProperty("total")]
            int Total { get; set; }

            [JsonProperty("type")]
            [JsonConverter(typeof(StringEnumConverter))]
            RelatedCollectionType Type { get; set; }

            [JsonProperty("results")]
            List<Collection.Basic> Results { get; set; }
        }

        public class RelatedCollections : IRelatedCollections
        {
            public int Total { get; set; }
            public RelatedCollectionType Type { get; set; }
            public List<Collection.Basic> Results { get; set; }
        }

        public interface IFull : IBasic, IExifAdnLocation
        {
            [JsonProperty("related_collections")]
            RelatedCollections RelatedCollections { get; set; }
        }

        public class Full : IFull
        {
            public RelatedCollections RelatedCollections { get; set; }
            public string AltDescription { get; set; }
            public string BlurHash { get; set; }
            public string Color { get; set; }
            public string Description { get; set; }
            public int Height { get; set; }
            public int Likes { get; set; }
            public Links Links { get; set; }
            public DateTimeOffset? PromotedAt { get; set; }
            public int Width { get; set; }
            public User.Basic User { get; set; }
            public DateTimeOffset CreatedAt { get; set; }
            public DateTimeOffset UpdatedAt { get; set; }
            public Urls Urls { get; set; }
            public string Id { get; set; }
            public Exif Exif { get; set; }
            public Location Location { get; set; }
        }

        public class TrackPhotoDownload
        {
            public string Url { get; set; }
        }
    }
}

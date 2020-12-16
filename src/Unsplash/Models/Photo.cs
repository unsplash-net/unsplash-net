
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unsplash.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Urls
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("download_location")]
        public string DownloadLocation { get; set; }
    }

    public class Links2
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }

    public class ProfileImage
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public object TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public object PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public Links2 Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage ProfileImage { get; set; }

        [JsonProperty("instagram_username")]
        public object InstagramUsername { get; set; }

        [JsonProperty("total_collections")]
        public int TotalCollections { get; set; }

        [JsonProperty("total_likes")]
        public int TotalLikes { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }

        [JsonProperty("accepted_tos")]
        public bool AcceptedTos { get; set; }
    }

    public class Exif
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("exposure_time")]
        public string ExposureTime { get; set; }

        [JsonProperty("aperture")]
        public string Aperture { get; set; }

        [JsonProperty("focal_length")]
        public string FocalLength { get; set; }

        [JsonProperty("iso")]
        public int Iso { get; set; }
    }

    public class Position
    {
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }

    public class Location
    {
        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }
    }

    public class Meta
    {
        [JsonProperty("index")]
        public bool Index { get; set; }
    }

    public class Type
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Category
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Subcategory
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Ancestry
    {
        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("subcategory")]
        public Subcategory Subcategory { get; set; }
    }

    public class Urls2
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

    public class Links3
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("download_location")]
        public string DownloadLocation { get; set; }
    }

    public class Links4
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }

    public class ProfileImage2
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class User2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public Links4 Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage2 ProfileImage { get; set; }

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

    public class CoverPhoto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTime? PromotedAt { get; set; }

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
        public Urls2 Urls { get; set; }

        [JsonProperty("links")]
        public Links3 Links { get; set; }

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
        public User2 User { get; set; }
    }

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

    public class Tag
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }

    public class Type2
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Category2
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Subcategory2
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("pretty_slug")]
        public string PrettySlug { get; set; }
    }

    public class Ancestry2
    {
        [JsonProperty("type")]
        public Type2 Type { get; set; }

        [JsonProperty("category")]
        public Category2 Category { get; set; }

        [JsonProperty("subcategory")]
        public Subcategory2 Subcategory { get; set; }
    }

    public class Urls3
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

    public class Links5
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("download_location")]
        public string DownloadLocation { get; set; }
    }

    public class Links6
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }

    public class ProfileImage3
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class User3
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public Links6 Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage3 ProfileImage { get; set; }

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

    public class CoverPhoto2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTime? PromotedAt { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }

        [JsonProperty("urls")]
        public Urls3 Urls { get; set; }

        [JsonProperty("links")]
        public Links5 Links { get; set; }

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
        public User3 User { get; set; }

        [JsonProperty("blur_hash")]
        public string BlurHash { get; set; }
    }

    public class Source2
    {
        [JsonProperty("ancestry")]
        public Ancestry2 Ancestry { get; set; }

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
        public CoverPhoto2 CoverPhoto { get; set; }
    }

    public class Tag2
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public Source2 Source { get; set; }
    }

    public class Links7
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }

    public class Links8
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }

    public class ProfileImage4
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class User4
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public Links8 Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage4 ProfileImage { get; set; }

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

    public class Urls4
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

    public class Links9
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("download_location")]
        public string DownloadLocation { get; set; }
    }

    public class Links10
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }

        [JsonProperty("portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }

    public class ProfileImage5
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class User5
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("links")]
        public Links10 Links { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage5 ProfileImage { get; set; }

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

    public class CoverPhoto3
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public DateTimeOffset PromotedAt { get; set; }

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
        public Urls4 Urls { get; set; }

        [JsonProperty("links")]
        public Links9 Links { get; set; }

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
        public User5 User { get; set; }
    }

    public class Urls5
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

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
        public Urls5 Urls { get; set; }
    }

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
        public List<Tag2> Tags { get; set; }

        [JsonProperty("links")]
        public Links7 Links { get; set; }

        [JsonProperty("user")]
        public User4 User { get; set; }

        [JsonProperty("cover_photo")]
        public CoverPhoto3 CoverPhoto { get; set; }

        [JsonProperty("preview_photos")]
        public List<PreviewPhoto> PreviewPhotos { get; set; }
    }

    public class RelatedCollections
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public class Photo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("promoted_at")]
        public object PromotedAt { get; set; }

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
        public Links Links { get; set; }

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

        [JsonProperty("exif")]
        public Exif Exif { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("related_collections")]
        public RelatedCollections RelatedCollections { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }
    }


}

using System.Runtime.Serialization;

namespace Unsplash.Api.Photos
{
    public class RandomPhotoFilterOptions
    {
        public RandomPhotoFilterOptions(
            string collections = null,
            string topics = null,
            string username = null,
            string query = null,
            Orientation? orientation = null,
            ContentFilter? contentFilter = null,
            int? count = null)
        {
            Collections = collections;
            Topics = topics;
            Username = username;
            Query = query;
            Orientation = orientation;
            ContentFilter = contentFilter;
            Count = count ?? 1;
        }

        public string Collections { get; }
        public string Topics { get; }
        public string Username { get; }
        public string Query { get; }
        public Orientation? Orientation { get; }
        public ContentFilter? ContentFilter { get; }
        public int Count { get; }
    }

    public enum Orientation
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "squarish")]
        Squarish
    }

    public enum ContentFilter
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "high")]
        High
    }
}

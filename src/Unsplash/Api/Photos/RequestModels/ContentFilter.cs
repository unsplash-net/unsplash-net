using System.Runtime.Serialization;

namespace Unsplash.Api.Photos
{
    public enum ContentFilter
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "high")]
        High
    }
}

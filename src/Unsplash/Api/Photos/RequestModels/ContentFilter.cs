using System.Runtime.Serialization;

namespace Unsplash.Api
{
    public enum ContentFilter
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "high")]
        High
    }
}

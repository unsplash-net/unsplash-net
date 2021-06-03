using System.Runtime.Serialization;

namespace Unsplash.Api.Search
{
    public enum SearchPhotosOrderBy
    {
        [EnumMember(Value = "relevant")]
        Relevant,

        [EnumMember(Value = "latest")]
        Latest
    }
}

using System.Runtime.Serialization;

namespace Unsplash.Api
{
    public enum SearchPhotosOrderBy
    {
        [EnumMember(Value = "relevant")]
        Relevant,

        [EnumMember(Value = "latest")]
        Latest
    }
}

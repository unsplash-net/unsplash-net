using System.Runtime.Serialization;

namespace Unsplash.Api
{
    public enum PhotoOrderBy
    {
        [EnumMember(Value = "latest")]
        Latest,

        [EnumMember(Value = "oldest")]
        Oldest,

        [EnumMember(Value = "popular")]
        Popular
    }
}

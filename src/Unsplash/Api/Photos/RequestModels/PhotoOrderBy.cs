using System.Runtime.Serialization;

namespace Unsplash.Api.Photos
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

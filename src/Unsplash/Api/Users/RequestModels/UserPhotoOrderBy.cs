using System.Runtime.Serialization;

namespace Unsplash.Api
{
    public enum UserPhotoOrderBy
    {
        [EnumMember(Value = "latest")]
        Latest,

        [EnumMember(Value = "oldest")]
        Oldest,

        [EnumMember(Value = "popular")]
        Popular,

        [EnumMember(Value = "views")]
        Views,

        [EnumMember(Value = "downloads")]
        Downloads,
    }
}

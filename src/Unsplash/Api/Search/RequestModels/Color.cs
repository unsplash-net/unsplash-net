using System.Runtime.Serialization;

namespace Unsplash.Api.Search
{
    public enum Color
    {
        [EnumMember(Value = "black_and_white")]
        BlackAndWhite,

        [EnumMember(Value = "black")]
        Black,

        [EnumMember(Value = "white")]
        White,

        [EnumMember(Value = "yellow")]
        Yellow,

        [EnumMember(Value = "orange")]
        Orange,

        [EnumMember(Value = "red")]
        Red,

        [EnumMember(Value = "purple")]
        Purple,

        [EnumMember(Value = "magenta")]
        Magenta,

        [EnumMember(Value = "green")]
        Green,

        [EnumMember(Value = "teal")]
        Teal,

        [EnumMember(Value = "blue")]
        Blue
    }
}

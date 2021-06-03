using System.Runtime.Serialization;

namespace Unsplash.Api
{
    public enum Orientation
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "squarish")]
        Squarish
    }
}

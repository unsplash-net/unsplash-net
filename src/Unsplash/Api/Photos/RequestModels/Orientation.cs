using System.Runtime.Serialization;

namespace Unsplash.Api.Photos
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

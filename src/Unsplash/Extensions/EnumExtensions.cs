using System.Linq;
using System.Runtime.Serialization;

namespace Unsplash.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumMemberAttrValue<T>(this T enumVal)
        {
            var enumType = typeof(T);
            var memInfo = enumType.GetMember(enumVal.ToString());
            var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();

            if (attr != null)
            {
                return attr.Value;
            }

            return null;
        }
    }
}

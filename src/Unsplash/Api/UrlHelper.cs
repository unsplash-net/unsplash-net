using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;

[assembly: InternalsVisibleTo("Unsplash.Tests")]
namespace Unsplash.Api
{
    internal static class UrlHelper
    {
        public static string CreateQueryString(IDictionary<string, string> parameters)
        {
            bool isFirstParam = true;
            StringBuilder queryStringBuilder = new StringBuilder();

            foreach (var param in parameters)
            {
                if (param.Value == null)
                {
                    continue;
                }

                if (!isFirstParam)
                {
                    queryStringBuilder.Append('&');
                }

                queryStringBuilder.Append(HttpUtility.UrlEncode(param.Key));
                queryStringBuilder.Append('=');
                queryStringBuilder.Append(HttpUtility.UrlEncode(param.Value));
                isFirstParam = false;
            }

            return queryStringBuilder.ToString();
        }
    }
}

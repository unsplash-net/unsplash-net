using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unsplash.Tests")]
namespace Unsplash.Client
{
    internal class Constants
    {
        public const string BASE_URL = "https://api.unsplash.com/";
        public const string API_VERSION = "v1";
    }
}

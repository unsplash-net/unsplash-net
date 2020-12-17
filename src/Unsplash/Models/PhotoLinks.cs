
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class PhotoLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("download_location")]
        public string DownloadLocation { get; set; }
    }
}

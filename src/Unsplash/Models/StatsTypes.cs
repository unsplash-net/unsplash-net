using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class StatsTotals
    {
        [JsonProperty("total_photos")]
        public long TotalPhotos { get; set; }

        [JsonProperty("photo_downloads")]
        public long PhotoDownloads { get; set; }

        [JsonProperty("photos")]
        public long Photos { get; set; }

        [JsonProperty("downloads")]
        public long Downloads { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("photographers")]
        public long Photographers { get; set; }

        [JsonProperty("pixels")]
        public long Pixels { get; set; }

        [JsonProperty("downloads_per_second")]
        public long DownloadsPerSecond { get; set; }

        [JsonProperty("views_per_second")]
        public long ViewsPerSecond { get; set; }

        [JsonProperty("developers")]
        public long Developers { get; set; }

        [JsonProperty("applications")]
        public long Applications { get; set; }

        [JsonProperty("requests")]
        public long Requests { get; set; }
    }

}

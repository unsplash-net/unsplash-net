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

    public class PastMonthStats
    {
        [JsonProperty("downloads")]
        public long Downloads { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("new_photos")]
        public long NewPhotos { get; set; }

        [JsonProperty("new_photographers")]
        public long NewPhotographers { get; set; }

        [JsonProperty("new_pixels")]
        public long NewPixels { get; set; }

        [JsonProperty("new_developers")]
        public long NewDevelopers { get; set; }

        [JsonProperty("new_applications")]
        public long NewApplications { get; set; }

        [JsonProperty("new_requests")]
        public long NewRequests { get; set; }
    }

}

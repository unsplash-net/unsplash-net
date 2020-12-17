
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Exif
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("exposure_time")]
        public string ExposureTime { get; set; }

        [JsonProperty("aperture")]
        public string Aperture { get; set; }

        [JsonProperty("focal_length")]
        public string FocalLength { get; set; }

        [JsonProperty("iso")]
        public int Iso { get; set; }
    }
}

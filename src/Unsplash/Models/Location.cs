
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Location
    {
        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}

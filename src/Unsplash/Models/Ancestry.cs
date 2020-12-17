
using Newtonsoft.Json;

namespace Unsplash.Models
{
    public class Ancestry
    {
        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("subcategory")]
        public Category Subcategory { get; set; }
    }
}

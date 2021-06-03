using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unsplash.Api.Search
{
    public class PaginatedList<T>
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("results")]
        public IEnumerable<T> Results { get; set; }
    }
}

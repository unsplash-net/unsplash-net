using System.Collections.Generic;
using Unsplash.Models;
using Newtonsoft.Json;

namespace Unsplash.Api.Users
{
    public class UserStatisticsParams
    {
        public UserStatisticsParams(string resolution = null, int? quantity = null)
        {
            Resolution = resolution;
            Quantity = quantity;
        }

        public string Resolution { get; set; }
        public int? Quantity { get; set; }
    }

    public class UserStatistics : IEntity
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public Stat Downloads { get; set; }

        public Stat Views { get; set; }

        public class Stat
        {
            public double Total { get; set; }
            public Historical Historical { get; set; }
        }

        public class Historical
        {
            [JsonProperty("change")]
            public double Change { get; set; }

            [JsonProperty("quantity")]
            public double Quantity { get; set; }

            public double Average { get; set; }

            public string Resolution { get; set; }

            public List<StateValue> Values { get; set; }
        }
    }
}

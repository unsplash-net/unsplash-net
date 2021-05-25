using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Stats
{
    public interface IStatsApi
    {
        Task<StatsTotals> GetTotalsAsync();
    }

    public static class StatsApiUrls
    {
        public static string Totals() => "/stats/total";
    }

    public class StatsApi : ApiClient, IStatsApi
    {
        public StatsApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<StatsTotals> GetTotalsAsync()
        {
            var url = StatsApiUrls.Totals();

            return await GetAsync<StatsTotals>(url);
        }
    }
}

using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Stats
{
    public interface IStatsApi
    {
        Task<StatsTotals> GetTotalsAsync();
        Task<PastMonthStats> GetPastMonthStatsAsync();
    }

    public static class StatsApiUrls
    {
        public static string Totals() => "/stats/total";

        public static string PastMonthStats() => "/stats/month";
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

        public async Task<PastMonthStats> GetPastMonthStatsAsync()
        {
            var url = StatsApiUrls.PastMonthStats();

            return await GetAsync<PastMonthStats>(url);
        }
    }
}

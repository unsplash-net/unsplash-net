﻿using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api.Stats
{
    public interface IStatsApi
    {
        Task<StatsTotals> GetTotalsAsync();
        Task<PastMonthStats> GetPastMonthStatsAsync();
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

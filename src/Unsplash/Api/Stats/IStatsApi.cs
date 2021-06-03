using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api
{
    public interface IStatsApi
    {
        Task<StatsTotals> GetTotalsAsync();
        Task<PastMonthStats> GetPastMonthStatsAsync();
    }
}

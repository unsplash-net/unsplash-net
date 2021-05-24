using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public interface IPhotosApi
    {
        Task<IEnumerable<PhotoFull>> GetPhotosAsync(FilterOptions options = null);
        Task<PhotoFull> GetPhotoAsync(string photoId);
        Task<Stats> GetPhotoStatisticsAsync(string photoId);
        Task<IEnumerable<PhotoRandom>> GetRandomPhotosAsync(RandomPhotoFilterOptions options = null);
    }
}

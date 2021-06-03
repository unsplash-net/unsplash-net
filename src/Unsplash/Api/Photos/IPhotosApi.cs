using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public interface IPhotosApi
    {
        Task<IEnumerable<Photo.Full>> GetPhotosAsync(FilterOptions options = null);
        Task<Photo.Full> GetPhotoAsync(string photoId);
        Task<Photo.Stats> GetPhotoStatisticsAsync(string photoId);
        Task<IEnumerable<Photo.Random>> GetRandomPhotosAsync(RandomPhotoFilterOptions options = null);
        Task<Photo.TrackPhotoDownload> TrackPhotoDownload(string photoId);
    }
}

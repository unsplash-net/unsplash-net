using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api
{
    public class PhotosApi : ApiClient, IPhotosApi
    {
        public PhotosApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<Photo.Full> GetPhotoAsync(string photoId)
        {
            return await GetAsync<Photo.Full>(PhotosApiUrls.GetPhoto(photoId));
        }

        public async Task<IEnumerable<Photo.Full>> GetPhotosAsync(FilterOptions options)
        {
            if (options == null)
            {
                options = FilterOptions.Default;
            }

            var url = PhotosApiUrls.GetPhotos(options);

            return await GetAsync<IEnumerable<Photo.Full>>(url);
        }

        public async Task<Photo.Stats> GetPhotoStatisticsAsync(string photoId)
        {
            var url = PhotosApiUrls.GetPhotoStatistics(photoId);

            return await GetAsync<Photo.Stats>(url);
        }

        public async Task<IEnumerable<Photo.Random>> GetRandomPhotosAsync(RandomPhotoFilterOptions options = null)
        {
            if (options == null)
            {
                options = new RandomPhotoFilterOptions();
            }

            var url = PhotosApiUrls.GetRandomPhoto(options);

            return await GetAsync<IEnumerable<Photo.Random>>(url);
        }

        public async Task<Photo.TrackPhotoDownload> TrackPhotoDownload(string photoId)
        {
            var url = PhotosApiUrls.TrackPhotoDownload(photoId);

            return await GetAsync<Photo.TrackPhotoDownload>(url);
        }
    }
}

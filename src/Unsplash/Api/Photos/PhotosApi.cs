using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Client;
using Unsplash.Models;
using static Unsplash.Api.ApiEndpoints;

namespace Unsplash.Api.Photos
{
    public class PhotosApi : ApiClient, IPhotosApi
    {
        public PhotosApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<PhotoFull> GetPhotoAsync(string photoId)
        {
            return await GetAsync<PhotoFull>(PhotosApiUrls.GetPhoto(photoId));
        }

        public async Task<IEnumerable<PhotoFull>> GetPhotosAsync(FilterOptions options)
        {
            if (options == null)
            {
                options = FilterOptions.Default;
            }

            var url = PhotosApiUrls.GetPhotos(options);

            return await GetAsync<IEnumerable<PhotoFull>>(url);
        }

        public async Task<Models.Stats> GetPhotoStatisticsAsync(string photoId)
        {
            var url = PhotosApiUrls.GetPhotoStatistics(photoId);

            return await GetAsync<Models.Stats>(url);
        }

        public async Task<IEnumerable<PhotoRandom>> GetRandomPhotosAsync(RandomPhotoFilterOptions options = null)
        {
            if (options == null)
            {
                options = new RandomPhotoFilterOptions();
            }

            var url = PhotosApiUrls.GetRandomPhoto(options);

            return await GetAsync<IEnumerable<PhotoRandom>>(url);
        }

        public async Task<TrackPhotoDownload> TrackPhotoDownload(string photoId)
        {
            var url = PhotosApiUrls.TrackPhotoDownload(photoId);

            return await GetAsync<TrackPhotoDownload>(url);
        }
    }
}

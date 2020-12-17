using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public class PhotosApi : ApiClient, IPhotosApi
    {
        public PhotosApi(string baseUrl, string accessKey) : base(baseUrl, accessKey)
        {
        }

        public async Task<Photo> GetPhotoAsync(string id)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.DateTimeOffset
            };

            return await GetAsync<Photo>(PhotosApiUrls.GetPhoto(id));
        }

        public async Task<IEnumerable<Photo>> GetPhotosAsync(FilterOptions options)
        {
            if (options == null)
            {
                options = FilterOptions.Default;
            }

            var url = PhotosApiUrls.GetPhotos(options);

            return await GetAsync<IEnumerable<Photo>>(url);
        }
    }
}

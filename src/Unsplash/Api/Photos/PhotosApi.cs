﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unsplash.Client;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public class PhotosApi : ApiClient, IPhotosApi
    {
        public PhotosApi(ApiClientOptions options) : base(options)
        {
        }

        public async Task<PhotoFull> GetPhotoAsync(string id)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.DateTimeOffset
            };

            return await GetAsync<PhotoFull>(PhotosApiUrls.GetPhoto(id));
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
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unsplash.Client;
using Unsplash.Models;

[assembly: InternalsVisibleTo("Unsplash.Tests")]
namespace Unsplash.Api
{
    public interface IPhotosApi
    {
        Task<Photo> GetPhotoAsync(string id);
    }

    internal static class PhotosApiUrls
    {
        public static string GetPhoto(string id) => $"/photos/{id}";
    }

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
    }
}

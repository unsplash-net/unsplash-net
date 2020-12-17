using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public interface IPhotosApi
    {
        Task<IEnumerable<Photo>> GetPhotosAsync(FilterOptions options = null);
        Task<Photo> GetPhotoAsync(string id);
    }
}

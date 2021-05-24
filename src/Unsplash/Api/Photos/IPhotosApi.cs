using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Photos
{
    public interface IPhotosApi
    {
        Task<IEnumerable<PhotoFull>> GetPhotosAsync(FilterOptions options = null);
        Task<PhotoFull> GetPhotoAsync(string id);
    }
}

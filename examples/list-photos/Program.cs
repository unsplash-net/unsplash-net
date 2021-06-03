using System;
using System.Linq;
using System.Threading.Tasks;
using Unsplash;

namespace list_photos
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new UnsplashClient(new ClientOptions
            {
                AccessKey = "aZSSXc9bU-rb_cuoMSue-kzgSEyLNOhwAwmNiHQefw4"
            });

            var photos = await client.Photos.GetPhotosAsync();

            Console.WriteLine($"Total Photos: {photos.Count()}");
        }
    }
}

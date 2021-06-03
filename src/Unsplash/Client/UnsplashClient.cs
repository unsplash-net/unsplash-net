using Unsplash.Api;

namespace Unsplash
{
    public class UnsplashClient
    {
        public UnsplashClient(ClientOptions options)
        {
            Collections = new CollectionsApi(options);
            Photos = new PhotosApi(options);
            Search = new SearchApi(options);
            Stats = new StatsApi(options);
            Topics = new TopicsApi(options);
            Users = new UsersApi(options);
        }

        public ICollectionsApi Collections { get; }
        public IPhotosApi Photos { get; }
        public ISearchApi Search { get; }
        public IStatsApi Stats { get; }
        public ITopicsApi Topics { get; set; }
        public IUsersApi Users { get; }
    }
}

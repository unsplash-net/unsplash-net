namespace Unsplash.Api
{
    public class GetCollectionPhotosParams
    {
        public GetCollectionPhotosParams(int? page = null, int? perPage = null, Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            Orientation = orientation;
        }

        public int? Page { get; }
        public int? PerPage { get; }
        public Orientation? Orientation { get; }
    }
}

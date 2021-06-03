using Unsplash.Api;

namespace Unsplash.Api
{
    public class GetUserLikedPhotosParams
    {
        public GetUserLikedPhotosParams(
            int? page = null,
            int? perPage = null,
            PhotoOrderBy? orderBy = null,
            Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            OrderBy = orderBy;
            Orientation = orientation;
        }

        public int? Page { get; }
        public int? PerPage { get; }
        public PhotoOrderBy? OrderBy { get; }
        public Orientation? Orientation { get; set; }
    }
}

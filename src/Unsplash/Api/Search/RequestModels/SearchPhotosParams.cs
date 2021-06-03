using Unsplash.Api.Photos;

namespace Unsplash.Api.Search
{
    public class SearchPhotosParams
    {
        public SearchPhotosParams(
            int? page = null,
            int? perPage = null,
            SearchPhotosOrderBy? orderBy = null,
            string collections = null,
            ContentFilter? contentFilter = null,
            Color? color = null,
            Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            OrderBy = orderBy;
            Collections = collections;
            ContentFilter = contentFilter;
            Color = color;
            Orientation = orientation;
        }

        public int? Page { get; }
        public int? PerPage { get; }
        public SearchPhotosOrderBy? OrderBy { get; }
        public string Collections { get; }
        public ContentFilter? ContentFilter { get; }
        public Color? Color { get; }
        public Orientation? Orientation { get; }
    }
}

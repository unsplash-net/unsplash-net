namespace Unsplash.Api.Collections
{
    public class ListCollectionsParams
    {
        public ListCollectionsParams(int? page, int? perPage)
        {
            Page = page;
            PerPage = perPage;
        }

        public static ListCollectionsParams Default => new ListCollectionsParams(1, 10);

        public int? Page { get; }
        public int? PerPage { get; }
    }
}

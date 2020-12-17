namespace Unsplash.Api.Photos
{
    public class FilterOptions
    {
        public int Page { get; }
        public int PerPage { get; }
        public PhotoOrderBy OrderBy { get; }

        public static readonly FilterOptions Default = new FilterOptions(1, 10, PhotoOrderBy.Latest);

        public FilterOptions(int page, int perPage, PhotoOrderBy orderBy)
        {
            Page = page;
            PerPage = perPage;
            OrderBy = orderBy;
        }
    }
}

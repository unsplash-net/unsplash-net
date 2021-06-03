namespace Unsplash.Api
{
    public class SearchUsersParams
    {
        public SearchUsersParams(int? page = null, int? perPage = null)
        {
            Page = page;
            PerPage = perPage;
        }

        public int? Page { get; }
        public int? PerPage { get; }
    }
}

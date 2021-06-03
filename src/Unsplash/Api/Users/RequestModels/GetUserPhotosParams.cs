using Unsplash.Api;

namespace Unsplash.Api
{
    public class GetUserPhotosParams
    {
        public int? Page { get; }

        public GetUserPhotosParams(
            int? page = null,
            int? perPage = null,
            UserPhotoOrderBy? orderBy = null,
            bool? stats = null,
            string resolution = null,
            int? quantity = null,
            Orientation? orientation = null)
        {
            Page = page;
            PerPage = perPage;
            OrderBy = orderBy;
            Stats = stats;
            Resolution = resolution;
            Quantity = quantity;
            Orientation = orientation;
        }

        public int? PerPage { get; }
        public UserPhotoOrderBy? OrderBy { get; }
        public bool? Stats { get; }
        public string Resolution { get; }
        public int? Quantity { get; }
        public Orientation? Orientation { get; set; }
    }
}

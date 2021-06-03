namespace Unsplash.Api.Users
{
    public class UserStatisticsParams
    {
        public UserStatisticsParams(string resolution = null, int? quantity = null)
        {
            Resolution = resolution;
            Quantity = quantity;
        }

        public string Resolution { get; set; }
        public int? Quantity { get; set; }
    }
}

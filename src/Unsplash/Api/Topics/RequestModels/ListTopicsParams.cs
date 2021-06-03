using System.Runtime.Serialization;

namespace Unsplash.Api.Topics
{
    public class ListTopicsParams
    {
        public string Id { get; set; }
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public TopicOrderBy? OrderBy { get; set; }

        public enum TopicOrderBy
        {
            [EnumMember(Value = "featured")]
            Featured,

            [EnumMember(Value = "latest")]
            Latest,

            [EnumMember(Value = "oldest")]
            Oldest,

            [EnumMember(Value = "position")]
            Position
        }
    }
}

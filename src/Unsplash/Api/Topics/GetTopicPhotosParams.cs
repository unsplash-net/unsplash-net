﻿using Unsplash.Api.Photos;

namespace Unsplash.Api.Topics
{
    public class GetTopicPhotosParams
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public Orientation? Orientation { get; set; }
        public PhotoOrderBy? OrderBy { get; set; }
    }
}

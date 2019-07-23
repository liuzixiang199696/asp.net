﻿using System.Collections.Generic;

namespace BLL.Entity.Articled
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //注意：不是IList<Blog>
        public IList<BlogToKeywords> Blogs { get; set; }
    }
}
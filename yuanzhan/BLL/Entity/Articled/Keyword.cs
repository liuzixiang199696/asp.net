using System;
using System.Collections.Generic;

namespace BLL.entity.Articled
{
    public class Keyword:Entity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }

        //注意：不是IList<Blog>
        public IList<BlogToKeywords> Blogs { get; set; }
    }
}
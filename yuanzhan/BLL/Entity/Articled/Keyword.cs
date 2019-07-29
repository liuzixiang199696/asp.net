using System.Collections.Generic;

namespace BLL.entity.Articled
{
    public class Keyword:Entity
    {
        public string Name { get; set; }

        //注意：不是IList<Blog>
        public IList<BlogToKeywords> Blogs { get; set; }
    }
}
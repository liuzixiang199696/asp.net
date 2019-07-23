using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entity.Articled
{
    public class Blog:Article
    {
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
        public IList<BlogToKeywords> Keywords { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }//如果不声明的话，就会产生“影子”属性
        public Blog Blog { get; set; }
    }
}

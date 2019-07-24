using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.entity.Articled
{
    public class BlogToKeywords
    {
        public int BlogId { get; set; }     //需要这个BlogId做外键
        public Blog Blog { get; set; }

        public int KeywordId { get; set; }  //需要这个KeywordId做外键
        public Keyword Keyword { get; set; }
    }
}

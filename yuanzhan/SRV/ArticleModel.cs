using BLL;
using BLL.entity.Articled;
using System;
using System.Collections.Generic;
using System.Text;
using static BLL.entity.Articled.Article;

namespace SRV
{
   public class ArticleModel
    {
        public DateTime PublishDateTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<ArticleToKeywords> Keywords { get; set; }
        public MYUser AutherName { get; set; }
        public List<ArticlePost> Posts { get; set; }
        public int Agree { get; set; }
        public int DisAgree { get; set; }
    }
}

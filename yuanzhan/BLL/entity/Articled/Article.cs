using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.entity.Articled
{
   public class Article:Entity
    {       
        public DateTime PublishDateTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<ArticleToKeywords> Keywords { get; set; }     
        public  MYUser AutherName { get; set; }
        public List<ArticlePost> Posts { get; set; }
        public int Agree { get; set; }
        public int DisAgree { get; set;}

        public class ArticlePost : Entity
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }//如果不声明的话，就会产生“影子”属性
            public Blog Blog { get; set; }
            public MYUser PostUserName { get; set; }
        }

        public void Publish(Article article)
        {
            
        }
    }
}

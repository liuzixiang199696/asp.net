using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models.Article
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string NewPost { get; set; }
        public List<Post> posts { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int ArticleModelId { get; set; }
        public ArticleModel Article { get; set; }
    }
}
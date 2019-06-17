using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Comment
    {
        internal Article _article { get; }
        internal User user { get; }
        internal Appraise appraise { get; set; }
        internal string content { get; set; }
        public Comment(Publish publish,Article article)
        {
            _article = article;
            publish.article.comment.Add(this);
            
        }
    }
}

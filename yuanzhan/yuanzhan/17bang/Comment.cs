using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Comment:IPublish   //评论
    {
        internal Article _article { get; }
        internal User user { get; }
        internal Appraise appraise { get; set; }
        internal string content { get; set; }
        public Comment(Article article)
        {
            _article = article;
           //ublish.article.comment.Add(this);
            
        }
        void IPublish.Publish()
        {
            throw new NotImplementedException();
        }
    }
}

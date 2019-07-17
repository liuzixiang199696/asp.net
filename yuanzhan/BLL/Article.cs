using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Article : Pubish //文章
    {
        internal List<Comment> comment { get; set; }
        internal Appraise appraise { get; set; }
        internal List<KeyWord> keyWords { get; set; }
        public Article(MYUser auther, string title, string body, DateTime date)
            :base(auther, title, body, date)
        {
            //Author.Articles.Add(this);
        }
    }
}

using BLL;
using BLL.entity.Articled;
using BLL.repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class ArticleService : BaseService
    {
        public ArticleModel _articleModel;
        public Article _article;
        public ArticleRepoistory _repoistory;
        public ArticleService(ArticleModel articleModel, Article article, ArticleRepoistory repoistory)
        {
            _articleModel = articleModel;
            _article = article;
            _repoistory = repoistory;
        }
        public void Publish(DateTime PublishDateTime, string Title ,string Body, List<ArticleToKeywords> Keywords, MYUser AutherName)
        {
            _article.PublishDateTime = PublishDateTime;
            _article.Title = Title;
            _article.Body = Body;
            _article.Keywords = Keywords;
            _article.AutherName = AutherName;
            _article.Publish(_article);
        }

    }
}

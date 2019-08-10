using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages.ArticleList
{
    public class PublishModel : _LayoutModel
    {
        public ArticleService _articleService;
        public ArticleModel _model;
        public PublishModel(ArticleModel model, IUserService service, ArticleService articleService) :base(service)
        {
            _model = model;
            _articleService = articleService;
        }
        public override void OnGet()
        {

        }
        public override void OnPost()
        {
            _model.PublishDateTime = DateTime.Now;
            //_articleService.Publish();
            Response.Redirect("/ArticleList/Index/1");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages
{
    [BindProperties]
    public class PublishSuggestModel : _LayoutModel
    {
        public PublishSuggest PublishSuggest { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }
        public override void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            PublishSuggest.PublishSuggestDateTime = DateTime.Now;
            new SuggestService().Publish(PublishSuggest.SuggestTitle, PublishSuggest.SuggestContent, PublishSuggest.PublishSuggestDateTime);
            return;
        }
    }
    [BindProperties]
    public class PublishSuggest
    {

        public string SuggestTitle { get; set; }
        public string SuggestContent { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }

    }
}
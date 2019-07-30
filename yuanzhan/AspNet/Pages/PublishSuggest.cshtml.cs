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
    public class PublishSuggestModel 
    {
        public PublishSuggest PublishSuggest { get; set; }
        private SuggestService _suggestService;
        private _LayoutModel _LayoutModel;
        public PublishSuggestModel(SuggestService suggestService, _LayoutModel LayoutModel)
        {
            _suggestService = suggestService;
            _LayoutModel = LayoutModel;
        }
        public  void OnGet()
        {
            _LayoutModel.OnGet();
        }
        public void OnPost()
        {
            PublishSuggest.PublishSuggestDateTime = DateTime.Now;
            _suggestService.Publish(PublishSuggest.SuggestTitle, PublishSuggest.SuggestContent, PublishSuggest.PublishSuggestDateTime,
                Convert.ToInt32(_LayoutModel.Request.Cookies.TryGetValue("UserId", out PublishSuggest.AutherId)));
            return;
        }
    }
    [BindProperties]
    public class PublishSuggest
    {

        public string SuggestTitle { get; set; }
        public string SuggestContent { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }
        public string AutherId;

        // public MYUser User { get; set; }

    }
}
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
        private SuggestService _suggestService;
        private _LayoutModel _LayoutModel;
        private IUserService _service;
        public PublishSuggestModel(SuggestService suggestService, IUserService service):base(service)
        {
            _suggestService = suggestService;
            _service = service;
        }
        public override void OnGet()
        {
           base.OnGet();
        }
        public override void OnPost()
        {
            PublishSuggest.PublishSuggestDateTime = DateTime.Now;
            _suggestService.Publish(PublishSuggest.SuggestTitle, PublishSuggest.SuggestContent, PublishSuggest.PublishSuggestDateTime,
                Convert.ToInt32(Request.Cookies.TryGetValue("UserId", out PublishSuggest.AutherId)));
            Response.Redirect("/SuggestHTML/Suggest");
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
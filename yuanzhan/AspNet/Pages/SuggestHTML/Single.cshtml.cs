using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages.SuggestHTML
{
    public class SingleModel :_LayoutModel
    {
        public SuggestService _suggestService;
        private IUserService _service;
        public SingleModel(IUserService service, SuggestService suggestService) :base(service)
        {
            _service = service;
            _suggestService = suggestService;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public override void OnGet()
        {
            base.OnGet();          
            ViewData["id"] = Id;
            Title=  _suggestService.GetSuggestSingle(Id).Title;
            Body = _suggestService.GetSuggestSingle(Id).SuggestContent;
            DateTime = _suggestService.GetSuggestSingle(Id).PublishSuggestDateTime;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.repoistory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages
{
    public class SuggestModel : _LayoutModel
    {
        private SuggestService _suggestService;
        public List<Suggest> SuggestS { get; set; }
        private IUserService _service;
        public SuggestModel(SuggestService suggestService, IUserService service) : base(service)
        {
            _suggestService = suggestService;
            _service = service;
        }
        public override void OnGet()
        {
            base.OnGet();
            SuggestS = _suggestService.GetSuggest();


        }
    }
}
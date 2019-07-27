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
        public SuggestModel()
        {
            _suggestService = new SuggestService();

        }
        public override void OnGet()
        {
            base.OnGet();
             SuggestS = _suggestService.GetSuggest();
             

        }
    }
}
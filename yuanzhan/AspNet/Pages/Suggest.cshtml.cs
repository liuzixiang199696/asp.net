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
    public class SuggestModel : _LayoutModel
    {
        private SuggestService _suggestService;
        public SuggestModel()
        {
            _suggestService = new SuggestService();

        }
        public override void OnGet()
        {
            base.OnGet();
            
        }
    }
}
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
        [BindProperty( SupportsGet =true)]
        public int PageIndex { get; set; }
        public int PageIndexAndOne { get; set; }
        public int PageIndexminusOne { get; set; }
        public SuggestModel(SuggestService suggestService, IUserService service) : base(service)
        {
            _suggestService = suggestService;
            _service = service;
        }
        public override void OnGet()
        {
            base.OnGet();
            PageIndexAndOne = PageIndex + 1;
            if (PageIndex==1)
            {
                PageIndexminusOne=1;
            }
            else
            {
                PageIndexminusOne = PageIndex - 1;
            }
            
            SuggestS = _suggestService.GetSuggest(PageIndex,2);


        }
    }
}
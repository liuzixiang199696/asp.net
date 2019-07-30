using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.Pages.Shared;

namespace AspNet.Pages
{
    public class ProblemModel
    {
        private _LayoutModel _LayoutModel;
        public ProblemModel(_LayoutModel LayoutModel)
        {

            _LayoutModel = LayoutModel;
        }
        public void OnGet()
        {
            _LayoutModel.OnGet();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace AspNet.Pages
{
    public class IndexModel
    {
        private _LayoutModel _LayoutModel;
        public IndexModel(_LayoutModel LayoutModel)
        {

            _LayoutModel = LayoutModel;
        }
        public void OnGet()
        {
            _LayoutModel.OnGet();

        }
    }
}

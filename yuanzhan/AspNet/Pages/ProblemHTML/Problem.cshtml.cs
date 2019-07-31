using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace AspNet.Pages
{
    public class ProblemModel: _LayoutModel
    {
        private IUserService _service;
        public ProblemModel(IUserService service):base(service)
        {
           
        }
        public override void OnGet()
        {
            base.OnGet();
        }
    }
}
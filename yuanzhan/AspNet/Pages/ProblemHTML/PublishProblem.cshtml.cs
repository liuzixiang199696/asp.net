using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages.ProblemHTML
{
    public class PublishProblemModel : _LayoutModel
    {
        private IUserService _service;
        public PublishProblemModel(IUserService service) : base(service)
        {

        }
        public override void OnGet()
        {
            base.OnGet();
        }
    }
}
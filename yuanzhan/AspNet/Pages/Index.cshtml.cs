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
    public class IndexModel: _LayoutModel
    {
        public IUserService _service;
        public IndexModel(IUserService service):base(service)
        {
            _service = service;
        }
        public override void OnGet()
        {
            base.OnGet();

        }
    }
}

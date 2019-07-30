using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace UI.Pages.Shared
{
    public class _LayoutModel : PageModel
    {
        public const string userIdKey = "userId";
        protected const string userAuth = "PassWord";
        private IUserService _service;
        public _LayoutModel(IUserService service)
        {
            _service = service;
        }
        public virtual void OnGet()
        {

            string userIdValue;
            if (HttpContext.Request.Cookies.TryGetValue(userIdKey, out userIdValue))
            {
                UserModel model = _service.GetById(Convert.ToInt32(userIdValue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(userAuth, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            ViewData["UserName"] = model.Name;
                        }
                    }
                }
            }

        }
        public virtual void OnPost()
        {

        }

    }
}
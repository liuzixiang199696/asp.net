using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace UI.Pages
{
    #region ExitLoginModel
    public class ExitLoginModel : PageModel
    {
        public const string userIdKey = "userId";
        protected const string userAuth = "PassWord";

        public void OnGet()
        {
            string userIdValue;
            if (HttpContext.Request.Cookies.TryGetValue(userIdKey, out userIdValue))
            {
                UserModel model = new UserService().GetById(Convert.ToInt32(userIdValue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(userAuth, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            Response.Cookies.Delete(userAuth);
                        }
                    }
                }
            }
            Response.Redirect("/Index");
        }
        public void OnPost()
        {
        }
    }
}
#endregion
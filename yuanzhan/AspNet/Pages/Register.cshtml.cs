using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNet.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "* ±ÿ–ÎÃÓ–¥")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "* ±ÿ–ÎÃÓ–¥")]
        public string Password { get; set; }
        [Compare("Password")]
        public string NewPassword { get; set; }
        public bool RemeberGender { get; set; }
        public bool Remeber { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!BLL.User.IsNameDuplicated(UserName))
            {
                BLL.User.Register(new BLL.User { Name = UserName, Password = Password });
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/About");

           
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace AspNet.Pages
{
    public class RegisterModel : PageModel
    {
        public Register Register { get; set; }


        public void OnGet()
        {
            ViewData["title"] = "ע��";
        }
        public IActionResult OnPost()
        {
            //if (!BLL.User.IsNameDuplicated(UserName))
            //{
            //    BLL.User.Register(new BLL.User { Name = UserName, Password = NPassword });
            //}
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (new RegisterService().HasExist(Register.UserName))
            {

            }
            new RegisterService().Register(Register.UserName, Register.PassWord);
            return RedirectToPage("/");


        }
        private void Save(Register register) {


        }
    }
    [BindProperties]
    public class Register
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "* ������д")]
        [Display(Name = "�û���")]
        public string UserName { get; set; }
        [Display(Name = "����")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "* ������д")]
        public string PassWord { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "* ������д")]
        [Compare("PassWord", ErrorMessage = "*�������벻һ�£�")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get; set; }
        public bool RemeberGender { get; set; }
        public bool Remeber { get; set; }


    }
}
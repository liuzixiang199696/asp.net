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
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public Register Register { get; set; }
        private RegisterService _registerService;
        public RegisterModel(RegisterService registerService)
        {
            _registerService = registerService;

        }
        public void OnGet()
        {
            ViewData["title"] = "注册";
        }
        public IActionResult OnPost()
        {
            //if (!BLL.User.IsNameDuplicated(Register.UserName))
            //{
            //    BLL.User.Register(new BLL.User { Name = Register.UserName, Password =Register.PassWord });
            //}
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (_registerService.HasExist(Register.UserName))
            {
                 ModelState.AddModelError("Register.UserName", "*用户名重复!");
                return Page();

            }
            _registerService.Register(Register.UserName, Register.PassWord);
            return RedirectToPage("/Register");


        }
        private void Save(Register register) {


        }
    }
    [BindProperties]
    public class Register
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "* 必须填写")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "* 必须填写")]
        public string PassWord { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "* 必须填写")]
        [Compare("PassWord", ErrorMessage = "*两次输入不一致！")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get; set; }
        public bool RemeberGender { get; set; }
        public bool Remeber { get; set; }
    }
}
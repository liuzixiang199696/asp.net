using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using UI.Pages.Shared;

namespace UI.Pages.Email
{
    public class ValidateModel : _LayoutModel
    {
        private const string _id = "id";
        private const string _code = "code";
        public const string VALID = "reminder";
        public DateTime dateTime = DateTime.Now;
        private UserService _userService;
        public string AutherId;
        public ValidateModel(UserService userService):base(userService)
        {
            _userService = userService;
        }
        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public override void OnGet()
        {
            base.OnGet();
            string id = Request.Query[_id];
            string code = Request.Query[_code];
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(code))
            {
                ViewData[VALID] = _userService.ValiadationEmail(Convert.ToInt32(id), code);
            }

        }
        public override void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            string ValidationUrlFormat = $"{Request.Scheme}://{Request.Host}/Email/Validate?{_code}={{0}}&{_id}={{1}}";
            if (_userService.GetByAutherId(Convert.ToInt32(Request.Cookies.TryGetValue("UserId", out AutherId)))==0)
            {
                _userService.SendValiadationEmail(EmailAddress, ValidationUrlFormat, dateTime, Convert.ToInt32(Request.Cookies.TryGetValue("UserId", out AutherId)));
            }
            else
            {
                ModelState.AddModelError(EmailAddress, "*此用户已注册邮箱！");               
                return;
            }
           

        }
    }
}
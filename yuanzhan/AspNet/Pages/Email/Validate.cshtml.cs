using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace UI.Pages.Email
{
    public class ValidateModel : PageModel
    {
        private const string _id = "id";
        private const string _code = "code";
        public const string VALID = "reminder";
        private UserService _userService;
        public ValidateModel()
        {
            _userService = new UserService();
        }
        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public void OnGet()
        {
 
            string id = Request.Query[_id];
            string code = Request.Query[_code];
            if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(code))
            {
                ViewData[VALID] = _userService.ValiadationEmail(Convert.ToInt32(id), code); 
            }
            
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            string ValidationUrlFormat = $"{Request.Scheme}://{Request.Host}/Email/Validate?{_code}={{0}}&{_id}={{1}}";
            _userService.SendValiadationEmail(EmailAddress, ValidationUrlFormat);

        }
    }
}
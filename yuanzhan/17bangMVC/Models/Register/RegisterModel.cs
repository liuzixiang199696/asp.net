using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models.Register
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="*用户名不能为空！")]
        public string UserName { get; set; }
        public string PassWord{ get; set; }
        public bool RememberMe { get; set; }
        public bool IsMan { get; set; }
        public string description { get; set; }
        public Cities? Incity { get; set; }
        public string captcha { get; set; }
    }
    public enum Cities
    {
        [Display(Name ="重庆")]
        chongqing,
        [Display(Name = "上海")]
        shanghai,
        [Display(Name = "黑龙江")]
        heilongjiang,
        [Display(Name = "北京")]
        beijing,
    }
}
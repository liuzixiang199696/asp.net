using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models.Register
{
    public class IndexModel
    {
        [Required(ErrorMessage ="*用户名不能为空！")]
        public string UserName { get; set; }
        public string PassWord{ get; set; }
        public bool RememberMe { get; set; }

    }
}
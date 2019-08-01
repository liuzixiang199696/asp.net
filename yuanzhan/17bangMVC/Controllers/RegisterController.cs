using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class RegisterController: Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }
    }
}
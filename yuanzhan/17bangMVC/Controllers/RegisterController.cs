using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Index(int? id)
        {
            RegisterModel indexModel = new RegisterModel
            {
                IsMan = true
            };
            ViewBag.id = id;
            return View(indexModel);
        }
        [HttpPost]
        public ActionResult Index(string name, RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            name = model.UserName;
            ViewBag.UserName = name;
            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult Reminder()
        {
            return PartialView();
        }
    }
}
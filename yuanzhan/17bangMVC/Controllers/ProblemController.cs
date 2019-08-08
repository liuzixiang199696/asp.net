using _17bangMVC.Models.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ProblemController: Controller
    {
        public ActionResult PublishProblem()
        {
            return View("PublishProblem");
        }
        [HttpPost]
        public ActionResult PublishProblem(ProblemModel model)
        {
            ViewBag.Title = model.Title;
            ViewBag.Body = model.Body;
            Save(model);
            return RedirectToAction("PublishProblem");
        }
        public void GetProblemSingle()
        {

        }
        public void GetProblem()
        {

        }
        public void Save(ProblemModel model)
        {

        }
    }
}
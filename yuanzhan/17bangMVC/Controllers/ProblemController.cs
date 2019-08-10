using _17bangMVC.Models;
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
        private SQLDbContext SQLDbContext;
        public const string ConstPublishProblem = "PublishProblem";
        public ActionResult PublishProblem()
        {
            return View(ConstPublishProblem);
        }
        [HttpPost]
        public ActionResult PublishProblem(ProblemModel model)
        {
            ViewBag.Title = model.Title;
            ViewBag.Body = model.Body;
            Save(model);          
            return RedirectToAction(ConstPublishProblem);
        }
        public void GetProblemSingle()
        {

        }
        public void GetProblem()
        {

        }
        public void Save(ProblemModel model)
        {
            SQLDbContext dbContext = new SQLDbContext();
            dbContext.Problems.Add(model);
            dbContext.SaveChanges();
        }
    }
}
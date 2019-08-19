using _17bangMVC.Models;
using _17bangMVC.Models.Problem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ProblemController : Controller
    {
        public const string ConstPublishProblem = "PublishProblem";
        public ProblemModel Problem = new ProblemModel();
        SQLDbContext dbContext = new SQLDbContext();
        Post posts = new Post();
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
            return Redirect("/Problem/Single/" + model.Id);
        }
        [ValidateInput(false)]
        public ActionResult Single(int id)
        {
            ProblemModel problem = get(id);
           // problem.Posts = dbContext.Database.SqlQuery<Post>($"select*from Posts where ProblemModelId = {id}; ").ToList();
            return View(problem);

        }
        public ActionResult ProblemList()
        {
            IList<ProblemModel> model = new List<ProblemModel>();
            model = dbContext.Problems.ToList();
            return View(model);

        }
        public ActionResult Posts(int id, ProblemModel model)
        {
            ProblemModel problem = GetPost(id);
            problem.Posts = problem.Posts ?? new List<Post>();
            Post post = new Post
            {
                Body = model.NewPost,
                ProblemModelId = id
            };
            dbContext.Problems.Where(m => m.Id == id).SingleOrDefault().Posts.Add(post);
            dbContext.SaveChanges();
            return PartialView("Posts", model.NewPost);
        }

        private ProblemModel get(int id)
        {
            return dbContext.Problems
                .Where(p => p.Id == id)
                .Include(p => p.Posts)
                .SingleOrDefault();
        }
        private ProblemModel GetPost(int id)
        {
            return dbContext.Problems.Where(p => p.Id == id).SingleOrDefault();
        }

        public void Save(ProblemModel model)
        {

            dbContext.Problems.Add(model);
            dbContext.SaveChanges();
        }
    }
}
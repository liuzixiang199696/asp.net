using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models.Problem
{
    public class ProblemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string NewPost { get; set; }
        public List<Post> Posts { get; set; }

    }

    public class Post
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int ProblemModelId { get; set; }
        public ProblemModel problem { get; set; }
    }
}
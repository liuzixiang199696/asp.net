using _17bangMVC.Models.Problem;
using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext() : base("name=17bangMVC")
        {
            //Database.SetInitializer<SQLDbContext>(null);
        }
        public DbSet<ProblemModel> Problems { get; set; }
        public DbSet<RegisterModel> Registers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProblemModel>().Ignore(m => m.NewPost);
            modelBuilder.Entity<RegisterModel>().Ignore(m=>m.captcha);
        }
    }
}
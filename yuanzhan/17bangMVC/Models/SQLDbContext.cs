using _17bangMVC.Models.Problem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models
{
    public class SQLDbContext : DbContext
    {
        public DbSet<ProblemModel> problems { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProblemModel>(); 
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
    public class UserRepoistory: DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Email> emails { get; set; }

        public User Save(User user)
        {           
            users.Add(user);
            SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
            emails.Add(email);
            SaveChanges();
            return email;
        }

        public User GetByName(string userName)
        {
            return users.Where(u => u.Name == userName).SingleOrDefault();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

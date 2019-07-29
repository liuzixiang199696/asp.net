using BLL.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.repoistory
{
    public class UserRepoistory:Repository<Entity>
    {     
        public SQLDBContext context;
        public MYUser Save(MYUser user)
        {           
           context.users.Add(user);
           context.SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
          context.emails.Add(email);
           context.SaveChanges();
            return email;
        }

        public MYUser GetByName(string userName)
        {
            return context.users.Where(u => u.Name == userName).SingleOrDefault();
        }

        public  void Flush() 
        {
            throw new NotImplementedException();
        }

        public Email GetEmailById(int id)
        {
            Email email = context.emails.Where(e => e.OwnerId == id).SingleOrDefault();
            return email;
        }

        public MYUser GetById(int id)
        {
            return context.users.Where(u => u.Id == id).SingleOrDefault();
        }
    }

}

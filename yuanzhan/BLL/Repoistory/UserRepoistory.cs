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
        MYUser MYUser = new MYUser();  
        public MYUser Save(MYUser user)
        {
            entities.Add(user);
            entities.SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
            entities.Add(email);
            entities.SaveChanges();
            return email;
        }

        public MYUser GetByName(string userName)
        {
            return entities.Where(u => u.Name == userName).SingleOrDefault();
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
            return context.users.Where(u => u.id == id).SingleOrDefault();
        }
    }

}

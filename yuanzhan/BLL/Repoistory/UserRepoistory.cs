using BLL.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.repoistory
{
    public class UserRepoistory:Repository<MYUser>
    {
        private EmailRepoistory _EmailRepoistory;
        private UserRepoistory _UserRepoistory;
        public UserRepoistory(DbContext context, EmailRepoistory EmailRepoistory,UserRepoistory UserRepoistory) :base(context)
        {
            _EmailRepoistory = EmailRepoistory;
            _UserRepoistory = UserRepoistory;
        }
        
        public MYUser Save(MYUser user)
        {
            CurrentContext.Add(user);
            CurrentContext.SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
            CurrentContext.Add(email);
            CurrentContext.SaveChanges();
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
            Email email = _EmailRepoistory.entities.Where(e => e.id == id).SingleOrDefault();
            return email;
        }

        public MYUser GetById(int id)
        {
            return _UserRepoistory.entities.Where(u => u.id == id).SingleOrDefault();
        }
    }

}

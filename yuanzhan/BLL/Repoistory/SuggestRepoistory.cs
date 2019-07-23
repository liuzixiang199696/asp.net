using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
   public class SuggestRepoistory 
    {
        private SQLDBContext context;
        public SuggestRepoistory()
        {
            context = new SQLDBContext();
        }

        public Suggest Save(Suggest  suggest,int id)
        {
            suggest.User = context.users.Where(u => u.Id == id).SingleOrDefault();
            context.suggests.Add(suggest);
            context.SaveChanges();
            return suggest;
        }
        public List<Suggest> GetById(int id)
        {
            return context.suggests.ToList();
        }
    }   
}

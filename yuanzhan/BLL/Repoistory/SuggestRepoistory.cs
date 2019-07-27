using BLL.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.repoistory
{
   public class SuggestRepoistory : Repository<Entity>
    {
        private SQLDBContext context;
        public SuggestRepoistory()
        {
            context = new SQLDBContext();
        }

        public Suggest Save(Suggest  suggest)
        {
           // suggest.User = context.users.Where(u => u.Id == id).SingleOrDefault();
            context.suggests.Add(suggest);
            context.SaveChanges();
            return suggest;
        }
        public List<Suggest> GetSuggest()
        {
            return context.suggests.ToList();
        }
    }   
}

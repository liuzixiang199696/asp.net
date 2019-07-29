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
        public Suggest Save(Suggest  suggest)
        {
            context.Add(suggest);
            context.SaveChanges();
            return suggest;
        }
        public List<Suggest> GetSuggest()
        {
            return null;
        }
    }   
}

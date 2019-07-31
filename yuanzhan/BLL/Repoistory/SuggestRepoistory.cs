using BLL.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.repoistory
{
   public class SuggestRepoistory : Repository<Suggest>
    {
        public SuggestRepoistory(SQLDbContext context) :base(context)
        {
        }
        public override Suggest Save(Suggest  suggest)
        {
            CurrentContext.Add(suggest);
            CurrentContext.SaveChanges();
            return suggest;
        }
        public List<Suggest> GetSuggest()
        {
            return entities.ToList();
        }
    }   
}

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
        public List<Suggest> GetSuggest(int pageIndex, int pageSige)
        {
            return entities.OrderByDescending(s=>s.id)
                .Skip((pageIndex-1)*pageSige).Take(pageSige)
                .ToList();
        }

        public Suggest GetSuggestSingle(int id)
        {
            return entities.Where(s => s.id == id).SingleOrDefault();
           
                
        }
    }   
}

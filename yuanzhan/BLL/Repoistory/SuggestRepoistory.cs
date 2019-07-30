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
        private SQLDBContext _context;
        public SuggestRepoistory(SQLDBContext context)
        {
            _context = context;
        }
        public Suggest Save(Suggest  suggest)
        {
            _context.Add(suggest);
            _context.SaveChanges();
            return suggest;
        }
        public List<Suggest> GetSuggest()
        {
            return null;
        }
    }   
}

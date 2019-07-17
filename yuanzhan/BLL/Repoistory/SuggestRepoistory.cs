using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    class SuggestRepoistory 
    {
        private SQLDBContext context;
        public SuggestRepoistory()
        {
            context = new SQLDBContext();
        }

        public Suggest Save(Suggest  suggest)
        {
            context.suggests.Add(suggest);
            context.SaveChanges();
            return suggest;
        }

    }   
}

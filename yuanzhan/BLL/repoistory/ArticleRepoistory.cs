using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.repoistory
{
  public  class ArticleRepoistory:Repository<Articles>
    {
        public ArticleRepoistory(SQLDbContext context) : base(context)
        {

        }
    }
}

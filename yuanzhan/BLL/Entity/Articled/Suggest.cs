using BLL.entity;
using BLL.repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest:Article
    {
        SuggestRepoistory _suggestRepoistory;
         Suggest(SuggestRepoistory suggestRepoistory)
        {
            _suggestRepoistory = suggestRepoistory;
        }
        //public  MYUser User { get; set; }

        public void Publish(Suggest suggest)
        {
           // User = new UserRepoistory().GetById(id);            
            _suggestRepoistory.Save(suggest);
        }
    }
}

using BLL.repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest:Article
    {
        static Suggest()
        {

        }
        public string SuggestContent { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }
        //public  MYUser User { get; set; }

        public void Publish(Suggest suggest,int id)
        {
           // User = new UserRepoistory().GetById(id);
            SuggestRepoistory suggestRepoistory = new SuggestRepoistory();
            suggestRepoistory.Save(suggest,id);
        }
    }
}

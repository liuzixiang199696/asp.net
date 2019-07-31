using BLL.entity;
using BLL.repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest : Entity
    {
        public Suggest()
        {
                
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }
        public int AutherId { get; set; }

        public SuggestRepoistory _suggestRepoistory;
        public Suggest(SuggestRepoistory suggestRepoistory)
        {
            _suggestRepoistory = suggestRepoistory;
        }
        //public  MYUser User { get; set; }

        public void Publish(Suggest suggest)
        {
            _suggestRepoistory.Save(suggest);
        }
    }
}

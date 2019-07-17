using BLL.Repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest
    {
        static Suggest()
        {

        }
        public int Id { get; set; }
        public string SuggestTitle { get; set; }
        public string SuggestContent { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }

        public void Publish(Suggest suggest)
        {
            SuggestRepoistory suggestRepoistory = new SuggestRepoistory();
            suggestRepoistory.Save(suggest);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.Repoistory;

public class SuggestService
{
    private SuggestRepoistory _suggestRepoistory;
    public SuggestService()
    {
        _suggestRepoistory = new SuggestRepoistory();
    }
    public void Publish(string title, string Content, DateTime dateTime)
    {
        Suggest suggest = new Suggest
        {
            SuggestTitle = title,
            SuggestContent = Content,
            PublishSuggestDateTime = dateTime
        };
        suggest.Publish(suggest);
       
    }
    public SRVSuggestModel GetById(int id)
    {
        Suggest[] suggest  = _suggestRepoistory.GetById(id);
        if (id ==0)
        {
            return null;
        }
        else
        {
            //suggest.ToArray().Length
            SRVSuggestModel model = new SRVSuggestModel
            {
                Id = suggest[1].Id,
                SuggestTitle = suggest[1].SuggestTitle,
                SuggestContent = suggest[1].SuggestContent,
                PublishSuggestDateTime = suggest[1].PublishSuggestDateTime
            };
            return model;
        }

    }
}

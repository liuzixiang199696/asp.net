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
    public Suggest Publish(string title, string Content, DateTime dateTime,int id)
    {
        Suggest suggest = new Suggest
        {
            //User = new UserRepoistory().GetById(id),
            Title = title,
            SuggestContent = Content,
            PublishSuggestDateTime = dateTime,
            Id=id
        };
        return _suggestRepoistory.Save(suggest,id);

    }
    public SRVSuggestModel GetById(int id)
    {
       List<Suggest> suggest = _suggestRepoistory.GetById(id);
        if (id == 0)
        {
            return null;
        }
        else
        {
            //    SRVSuggestModel model = new SRVSuggestModel
            //    {
            //        Items = new IList<Item>
            //        {

            //        }
            //        Id = suggest.Id,
            //        SuggestTitle = suggest.SuggestTitle,
            //        SuggestContent = suggest.SuggestContent,
            //        PublishSuggestDateTime = suggest.PublishSuggestDateTime
            //    };return null;
            //    return model;
            return null;
        }

    }
}

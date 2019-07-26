using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.repoistory;
using SRV;

public class SuggestService
{
    private SuggestRepoistory _suggestRepoistory;
    private Suggest _suggest;
    private SuggestModel _suggestmodel;
    public List<Suggest> suggests { get; set; }
    public SuggestService()
    {
        _suggestRepoistory = new SuggestRepoistory();
        _suggestmodel = new SuggestModel();
        _suggest = new Suggest();
    }
    public Suggest Publish(string title, string Content, DateTime dateTime, int id)
    {
        Suggest suggest = new Suggest
        {
            //User = new UserRepoistory().GetById(id),
            Title = title,
            SuggestContent = Content,
            PublishSuggestDateTime = dateTime,
            Id = id
        };
        return _suggestRepoistory.Save(suggest, id);

    }
    public List<Suggest> GetById()
    {
        suggests = _suggestRepoistory.GetById();

        return suggests;
    }

}


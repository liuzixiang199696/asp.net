using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.entity;
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
    public void Publish(string title, string Content, DateTime dateTime, int autherid)
    {
        Suggest suggest = new Suggest
        {
            Title = title,
            Content = Content,
            PublishSuggestDateTime = dateTime,
            Id  =autherid
        };
        suggest.Publish(suggest);

    }
    public List<Suggest> GetSuggest()
    {
        suggests = _suggestRepoistory.GetSuggest();

        return suggests;
    }


}


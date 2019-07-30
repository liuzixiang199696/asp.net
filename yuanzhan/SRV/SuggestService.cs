using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.entity;
using BLL.repoistory;
using SRV;

public class SuggestService: BaseService
{
    private SuggestRepoistory _suggestRepoistory;
    private Suggest _suggest;
    private SuggestModel _suggestmodel;
    public List<Suggest> suggests { get; set; }
    public SuggestService(SuggestRepoistory suggestRepoistory, SuggestModel suggestmodel, Suggest suggest)
    {
        _suggestRepoistory = suggestRepoistory;
        _suggestmodel = suggestmodel;
        _suggest = suggest;
    }
    public void Publish(string title, string Content, DateTime dateTime, int autherid)
    {
        autherid = _suggest.Id;
        title = _suggest.Title;
        Content = _suggest.Content;
        dateTime = _suggest.PublishSuggestDateTime;
        _suggest.Publish(_suggest);

    }
    public List<Suggest> GetSuggest()
    {
        suggests = _suggestRepoistory.GetSuggest();

        return suggests;
    }


}


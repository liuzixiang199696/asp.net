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
    public List<Suggest> suggests { get; set; }
    public SuggestService(SuggestRepoistory suggestRepoistory, Suggest suggest)
    {
        _suggestRepoistory = suggestRepoistory;
        _suggest = suggest;
    }
    public void Publish(string title, string Content, DateTime dateTime, int autherid)
    {      
        _suggest.Title = title  ;
        _suggest.Content = Content  ;
        _suggest.PublishSuggestDateTime = dateTime  ;
        _suggest.AutherId= autherid;
        _suggest.Publish(_suggest);

    }
    public List<Suggest> GetSuggest()
    {
        suggests = _suggestRepoistory.GetSuggest();

        return suggests;
    }


}

